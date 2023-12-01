using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
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
    public class GamesController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Games
        public async Task<IActionResult> Index()
        {
            GameViewModel vm = new GameViewModel();

            try
            {
                var games = await _context.Game
                                    .Include(g => g.GameCategory)
                                    .Include(g => g.Reviews)
                                    .ToListAsync();
                vm.Games = games;

                var user = await _userManager.GetUserAsync(User);

                vm.UserWishlistGameIds = await _context.Wishlist
                    .Where(w => w.UserId == user.Id)
                    .Select(w => w.GameId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                vm.ErrorMessage = ex.Message;
            }

            ViewBag.AddedGameMessage = TempData["AddedGameMessage"] as string;
            return View(vm);
        }

        /// <summary>
        /// Search for the entered game title in the DB.
        /// If there are no games in the DB, an error message is displayed.
        /// If user do a search without entering a game title, it will show a list of all games with an error message.
        /// </summary>
        /// <param name="vmFromBody"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Search(GameViewModel vmFromBody)
        {
            GameViewModel vm = new GameViewModel();

            try
            {
                List<Game> games = await _context.Game
                                            .Include(g => g.GameCategory)
                                            .Include(g => g.Reviews)
                                            .ToListAsync();
                string title = vmFromBody.Title;

                if (vmFromBody != null && string.IsNullOrEmpty(vmFromBody.Title))
                {
                    vm.ErrorMessage = "Please enter a game title";
                    vm.Games = games;
                }
                else
                {
                    var searchedGames = games?.Where(x => x.Title.ToLower().Contains(title.ToLower() ?? string.Empty));
                    vm.Games = searchedGames;

                    var user = await _userManager.GetUserAsync(User);

                    vm.UserWishlistGameIds = await _context.Wishlist
                                                    .Where(w => w.UserId == user.Id)
                                                    .Select(w => w.GameId)
                                                    .ToListAsync();
                    if (!searchedGames.Any())
                        vm.ErrorMessage = $"The game you searched for is not in the database. Entered Title: {vmFromBody.Title}";
                }
            }
            catch (Exception ex)
            {
                vm.ErrorMessage = ex.Message;
            }

            return View("Index", vm);
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Game == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.GameCategory)
                .Include(g => g.Reviews)
                .ThenInclude(r => r.User)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            // Retrieve recommended games with same category as the current game as well, ordered by newest release
            bool sameCategory = true;
            var recommendedGames = await _context.Game
                .Where(g => g.GameCategoryId == game.GameCategoryId && g.GameId != game.GameId)
                .OrderByDescending(g => g.PublishDate)
                .Take(3)
                .ToListAsync();

            if (recommendedGames.Count == 0)
            {
                // If no games of same genre, get a list of the newest releases
                sameCategory = false;
                recommendedGames = await _context.Game
                    .Where(g => g.GameId != game.GameId)
                    .OrderByDescending(g => g.PublishDate)
                    .Take(3)
                    .Include(g => g.GameCategory)
                    .ToListAsync();
            }

            var gameDetailsViewModel = new GameDetailsViewModel
            {
                Game = game,
                RecommendedGames = recommendedGames,
                SameCategory = sameCategory,
                Reviews = game.Reviews.ToList()
            };

            ViewBag.AddedGameMessage = TempData["AddedGameMessage"] as string;
            return View(gameDetailsViewModel);
        }

        // GET: Games/Create
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public IActionResult Create()
        {
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "GameCategoryId", "GameCategoryName");
            return View();
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GameId,Title,Description,Price,PublishDate,GameCategoryId")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "GameCategoryId", "GameCategoryName", game.GameCategoryId);
            return View(game);
        }

        // GET: Games/Edit/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Game == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "GameCategoryId", "GameCategoryName", game.GameCategoryId);
            return View(game);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameId,Title,Description,Price,PublishDate,GameCategoryId")] Game game)
        {
            if (id != game.GameId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.GameId))
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
            ViewData["GameCategoryId"] = new SelectList(_context.GameCategory, "GameCategoryId", "GameCategoryName", game.GameCategoryId);
            return View(game);
        }

        // GET: Games/Delete/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Game == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.GameCategory)
                .FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Game == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Game'  is null.");
            }
            var game = await _context.Game.FindAsync(id);
            if (game != null)
            {
                _context.Game.Remove(game);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
          return (_context.Game?.Any(e => e.GameId == id)).GetValueOrDefault();
        }
    }
}
