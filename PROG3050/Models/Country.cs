using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Country
    {
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Please, enter a country name")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
    }
}
