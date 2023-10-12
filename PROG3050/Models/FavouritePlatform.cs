using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class FavouritePlatform
    {
        public int FavouritePlatformId { get; set; }

        [Required(ErrorMessage = "Please, enter a favourite platform name")]
        [Display(Name = "Favourite Platform Name")]
        public string FavouritePlatformName { get; set; }

        public IList<PreferenceFavouritePlatform> PreferenceFavouritePlatforms { get; set; } 
    }
}
