using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class EventUser
    {
        [Required(ErrorMessage = "Please, enter an event")]
        [Display(Name = "Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }

        [Required(ErrorMessage = "Please, enter a user")]
        [Display(Name = "User")]
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
