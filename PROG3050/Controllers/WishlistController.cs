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
            }

            return RedirectToAction("Index", "Games");
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

        public IActionResult ShareWishlist()
        {
            var wishlistLink = "https://example.com/wishlist"; // Replace with the actual link to your wishlist page
            var wishlistDescription = "Check out my wishlist!"; // Replace with a description or title for the shared content

            // Construct shareable links for Facebook, Instagram, and Twitter
            var facebookShareLink = $"https://www.facebook.com/sharer/sharer.php?u={wishlistLink}";
            var instagramShareLink = $"https://www.instagram.com/?url={wishlistLink}&title={wishlistDescription}";
            var twitterShareLink = $"https://twitter.com/intent/tweet?url={wishlistLink}&text={wishlistDescription}";

            // You can redirect the user to these links or use them as needed in your application.

            // For demonstration purposes, let's redirect to a page showing these links.
            var viewModel = new ShareLinksViewModel
            {
                FacebookShareLink = facebookShareLink,
                InstagramShareLink = instagramShareLink,
                TwitterShareLink = twitterShareLink
            };

            return View("ShareLinks", viewModel);
        }

        // Add a new ViewModel class for ShareLinks if needed
        public class ShareLinksViewModel
        {
            public string FacebookShareLink { get; set; }
            public string InstagramShareLink { get; set; }
            public string TwitterShareLink { get; set; }
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var wishlistItems = _context.Wishlist
                .Include(w => w.Game) 
                .Where(w => w.UserId == user.Id)
                .ToList();

            var viewModel = new WishlistViewModel
            {
                Wishlist = wishlistItems
            };

            return View(viewModel);
        }

    }
}
