using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class GameCategory
    {
        public int GameCategoryId { get; set; }

        [Required(ErrorMessage = "Please, enter a game category name")]
        [Display(Name = "Game Category Name")]
        public string GameCategoryName { get; set; }

        public IList<PreferenceGameCategory> PreferenceGameCategories { get; set; }
    }
}
