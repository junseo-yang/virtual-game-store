// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PROG3050.Data;
using PROG3050.Models;

namespace PROG3050.Areas.Identity.Pages.Account.Manage
{
    public class PreferenceModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;

        public PreferenceModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            public List<SelectListItem> DropFavouritePlatforms { get; set; }

            [Required(ErrorMessage = "Choose at least 1 favourite platform.")]
            [Display(Name = "Favourite Platforms")]
            public int[] FavouritePlatformIds { get; set; }

            [Display(Name = "Language")]
            public int LanguageId { get; set; }
            public Language Language { get; set; }
        }

        private async Task LoadAsync(User user)
        {
            var preference = _context.Preference.Include(p => p.PreferenceFavouritePlatforms).Where(p => p.PreferenceId == user.PreferenceId).FirstOrDefault();

            List<int> favouritePlatformIds = new List<int>();
            preference.PreferenceFavouritePlatforms.ToList().ForEach(r => favouritePlatformIds.Add(r.FavouritePlatformId));


            Input = new InputModel
            {
                DropFavouritePlatforms = _context.FavouritePlatform.Select(fp => new SelectListItem { Text = fp.FavouritePlatformName, Value = fp.FavouritePlatformId.ToString() }).ToList(),
                FavouritePlatformIds = favouritePlatformIds.ToArray(),
                LanguageId = preference.LanguageId
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);

            ViewData["FavouritePlatformId"] = new SelectList(_context.FavouritePlatform, "FavouritePlatformId", "FavouritePlatformName");
            ViewData["LanguageId"] = new SelectList(_context.Language, "LanguageId", "LanguageName");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            // Update FavouritePlatform and Language
            var preference = _context.Preference.Include(p => p.PreferenceFavouritePlatforms).Where(p => p.PreferenceId == user.PreferenceId).FirstOrDefault();

            // first find PreferenceFavouritePlatforms list and then remove all from db that belongs to preference
            List<PreferenceFavouritePlatform> preferenceFavouritePlatforms = new List<PreferenceFavouritePlatform>();
            
            preference.PreferenceFavouritePlatforms.ToList().ForEach(r => preferenceFavouritePlatforms.Add(r));
            _context.RemoveRange(preferenceFavouritePlatforms);

            // Update PreferenceFavouritePlatforms
            preferenceFavouritePlatforms = new List<PreferenceFavouritePlatform>();

            foreach (var favouritePlatform in Input.FavouritePlatformIds)
            {
                preferenceFavouritePlatforms.Add(
                    new PreferenceFavouritePlatform
                    {
                        PreferenceId = preference.PreferenceId,
                        FavouritePlatformId = favouritePlatform
                    }
                );
            }
            preference.PreferenceFavouritePlatforms = preferenceFavouritePlatforms;
            _context.SaveChanges();

            if (Input.LanguageId != preference.LanguageId)
            {
                preference.LanguageId = Input.LanguageId;
                _context.Update(preference);
                _context.SaveChanges();
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your preference has been updated";
            return RedirectToPage();
        }
    }
}
