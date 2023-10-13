using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Display(Name = "User")]
        public string UserId { get; set; }
        public User? User { get; set; }

        public string Status { get; set; } = "Pending";

        [Required(ErrorMessage = "Please, enter a order date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Shipping Address")]
        public int ShippingAddressId { get; set; }
        public ShippingAddress? ShippingAddress { get; set; }

        // Many to Many Relationship Configuration
        public IList<OrderGame>? OrderGames { get; set; }
    }
}
