using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class PreferenceFavouritePlatform
    {
        [Required(ErrorMessage = "Please, enter a preference name")]
        [Display(Name = "Preference Name")]
        public int PreferenceId { get; set; }
        public Preference Preference { get; set; }

        [Required(ErrorMessage = "Please, enter a favourite platform name")]
        [Display(Name = "Favourite Platform Name")]
        public int FavouritePlatformId { get; set; }
        public FavouritePlatform FavouritePlatform { get; set; }
    }
}
