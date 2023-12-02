﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using PROG3050.Data;
using PROG3050.Models;
using PROG3050.ViewModel;

namespace PROG3050.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index() // View Cart
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;

            var cartGames = await _context.Cart
                .Where(c => c.UserId == userId)
                .Include(c => c.Game)
                .Select(c => new CartGameViewModel
                {
                    GameId = c.Game!.GameId,
                    Title = c.Game.Title,
                    Quantity = c.Quantity,
                    Price = c.Game.Price
                })
                .ToListAsync();

            if (cartGames.Count == 0)
            {
                TempData["EmptyCartNotice"] = "Your cart is empty, add some games first!";
                return RedirectToAction("Index", "Games");
            }

            var cartViewModel = new CartViewModel
            {
                UserId = userId,
                CartGames = cartGames
            };

            return View(cartViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int? gameId)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (gameId == null || await _context.Game!.FindAsync(gameId) == null || currentUser == null)
            {
                return NotFound();
            }

            var userId = currentUser.Id;

            var cart = await _context.Cart
                .Where(c => c.UserId == userId && c.GameId == gameId)
                .FirstOrDefaultAsync();

            if (cart == null) // New cart addition
            {
                Cart cartItem = new Cart()
                {
                    UserId = userId,
                    GameId = gameId,
                    Quantity = 1
                };

                _context.Cart.Add(cartItem);

            } else //Adding additional of the same game
            {
                cart.Quantity++;
                _context.Cart.Update(cart);
            }

            await _context.SaveChangesAsync();

            var gameTitle = await _context.Game
                .Where(g => g.GameId == gameId)
                .Select(g => g.Title)
                .FirstOrDefaultAsync();

            if (!Request.Headers["Referer"].ToString().EndsWith("/Cart"))
            {
                TempData["AddedGameMessage"] = gameTitle + " was added to your cart!";
            }
                
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int? gameId)
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;

            var cart = await _context.Cart
                .Where(c => c.UserId == userId && c.GameId == gameId)
                .FirstOrDefaultAsync();

            cart!.Quantity--;

            if (cart.Quantity == 0)
            {
                _context.Cart.Remove(cart);
            } else
            {
                _context.Cart.Update(cart);
            }

            _context.SaveChanges();

            return Redirect("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAllFromCart(int? gameId)
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;

            var cart = await _context.Cart
                .Where(c => c.UserId == userId && c.GameId == gameId)
                .FirstOrDefaultAsync();

            _context.Cart.Remove(cart!);
            _context.SaveChanges();

            return Redirect("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            // For the form
            var user = _userManager.GetUserAsync(User).Result;

            var shippingAddress = _context.ShippingAddress.Include(sa => sa.Province.Country).Where(m => m.ShippingAddressId == user.ShippingAddressId).FirstOrDefault();

            var creditCard = "";
            if (user.CreditCard != null)
            {
                creditCard = user.CreditCard;
            }
            var creditCardExpiry = new DateTime?();
            if (user.CreditCardExpiry.HasValue)
            {
                creditCardExpiry = user.CreditCardExpiry;
            }

            var checkoutViewModel = new CheckoutViewModel()
            { 
                ShippingAddress = shippingAddress,
                CreditCard = creditCard,
                CreditCardExpiry = creditCardExpiry,
            };

            //var provinces = await _context.Province!.ToListAsync();
            //var countries = await _context.Country!.ToListAsync();

            //ViewBag.country = new selectlist(countries, "countryid", "countryname", checkoutViewModel.countryid);
            //ViewBag.province = new selectlist(provinces, "provinceid", "provincename", checkoutViewModel.provinceid);

            ViewBag.CountryId = new SelectList(_context.Country, "CountryId", "CountryName");
            ViewBag.ProvinceId = new SelectList(_context.Province.Where(p => p.CountryId == user.ShippingAddress.Province.CountryId), "ProvinceId", "ProvinceName");

            // For the cart view on side
            List<CartGameViewModel> cartItems = new List<CartGameViewModel>();
            var cart = await _context.Cart
                .Where(c => c.UserId == user.Id)
                .ToListAsync();

            foreach (var cartGame in cart)
            {
                var game = await _context.Game!.Where(g => g.GameId == cartGame.GameId).FirstOrDefaultAsync();

                var gameItem = new CartGameViewModel()
                {
                    Title = game!.Title,
                    Price = game!.Price,
                    Quantity = cartGame.Quantity,
                };

                cartItems.Add(gameItem);
            }

            // Both sides put together
            CheckoutCartViewModel checkoutCartViewModel = new CheckoutCartViewModel()
            {
                Checkout = checkoutViewModel,
                Cart = cartItems
            };

            return View(checkoutCartViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutCartViewModel model)
        {
            var user = _userManager.GetUserAsync(User).Result;
            var creditCardExpiry = model.Checkout.CreditCardExpiry.Value;

            if (ModelState.IsValid && 
                (creditCardExpiry.Year > DateTime.Now.Year || 
                (creditCardExpiry.Year == DateTime.Now.Year && creditCardExpiry.Month >= DateTime.Now.Month)))
            {
                var cartGames = await _context.Cart
                    .Where(c => c.UserId == user.Id)
                    .Include(c => c.Game)
                    .ToListAsync();

                double totalCost = 0;

                foreach (var cartGame in cartGames)
                {
                    totalCost += cartGame.Quantity * cartGame.Game!.Price;
                }

                //// Add to Orders
                //Order order = new Order()
                //{
                //    UserId = userId,
                //    Status = "Pending",
                //    OrderDate = DateTime.Now,
                //    ShippingAddress = $"{model.Checkout.Street}, {model.Checkout.City}, {province}, {country}, {model.Checkout.PostalCode}",
                //    OrderCost = totalCost
                //};

                var shippingAddress = model.Checkout.ShippingAddress!;

                Order order = new Order()
                {
                    UserId = user.Id,
                    OrderDate = DateTime.Now,
                    OrderCost = totalCost,
                    Unit = shippingAddress.Unit,
                    Street = shippingAddress.Street,
                    City = shippingAddress.City,
                    ProvinceId = shippingAddress.ProvinceId,
                    PostalCode = shippingAddress.PostalCode,
                    DeliveryInstruction = shippingAddress.DeliveryInstruction
                };

                _context.Order!.Add(order);
                _context.SaveChanges();

                // Add to OrderGames
                foreach (var cartGame in cartGames)
                {
                    OrderGame orderGame = new OrderGame()
                    {
                        OrderId = order.OrderId,
                        GameId = cartGame.GameId!.Value,
                        Quantity = cartGame.Quantity
                    };

                    _context.OrderGame!.Add(orderGame);
                }
                _context.SaveChanges();

                // Remove from cart table
                var cart = await _context.Cart.Where(c => c.UserId == user.Id).ToListAsync();
                _context.Cart.RemoveRange(cart);
                _context.SaveChanges();

                return Redirect("Success");
            } else
            {
                if (model.Checkout.CreditCardExpiry < DateTime.Now)
                {
                    TempData["ExpiryDateError"] = "Cannot be expired credit card.";
                }

                //ViewBag.Province = new SelectList(provinces, "ProvinceId", "ProvinceName", model.Checkout.ProvinceId);
                //ViewBag.Country = new SelectList(countries, "CountryId", "CountryName", model.Checkout.CountryId);

                ViewBag.CountryId = new SelectList(_context.Country, "CountryId", "CountryName");
                ViewBag.ProvinceId = new SelectList(_context.Province.Where(p => p.CountryId == user.ShippingAddress.Province.CountryId), "ProvinceId", "ProvinceName");

                List<CartGameViewModel> cartItems = new List<CartGameViewModel>();
                var cart = await _context.Cart
                    .Where(c => c.UserId == user.Id)
                    .ToListAsync();

                foreach (var cartGame in cart)
                {
                    var game = await _context.Game!.Where(g => g.GameId == cartGame.GameId).FirstOrDefaultAsync();

                    var gameItem = new CartGameViewModel()
                    {
                        Title = game!.Title,
                        Price = game!.Price,
                        Quantity = cartGame.Quantity,
                    };

                    cartItems.Add(gameItem);
                }

                CheckoutCartViewModel checkoutCartViewModel = new CheckoutCartViewModel()
                {
                    Checkout = model.Checkout,
                    Cart = cartItems
                };

                return View(checkoutCartViewModel);
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> Success()
        {
            return View();
        }
    }
}
