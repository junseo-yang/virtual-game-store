using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required(ErrorMessage = "Please, enter a title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, enter a description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please, enter a rating")]
        [Display(Name = "Rating")]
        [DisplayFormat(DataFormatString = "{0:0.0}", ApplyFormatInEditMode = true)]
        [Range(1, 5, ErrorMessage = "Price must be a double value, also greater than or equal to 1 and less than 5.")]
        public double Rating { get; set; }

        public string Status { get; set; } = "Pending";

        [Display(Name = "User")]
        public string UserId { get; set; }
        public User? User { get; set; }

        [Display(Name = "Game")]
        public int GameId { get; set; }
        public Game? Game { get; set; }
    }
}
