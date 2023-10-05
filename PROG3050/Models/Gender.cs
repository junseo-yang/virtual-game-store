using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Gender
    {
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Please, enter a gender name")]
        [Display(Name = "Gender Name")]
        public string GenderName { get; set; }
    }
}
