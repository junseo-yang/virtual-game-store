using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROG3050.Data;
using PROG3050.Models;
using PROG3050.ViewModel;

namespace PROG3050.Controllers
{
    public class WishlistController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;

        public WishlistController(UserManager<User> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index(string? userId)
        {
            var user = userId == null ? await _userManager.GetUserAsync(User) : await _userManager.FindByIdAsync(userId);

            var wishlistItems = _context.Wishlist
                .Include(w => w.Game)
                .Where(w => w.UserId == user.Id)
                .ToList();

            var viewModel = new WishlistViewModel
            {
                Wishlist = wishlistItems
            };

            if (userId != null)
            {
                ViewData["WishListUserName"] = user.UserName;
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishlist(int gameId)
        {
            var user = await _userManager.GetUserAsync(User);

            var existingWishlistItem = _context.Wishlist.FirstOrDefault(w => w.GameId == gameId && w.UserId == user.Id);

            if (existingWishlistItem == null)
            {
                var wishlistItem = new Wishlist
                {
                    GameId = gameId,
                    UserId = user.Id
                };

                _context.Wishlist.Add(wishlistItem);
                await _context.SaveChangesAsync();

                return Json(new { success = true });
            }

            return Json(new { success = false, message = "Game is already in the Wishlist!" });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromWishlist(int gameId)
        {
            var user = await _userManager.GetUserAsync(User);

            var wishlistItem = _context.Wishlist.FirstOrDefault(w => w.GameId == gameId && w.UserId == user.Id);

            if (wishlistItem != null)
            {
                _context.Wishlist.Remove(wishlistItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
