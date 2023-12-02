using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class ShippingAddress
    {
        public int ShippingAddressId { get; set; }

        [Display(Name = "Unit")]
        public string? Unit { get; set; }

        [Display(Name = "Street")]
        public string? Street { get; set; }

        [Display(Name = "City")]
        public string? City { get; set; }

        [Display(Name = "Province")]
        public int ProvinceId { get; set; } = 1;
        public Province? Province { get; set; }

        [Display(Name = "Postal Code")]
        [RegularExpression(@"[A-Z][0-9][A-Z] [0-9][A-Z][0-9]$",
            ErrorMessage = "Postal Code should be in the format of 'A1A 1A1'")]
        public string? PostalCode { get; set; }

        [Display(Name = "Delivery Instruction")]
        public string? DeliveryInstruction { get; set; }
    }
}
