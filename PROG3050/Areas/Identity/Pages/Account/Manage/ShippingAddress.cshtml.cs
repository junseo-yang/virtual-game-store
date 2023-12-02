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
    public class ShippingAddressModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;

        public ShippingAddressModel(
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
            [Display(Name = "Unit")]
            public string? Unit { get; set; }

            [Display(Name = "Street")]
            public string? Street { get; set; }

            [Display(Name = "City")]
            public string? City { get; set; }

            [Display(Name = "Country")]
            public int CountryId { get; set; }
            public Country Country { get; set; }

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
            var shippingAddress = _context.ShippingAddress.Include(sa => sa.Province.Country).Where(sa => sa.ShippingAddressId == user.ShippingAddressId).FirstOrDefault();

            Input = new InputModel
            {
                Unit = shippingAddress.Unit,
                Street = shippingAddress.Street,
                City = shippingAddress.City,
                CountryId = shippingAddress.Province.CountryId,
                ProvinceId = shippingAddress.ProvinceId,
                PostalCode = shippingAddress.PostalCode,
                DeliveryInstruction = shippingAddress.DeliveryInstruction
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

            ViewData["CountryId"] = new SelectList(_context.Country, "CountryId", "CountryName");
            ViewData["ProvinceId"] = new SelectList(_context.Province.Where(p => p.CountryId == user.MailingAddress.Province.CountryId), "ProvinceId", "ProvinceName");

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
            var shippingAddress = _context.ShippingAddress.Where(m => m.ShippingAddressId == user.ShippingAddressId).FirstOrDefault();

            if (Input.Unit != shippingAddress.Unit)
            {
                shippingAddress.Unit = Input.Unit;
                _context.Update(shippingAddress);
                _context.SaveChanges();
            }
            if (Input.Street != shippingAddress.Street)
            {
                shippingAddress.Street = Input.Street;
                _context.Update(shippingAddress);
                _context.SaveChanges();
            }
            if (Input.City != shippingAddress.City)
            {
                shippingAddress.City = Input.City;
                _context.Update(shippingAddress);
                _context.SaveChanges();
            }
            if (Input.ProvinceId != shippingAddress.ProvinceId)
            {
                shippingAddress.ProvinceId = Input.ProvinceId;
                _context.Update(shippingAddress);
                _context.SaveChanges();
            }
            if (Input.PostalCode != shippingAddress.PostalCode)
            {
                shippingAddress.PostalCode = Input.PostalCode;
                _context.Update(shippingAddress);
                _context.SaveChanges();
            }
            if (Input.DeliveryInstruction != shippingAddress.DeliveryInstruction)
            {
                shippingAddress.DeliveryInstruction = Input.DeliveryInstruction;
                _context.Update(shippingAddress);
                _context.SaveChanges();
            }

            StatusMessage = "Your shipping address has been updated";
            return RedirectToPage();
        }
    }
}
