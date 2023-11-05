using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Event : IValidatableObject
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please, enter a title")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please, enter a description")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please, enter a start date time")]
        [Display(Name = "Start Date Time")]
        public DateTime StartDateTime { get; set; }

        [Required(ErrorMessage = "Please, enter a end date time")]
        [Display(Name = "End Date Time")]
        public DateTime EndDateTime { get; set; }

        public IList<EventUser>? EventUsers { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDateTime > EndDateTime)
            {
                yield return new ValidationResult("Start Date Time cannot be after End Date Time.");
            }
        }
    }
}
