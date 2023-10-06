using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Please, enter a first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please, enter a last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // TODO: UserName Unique using [Remote]

        [Required(ErrorMessage = "Please, enter a mailing address")]
        [Display(Name = "Mailing Address")]
        public int MailingAddressId { get; set; }
        public MailingAddress MailingAddress { get; set; }

        [Display(Name = "Addresses are same")]
        public bool IsAddressSame { get; set; }

        [Required(ErrorMessage = "Please, enter a gender")]
        [Display(Name = "Gender")]
        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Please, enter a date of birth")]
        // TODO: Date Validation future
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [CreditCard]
        public string? CreditCard { get; set; }

        [Required(ErrorMessage = "Please, enter a preference")]
        [Display(Name = "Preference")]
        public int PreferenceId { get; set; }
        public Preference Preference { get; set; }
    }
}
