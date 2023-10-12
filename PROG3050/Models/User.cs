using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        // TODO: UserName Unique using [Remote]

        [Display(Name = "Mailing Address")]
        public int MailingAddressId { get; set; }
        public MailingAddress? MailingAddress { get; set; }

        [Display(Name = "Addresses are same")]
        public bool IsAddressSame { get; set; }

        [Display(Name = "Gender")]
        public int GenderId { get; set; } = 3;
        public Gender Gender { get; set; }

        // TODO: Date Validation future
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Promotional Email")]
        public bool IsPromotionalEmail { get; set; }

        [CreditCard]
        public string? CreditCard { get; set; }

        [Display(Name = "Preference")]
        public int PreferenceId { get; set; }
        public Preference Preference { get; set; }
    }
}
