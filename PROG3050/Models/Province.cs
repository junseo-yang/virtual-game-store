using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Province
    {
        public int ProvinceId { get; set; }
        [Required(ErrorMessage = "Please, enter a province name")]
        [Display(Name = "Province Name")]
        public string ProvinceName { get; set; }

        [Required(ErrorMessage = "Please, enter a country name")]
        [Display(Name = "Country Name")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
