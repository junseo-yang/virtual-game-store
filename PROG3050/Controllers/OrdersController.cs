using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROG3050.Data;
using PROG3050.Models;
using PROG3050.ViewModel;

namespace PROG3050.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;

        public OrdersController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Order
                                                .Include(o => o.User)
                                                .Include(o => o.ShippingAddress)
                                                .ThenInclude(sa => sa.Province)
                                                .ThenInclude(p => p.Country);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.User)
                .Include(o => o.ShippingAddress)
                .ThenInclude(sa => sa.Province)
                .ThenInclude(sa => sa.Country)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,UserId,Status,OrderDate,ShippingAddress,OrderCost")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            return View(order);
        }

        // GET: Orders/Edit/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                                        .Include(o => o.User)
                                        .Include(o => o.ShippingAddress)
                                        .ThenInclude(sa => sa.Province)
                                        .ThenInclude(p => p.Country)
                                        .Where(o => o.OrderId == id)
                                        .FirstOrDefaultAsync();
            if (order == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,UserId,Status,OrderDate,ShippingAddress,OrderCost")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            return View(order);
        }

        // GET: Orders/Approve/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Approve(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            
            order.Status = "Processed";
            _context.Update(order);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // GET: Orders/Approve/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Shipping(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            order.Status = "Shipping";
            _context.Update(order);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // GET: Orders/Delete/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .Include(o => o.User)
                .Include(o => o.ShippingAddress)
                .ThenInclude(sa => sa.Province)
                .ThenInclude(p => p.Country)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Order == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Order'  is null.");
            }
            var order = await _context.Order.FindAsync(id);
            if (order != null)
            {
                _context.Order.Remove(order);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: UserOrders
        public async Task<IActionResult> UserOrders()
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;

            var orders = await _context.Order
                .Include(o => o.ShippingAddress)
                .ThenInclude(sa => sa.Province)
                .ThenInclude(p => p.Country)
                .Where(o => o.UserId == userId)
                .ToListAsync();

            return View(orders);
        }

        // GET: UserOrder
        public async Task<IActionResult> UserOrder(int id)
        {
            var userId = _userManager.GetUserAsync(User).Result.Id;

            var order = await _context.Order
                .Include(o => o.ShippingAddress)
                .ThenInclude(sa => sa.Province)
                .ThenInclude(p => p.Country)
                .Where(o => o.UserId == userId)
                .Where(o => o.OrderId == id)
                .FirstOrDefaultAsync();

            var orderGames = await _context.OrderGame
                .Where(og => og.OrderId == id)
                .ToListAsync();

            List<CartGameViewModel> games = new List<CartGameViewModel>();

            foreach (var orderGame in orderGames)
            {
                var game = await _context.Game!.Where(g => g.GameId == orderGame.GameId).FirstOrDefaultAsync();

                var gameItem = new CartGameViewModel()
                {
                    Title = game!.Title,
                    Price = game!.Price,
                    Quantity = orderGame.Quantity,
                };

                games.Add(gameItem);
            }


            UserOrderViewModel userOrderViewModel = new UserOrderViewModel()
            {
                Order = order,
                Games = games
            };

            return View(userOrderViewModel);
        }

        private bool OrderExists(int id)
        {
          return (_context.Order?.Any(e => e.OrderId == id)).GetValueOrDefault();
        }
    }
}
