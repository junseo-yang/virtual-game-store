using PROG3050.Validations;
using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Display(Name = "User")]
        public string? UserId { get; set; }
        public User? User { get; set; }

        public string Status { get; set; } = "Pending";

        [Required(ErrorMessage = "Please, enter a order date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Order Date")]
        [ValidationOrderDate(ErrorMessage = "Order Date is out of range.")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Shipping Address")]
        public string? ShippingAddress { get; set; }

        [Display(Name = "Order Cost")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Please enter a valid number with up to 2 decimal places.")]
        public double? OrderCost { get; set; }

        // Many to Many Relationship Configuration
        public IList<OrderGame>? OrderGames { get; set; }
    }
}
