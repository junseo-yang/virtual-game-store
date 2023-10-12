using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Preference
    {
        public int PreferenceId { get; set; }

        public IList<PreferenceGameCategory> PreferenceGameCategories { get; set; }

        public IList<PreferenceFavouritePlatform> PreferenceFavouritePlatforms { get; set; }

        [Display(Name = "Language")]
        public int LanguageId { get; set; } = 1;
        public Language Language { get; set; }
    }
}
