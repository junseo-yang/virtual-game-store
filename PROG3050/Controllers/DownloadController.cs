using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PROG3050.Data;
using PROG3050.Models;
using PROG3050.ViewModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

            var freeGame = _context.Game.Where(g => g.Price == 0).ToList();

            var purchasedGames = _context.OrderGame
                .Where(og => processedOrders.Select(po => po.OrderId).Contains(og.OrderId))
                .Select(og => og.Game)
                .Distinct()
                .AsEnumerable()
                .Where(g => !freeGame.Any(fg => fg.GameId == g.GameId))
                .ToList();

            var viewModel = new DownloadViewModel
            {
                FreeGame = freeGame,
                PurchasedGames = purchasedGames
            };

            return View(viewModel);
        }


        public async Task<IActionResult> DownloadGame(int gameId)
        {
            if (gameId == null)
            {
                return NotFound();
            }

            var selectedGame = await _context.Game.FirstOrDefaultAsync(g => g.GameId == gameId);

            var gameTitle = selectedGame.Title;
            var gameDescription = selectedGame.Description;


            var content = gameDescription;
            var fileName = gameTitle + ".txt";

            return File(System.Text.Encoding.UTF8.GetBytes(content), "text/plain", fileName);
        }

    }
}
