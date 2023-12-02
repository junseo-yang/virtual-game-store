using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class ShippingAddress
    {
        public int ShippingAddressId { get; set; }

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

        [Required(ErrorMessage = "Please, enter a street")]
        [Display(Name = "Street")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please, enter a city")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please, enter a province")]
        [Display(Name = "Province")]
        public int ProvinceId { get; set; } = 1;
        public Province? Province { get; set; }

        [Required(ErrorMessage = "Please, enter a postal code")]
        [RegularExpression(@"[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] [0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]",
            ErrorMessage = "Postal Code should be in the format of 'A1A 1A1'")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Delivery Instruction")]
        public string? DeliveryInstruction { get; set; }
    }
}
