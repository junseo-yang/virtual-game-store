using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Preference
    {
        public int PreferenceId { get; set; }

        public bool PromotionalEmail { get; set; }

        [Display(Name = "Favourite Platform Name")]
        public int FavouritePlatformId { get; set; } = 1;
        public FavouritePlatform FavouritePlatform { get; set; }

        public IList<PreferenceGameCategory> PreferenceGameCategories { get; set; }
    }
}
