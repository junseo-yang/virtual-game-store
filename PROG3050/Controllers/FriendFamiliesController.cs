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
    public class FriendFamiliesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public FriendFamiliesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: FriendFamilies
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var applicationDbContext = _context.FriendFamily
                                        .Include(ff => ff.ReceiverUser)
                                        .Include(ff => ff.RequesterUser)
                                        .Where(ff => ff.RequesterUserId == currentUser.Id || ff.ReceiverUserId == currentUser.Id);
            ViewData["CurrentUserId"] = currentUser.Id;
            return View(await applicationDbContext.ToListAsync());
        }

        // POST: UserFriendFamilies/Request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Request(string? requesterUserId, string? receiverUserId, string? description)
        {
            if (receiverUserId == null)
            {
                return NotFound();
            }

            try
            {
                var currentUser = await _userManager.GetUserAsync(User);
                var friendFamily = await _context.FriendFamily
                                            .Where(ff => ff.RequesterUserId == requesterUserId && ff.ReceiverUserId == receiverUserId)
                                            .FirstOrDefaultAsync();

                if (description == "Accept")
                {
                    friendFamily.Status = "Processed";
                }
                else
                {
                    _context.Remove(friendFamily);
                }
                
                await _context.SaveChangesAsync();

                TempData["GlobalStatusMessage"] = $"{description} has been performed successfully.";
                TempData["GlobalStatusMessageClass"] = "success";
            }
            catch (Exception ex)
            {
                TempData["GlobalStatusMessage"] = $"Something went wrong while performing {description} .";
                TempData["GlobalStatusMessageClass"] = "danger";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
