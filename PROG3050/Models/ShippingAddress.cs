﻿using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class ShippingAddress
    {
        public int ShippingAddressId { get; set; }

        [Display(Name = "Unit")]
        public string? Unit { get; set; }

        [Required(ErrorMessage = "Please, enter a street")]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please, enter a city")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please, enter a province")]
        [Display(Name = "Province")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Please, enter a country")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please, enter a postal code")]
        [RegularExpression(@"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] [0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]",
            ErrorMessage = "Postal Code should be in the format of 'A1A 1A1'")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Delivery Instruction")]
        public string? DeliveryInstruction { get; set; }
    }
}