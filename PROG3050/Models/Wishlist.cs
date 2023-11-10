using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG3050.Models
{
    public class Wishlist
    {
        [Display(Name = "User")]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }

        [Display(Name = "Game")]
        public int GameId { get; set; }
        [ForeignKey("GameId")]
        public Game? Game { get; set; }
    }

}
