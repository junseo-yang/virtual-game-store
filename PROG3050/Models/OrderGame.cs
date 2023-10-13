using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class OrderGame
    {
        public int OrderGameId { get; set; }

        [Required(ErrorMessage = "Please, enter an order")]
        [Display(Name = "Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [Required(ErrorMessage = "Please, enter a game")]
        [Display(Name = "Game")]
        public int GameId { get; set; }
        public Game Game { get; set; }

        [Required(ErrorMessage = "Please, enter a quantity")]
        [Display(Name = "Quantity")]
        [Range(1, 100, ErrorMessage = "Price must be a int value, also greater than or equal to 1 and less than 100.")]
        public int Quantity { get; set; }
    }
}
