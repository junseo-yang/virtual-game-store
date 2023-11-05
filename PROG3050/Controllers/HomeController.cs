using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROG3050.Data;
using PROG3050.Models;
using PROG3050.ViewModel;
using System.Diagnostics;

namespace PROG3050.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Search(HomeViewModel vmFromBody)
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            try
            {
                if (vmFromBody != null && string.IsNullOrEmpty(vmFromBody.Title))
                    throw new Exception("PLEASE ENTER A GAME TITLE");

                var games = await _context.Game.Include(g => g.GameCategory).ToListAsync();
                var title = vmFromBody.Title;
                var sortedGames = games.Where(x => x.Title.ToLower().Contains(title.ToLower()));

                if (!sortedGames.Any())
                    throw new Exception("NOT FOUND GAMES");

                homeViewModel.Games = sortedGames;

            }
            catch(Exception ex)
            {
                homeViewModel.ErrorMessage = ex.Message;
            }

            return View("Index", homeViewModel);
        }

        [Authorize]
        public async Task<IActionResult> AllSearch()
        {
            var games = await _context.Game.Include(g => g.GameCategory).OrderBy(x => x.GameId).ToListAsync();

            HomeViewModel vm = new HomeViewModel()
            {
                Games = games,
            };

            return View("Index", vm);
        }

        [Authorize]
        public async Task<ActionResult> Detail(int id)
        {
            var games = await _context.Game.Include(g => g.GameCategory).ToListAsync();
            var game = games.FirstOrDefault(x => x.GameId.Equals(id));
            HomeViewModel homVM = new HomeViewModel()
            {
                Games = games,
                CurrentGame = game,
            };

            return View(homVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}