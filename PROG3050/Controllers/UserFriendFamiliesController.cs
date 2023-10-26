using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROG3050.Data;
using PROG3050.Models;
using System.Linq;

namespace PROG3050.Controllers
{
    [Authorize]
    public class UserFriendFamiliesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public UserFriendFamiliesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: UserFriendFamilies
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var friendFamily = _context.FriendFamily;
            
            // Select ReceiverUserIds that currentUser requested Friend/Family
            var receivers = await friendFamily.Where(ff => ff.RequesterUserId == currentUser.Id).Select(ff => ff.ReceiverUserId).ToListAsync();

            // Select ReceiverUserIds that currentUser requested Friend/Family
            var requesters = await friendFamily.Where(ff => ff.ReceiverUserId == currentUser.Id).Select(ff => ff.RequesterUserId).ToListAsync();

            // Exclude users that requested / got request from / and currentUser
            var users = await _context.User
                    .Include(u => u.FriendFamilyRequester)
                    .Include(u => u.FriendFamilyReceiver)
                    .Where(u => !receivers.Contains(u.Id) && !requesters.Contains(u.Id))
                    .Where(u => u.Id != currentUser.Id)
                    .ToListAsync();

            return View(users);
        }

        // POST: UserFriendFamilies/Request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Request(string? receiverUserId, string? description)
        {
            if (receiverUserId == null)
            {
                return NotFound();
            }

            try
            {
                var currentUser = await _userManager.GetUserAsync(User);
                var friendFamily = new FriendFamily
                {
                    RequesterUserId = currentUser.Id,
                    ReceiverUserId = receiverUserId,
                    Description = description == "Friend Request" ? "Friend" : "Family"
                };
                
                _context.Add(friendFamily);
                await _context.SaveChangesAsync();

                TempData["GlobalStatusMessage"] = $"{description} has been sent successfully.";
                TempData["GlobalStatusMessageClass"] = "success";
            }
            catch (Exception ex)
            {
                TempData["GlobalStatusMessage"] = $"Something went wrong while sending {description} .";
                TempData["GlobalStatusMessageClass"] = "danger";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
