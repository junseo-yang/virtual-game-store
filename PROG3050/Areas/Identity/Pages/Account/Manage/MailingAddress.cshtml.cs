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
using PROG3050.Data;
using PROG3050.Models;

namespace PROG3050.Areas.Identity.Pages.Account.Manage
{
    public class MailingAddressModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;

        public MailingAddressModel(
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

            [Display(Name = "First Name")]
            public string? FirstName { get; set; }

            [Display(Name = "Last Name")]
            public string? LastName { get; set; }

            [Display(Name = "Phone Number")]
            [Phone]
            [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number should be in the format of '999-999-9999'")]
            public string? PhoneNumber { get; set; }

            [Display(Name = "Unit")]
            public string? Unit { get; set; }

            [Display(Name = "Street")]
            public string? Street { get; set; }

            [Display(Name = "City")]
            public string? City { get; set; }

            [Display(Name = "Province")]
            public int ProvinceId { get; set; }
            public Province Province { get; set; }

            // TODO: Select Country and Populate the Province Dropdown

            [RegularExpression(@"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] [0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]",
                ErrorMessage = "Postal Code should be in the format of 'A1A 1A1'")]
            [Display(Name = "Postal Code")]
            public string? PostalCode { get; set; }

            [Display(Name = "Delivery Instruction")]
            public string? DeliveryInstruction { get; set; }
        }

        private async Task LoadAsync(User user)
        {
            var mailingAddress = _context.MailingAddress.Where(m => m.MailingAddressId == user.MailingAddressId).FirstOrDefault();

            Input = new InputModel
            {
                FirstName = mailingAddress.FirstName,
                LastName = mailingAddress.LastName,
                PhoneNumber = mailingAddress.PhoneNumber,
                Unit = mailingAddress.Unit,
                Street = mailingAddress.Street,
                City = mailingAddress.City,
                ProvinceId = mailingAddress.ProvinceId,
                PostalCode = mailingAddress.PostalCode,
                DeliveryInstruction = mailingAddress.DeliveryInstruction
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

            ViewData["ProvinceId"] = new SelectList(_context.Province, "ProvinceId", "ProvinceName");

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

            // Update Unit, Street, City, ProvinceId, PostalCode, DeliveryInstruction
            var mailingAddress = _context.MailingAddress.Where(m => m.MailingAddressId == user.MailingAddressId).FirstOrDefault();

            if (Input.FirstName != mailingAddress.FirstName)
            {
                mailingAddress.FirstName = Input.FirstName;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.LastName != mailingAddress.LastName)
            {
                mailingAddress.LastName = Input.LastName;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.PhoneNumber != mailingAddress.PhoneNumber)
            {
                mailingAddress.PhoneNumber = Input.PhoneNumber;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.Unit != mailingAddress.Unit)
            {
                mailingAddress.Unit = Input.Unit;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.Street != mailingAddress.Street)
            {
                mailingAddress.Street = Input.Street;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.City != mailingAddress.City)
            {
                mailingAddress.City = Input.City;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.ProvinceId != mailingAddress.ProvinceId)
            {
                mailingAddress.ProvinceId = Input.ProvinceId;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.PostalCode != mailingAddress.PostalCode)
            {
                mailingAddress.PostalCode = Input.PostalCode;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }
            if (Input.DeliveryInstruction != mailingAddress.DeliveryInstruction)
            {
                mailingAddress.DeliveryInstruction = Input.DeliveryInstruction;
                _context.Update(mailingAddress);
                _context.SaveChanges();
            }

            StatusMessage = "Your mailing address has been updated";
            return RedirectToPage();
        }
    }
}
