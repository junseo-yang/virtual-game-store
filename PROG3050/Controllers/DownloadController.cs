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
            if (_context.OrderGame == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OrderGame' is null.");
            }

            var user = await _userManager.GetUserAsync(User);

            if (_context.Game == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Game' is null.");
            }

            var freeGames = await _context.Game.Where(g => g.Price == 0).ToListAsync();

            var purchasedGames = await _context.OrderGame
                        .Include(og => og.Order)
                        .Include(og => og.Game)
                        .Where(og => og.Order.Status == "Processed" && og.Order.UserId == user.Id)
                        .Where(og => og.Game.Price != 0)
                        .Select(og => og.Game)
                        .Distinct()
                        .ToListAsync();

            var viewModel = new DownloadViewModel
            {
                FreeGames = freeGames,
                PurchasedGames = purchasedGames
            };

            return View(viewModel);
        }


        public async Task<IActionResult> DownloadGame(int? gameId)
        {
            if (gameId == null || _context.OrderGame == null)
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
