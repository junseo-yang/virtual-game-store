// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using PROG3050.Data;
using PROG3050.Models;

namespace PROG3050.Areas.Identity.Pages.Account.Manage
{
    public class CreditCardModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;

        public CreditCardModel(
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
            [Display(Name = "Credit Card Number")]
            [RegularExpression(@"^(?:4[0-9]{12}(?:[0-9]{3})?|(?:5|2)[1-5][0-9]{14})$",
                ErrorMessage = "Invalid Credit Card number.")]
            public string? CreditCard { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime? CreditCardExpiry { get; set; }
        }

        private async Task LoadAsync(User user)
        {
            var creditCard = await _context.User
                .Where(u => u.Id == user.Id)
                .Select(u => new {u.CreditCard, u.CreditCardExpiry})
                .FirstOrDefaultAsync();

            Input = new InputModel
            {
                CreditCard = creditCard.CreditCard,
                CreditCardExpiry = creditCard.CreditCardExpiry
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

            // Update Credit card number, Credit card expiry
            var userToUpdate = await _context.User
                .Where(u => u.Id == user.Id)
                .FirstOrDefaultAsync();

            if (Input.CreditCard != userToUpdate.CreditCard)
            {
                userToUpdate.CreditCard = Input.CreditCard;
                _context.Update(userToUpdate);
                _context.SaveChanges();
            }
            if (Input.CreditCardExpiry != userToUpdate.CreditCardExpiry)
            {
                userToUpdate.CreditCardExpiry = Input.CreditCardExpiry;
                _context.Update(userToUpdate);
                _context.SaveChanges();
            }

            StatusMessage = "Your credit card has been updated";
            return RedirectToPage();
        }
    }
}
