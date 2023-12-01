using System.ComponentModel.DataAnnotations;

namespace PROG3050.ViewModel
{
    public class CheckoutViewModel
    {
        [Display(Name = "Street")]
        [Required(ErrorMessage = "Please enter your street address.")]
        public string? Street { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter your city.")]
        public string? City { get; set; }

        [Display(Name = "Province")]
        [Required(ErrorMessage = "Please select your province.")]
        public int? ProvinceId { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please select your country.")]
        public int? CountryId { get; set; }

        [Display(Name = "Postal Code")]
        [RegularExpression(@"[A-Z][0-9][A-Z] [0-9][A-Z][0-9]$",
            ErrorMessage = "Postal Code should be in the format of 'A1A 1A1'")]
        [Required(ErrorMessage = "Please enter your postal code.")]
        public string? PostalCode { get; set; }

        [Display(Name = "Credit Card Number")]
        [RegularExpression(@"^(?:4[0-9]{12}(?:[0-9]{3})?|(?:5|2)[1-5][0-9]{14})$", ErrorMessage = "Invalid Credit Card number.")]
        [Required(ErrorMessage = "Please enter your credit card number.")]
        public string? CreditCard { get; set; }

        [Display(Name = "Expiry")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter your credit card expiry date.")]
        public DateTime? CreditCardExpiry { get; set; }

        [Display(Name = "CVC")]
        [RegularExpression(@"^\d\d\d$", ErrorMessage = "Invalid CVC.")]
        [Required(ErrorMessage = "Please enter your credit card's CVC number.")]
        public int? CVC { get; set; }
    }
}
