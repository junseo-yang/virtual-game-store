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
using PROG3050.ViewModel;

namespace PROG3050.Controllers
{
    [Authorize]
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public EventsController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var eventList = await _context.Event.Include(x => x.EventUsers).ToListAsync();

            EventViewModel vm = new EventViewModel()
            {
                Events = eventList,
                CurrentUserId = currentUser.Id
            };

            return _context.Event != null ?
                          View(vm) :
                          Problem("Entity set 'ApplicationDbContext.Event'  is null.");
        }

        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.Include(x=>x.EventUsers)
                .FirstOrDefaultAsync(m => m.EventId == id);

            var users = await _context.EventUser.Where(x => x.EventId == id).Select(x => x.User).ToListAsync();

            if (@event == null)
            {
                return NotFound();
            }

            //Adds users to show in the detail view.
            var vm = new EventViewModel()
            {
                SelectedEvent = @event,
                Users = users
            };

            return View(vm);
        }

        // GET: Events/Create
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EventId,Title,Description,StartDateTime,EndDateTime")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EventId,Title,Description,StartDateTime,EndDateTime")] Event @event)
        {
            if (id != @event.EventId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.EventId))
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
            return View(@event);
        }

        // GET: Events/Delete/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [Authorize(Roles = "SuperAdmin,Admin,Moderator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Event == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Event'  is null.");
            }
            var @event = await _context.Event.FindAsync(id);
            if (@event != null)
            {
                _context.Event.Remove(@event);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Events/RegisterEvent/5
        public async Task<IActionResult> RegisterEvent(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            //Gets current user and selected event
            var currentUser = await _userManager.GetUserAsync(User);
            var selectedEvent = await _context.Event.Include(x => x.EventUsers).FirstOrDefaultAsync(x => x.EventId == id);

            //Creates EventUser. EventId: Selected event, UserId: Current user 
            var eventUser = new EventUser()
            {
                 EventId = selectedEvent.EventId,
                 UserId = currentUser.Id
            };

            //Adds eventUser into the db.
            _context.Add(eventUser);
            await _context.SaveChangesAsync();

            //Gets updated event list.
            var eventList = await _context.Event.Include(x => x.EventUsers).ToListAsync();

            //Creates view model
            EventViewModel vm = new EventViewModel()
            {
                Events = eventList,
                CurrentUserId = currentUser.Id
            };

            //Redirects to Index
            return RedirectToAction("Index",vm);
        }

        public async Task<IActionResult> CancelEvent(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            //Gets current user and selected event
            var currentUser = await _userManager.GetUserAsync(User);
            var selectedEvent = await _context.Event.Include(x => x.EventUsers).Where(x=>x.EventUsers.Where(x=>x.EventId ==  id).Where(x=>x.UserId == currentUser.Id).Any()).ToListAsync();

            var userEvent = await _context.EventUser.Where(x => x.EventId == id).FirstOrDefaultAsync(x=>x.UserId == currentUser.Id);

            //Removes from db.
            if(userEvent != null)
            {
                _context.EventUser.Remove(userEvent);
                await _context.SaveChangesAsync();
            }

            //Gets updated event list.
            var eventList = await _context.Event.Include(x => x.EventUsers).ToListAsync();

            //Creates view model
            EventViewModel vm = new EventViewModel()
            {
                Events = eventList,
                CurrentUserId = currentUser.Id
            };

            return RedirectToAction("Index");
        }

        private bool EventExists(int id)
        {
          return (_context.Event?.Any(e => e.EventId == id)).GetValueOrDefault();
        }
    }
}
