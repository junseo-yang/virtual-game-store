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

namespace PROG3050.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public ReviewsController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var roles = await _userManager.GetRolesAsync(currentUser);
            if (roles.Contains("SuperAdmin") || roles.Contains("Admin") || roles.Contains("Moderator"))
            {
                var reviews = _context.Review.Include(r => r.Game).Include(r => r.User);
                return View(await reviews.ToListAsync());
            }
            else
            {
                var reviews = _context.Review.Include(r => r.Game)
                                            .Include(r => r.User)
                                            .Where(r => r.UserId == currentUser.Id);
                return View(await reviews.ToListAsync());
            }
        }

        // GET: Reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Game)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReviewId == id);
            if (review == null)
            {
                return NotFound();
            }

            // Validate the review owned by the current user or SuperAdmin/Admin/Moderator
            var currentUser = await _userManager.GetUserAsync(User);
            if (review.UserId == currentUser.Id || User.IsInRole("SuperAdmin") || User.IsInRole("Admin") || User.IsInRole("Moderator"))
            {
                return View(review);
            }

            TempData["GlobalStatusMessage"] = $"You don't have permission to the review.";
            TempData["GlobalStatusMessageClass"] = "danger";
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        // GET: Reviews/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Title");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName");
            ViewData["Status"] = new SelectList(new List<string>() { "Pending", "Processed" });
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewId,Title,Description,Rating,Status,UserId,GameId")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Title", review.GameId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", review.UserId);
            ViewData["Status"] = new SelectList(new List<string>() { "Pending", "Processed" }, review.Status);
            return View(review);
        }

        // POST: Reviews/WriteReview
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> WriteReview([Bind("ReviewId,Title,Description,Rating,Status,UserId,GameId")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                
                TempData["GlobalStatusMessage"] = $"Your review has been requested sucessfully. SuperAdmin/Admin/Moderator will take a look and process it shortly.";
                TempData["GlobalStatusMessageClass"] = "success";
                
                return RedirectToAction("Details", "Games", new { id = review.GameId });
            }
            TempData["GlobalStatusMessage"] = $"Title, Description, and Rating are required.";
            TempData["GlobalStatusMessageClass"] = "danger";
            return RedirectToAction("Details", "Games", new { id = review.GameId });
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            // Validate the review owned by the current user or SuperAdmin/Admin/Moderator
            var currentUser = await _userManager.GetUserAsync(User);
            if (review.UserId == currentUser.Id || User.IsInRole("SuperAdmin") || User.IsInRole("Admin") || User.IsInRole("Moderator"))
            {
                ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Title", review.GameId);
                ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", review.UserId);
                ViewData["Status"] = new SelectList(new List<string>() { "Pending", "Processed" }, review.Status);
                return View(review);
            }

            TempData["GlobalStatusMessage"] = $"You don't have permission to the review.";
            TempData["GlobalStatusMessageClass"] = "danger";
            return RedirectToAction(nameof(Index));            
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewId,Title,Description,Rating,Status,UserId,GameId")] Review review)
        {
            if (id != review.ReviewId)
            {
                return NotFound();
            }

            // Validate the review owned by the current user or SuperAdmin/Admin/Moderator
            var currentUser = await _userManager.GetUserAsync(User);
            if (review.UserId == currentUser.Id || User.IsInRole("SuperAdmin") || User.IsInRole("Admin") || User.IsInRole("Moderator"))
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(review);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ReviewExists(review.ReviewId))
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
                ViewData["GameId"] = new SelectList(_context.Game, "GameId", "Title", review.GameId);
                ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", review.UserId);
                ViewData["Status"] = new SelectList(new List<string>() { "Pending", "Processed" }, review.Status);
                return View(review);
            }

            TempData["GlobalStatusMessage"] = $"You don't have permission to the review.";
            TempData["GlobalStatusMessageClass"] = "danger";
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        public async Task<IActionResult> Approve(int? reviewId)
        {
            if (reviewId == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(reviewId);
            if (review == null)
            {
                return NotFound();
            }

            review.Status = "Processed";
            _context.Update(review);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Game)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.ReviewId == id);
            if (review == null)
            {
                return NotFound();
            }

            // Validate the review owned by the current user or SuperAdmin/Admin/Moderator
            var currentUser = await _userManager.GetUserAsync(User);
            if (review.UserId == currentUser.Id || User.IsInRole("SuperAdmin") || User.IsInRole("Admin") || User.IsInRole("Moderator"))
            {
                return View(review);
            }

            TempData["GlobalStatusMessage"] = $"You don't have permission to the review.";
            TempData["GlobalStatusMessageClass"] = "danger";
            return RedirectToAction(nameof(Index));
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Review == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Review'  is null.");
            }
            var review = await _context.Review.FindAsync(id);

            if (review != null)
            {
                // Validate the review owned by the current user or SuperAdmin/Admin/Moderator
                var currentUser = await _userManager.GetUserAsync(User);
                if (review.UserId == currentUser.Id || User.IsInRole("SuperAdmin") || User.IsInRole("Admin") || User.IsInRole("Moderator"))
                {
                    _context.Review.Remove(review);
                }
                else
                {
                    TempData["GlobalStatusMessage"] = $"You don't have permission to the review.";
                    TempData["GlobalStatusMessageClass"] = "danger";
                }
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
          return (_context.Review?.Any(e => e.ReviewId == id)).GetValueOrDefault();
        }
    }
}
