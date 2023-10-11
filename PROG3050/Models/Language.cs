using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Language
    {
        public int LanguageId { get; set; }

        [Required(ErrorMessage = "Please, enter a language name")]
        [Display(Name = "LanguageName")]
        public string LanguageName { get; set; }
    }
}
