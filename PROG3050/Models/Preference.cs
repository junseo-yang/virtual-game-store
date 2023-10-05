using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Preference
    {
        public int PreferenceId { get; set; }

        public bool PromotionalEmail { get; set; }

        [Required(ErrorMessage = "Please, enter a favourite platform name")]
        [Display(Name = "Favourite Platform Name")]
        public int FavouritePlatformId { get; set; }
        public FavouritePlatform FavouritePlatform { get; set; }
    }
}
