using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class PreferenceGameCategory
    {
        [Required(ErrorMessage = "Please, enter a preference name")]
        [Display(Name = "Preference Name")]
        public int PreferenceId { get; set; }
        public Preference Preference { get; set; }

        [Required(ErrorMessage = "Please, enter a game category name")]
        [Display(Name = "Game Category Name")]
        public int GameCategoryId { get; set; }
        public GameCategory GameCategory { get; set; }
    }
}
