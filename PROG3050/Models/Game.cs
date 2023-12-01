using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please, enter a title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, enter a description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please, enter a price")]
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be number.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please, enter a publish date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "Game Category")]
        public int GameCategoryId { get; set; }
        public GameCategory? GameCategory { get; set; }

        // Many to Many Relationship Configuration
        public IList<Review>? Reviews { get; set; }
        public IList<OrderGame>? OrderGames { get; set; }
        public IList<Cart>? Carts { get; set; }
    }
}
