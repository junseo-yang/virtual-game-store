using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PROG3050.Data;
using PROG3050.Models;
using PROG3050.ViewModel;
using System.Linq;

namespace PROG3050.Controllers
{
    [Authorize]
    public class DownloadController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;


        public DownloadController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            var processedOrders = _context.Order
                .Where(o => o.UserId == user.Id && o.Status == "Processed")
                .ToList();

            // Get the free game for download
            var freeGame = _context.Game.FirstOrDefault(g => g.Title == "Counter-Strike 2");

            // Get the purchased games for download
            var purchasedGames = _context.OrderGame
                .Where(og => processedOrders.Select(po => po.OrderId).Contains(og.OrderId))
                .Select(og => og.Game)
                .Distinct()
                .Where(g => g.GameId != freeGame.GameId)
                .ToList();

            var viewModel = new DownloadViewModel
            {
                FreeGame = freeGame,
                PurchasedGames = purchasedGames
            };

            return View(viewModel);
        }


        public IActionResult DownloadGame(int gameId)
        {
            var content = "This is a placeholder for the game content.";
            var fileName = "game_download.txt";

            return File(System.Text.Encoding.UTF8.GetBytes(content), "text/plain", fileName);
        }

    }
}
