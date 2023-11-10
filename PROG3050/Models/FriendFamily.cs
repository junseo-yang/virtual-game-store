using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG3050.Models
{
    public class FriendFamily
    {
        [Required]
        [Display(Name = "Requester")]
        public string RequesterUserId { get; set; }
        public User? RequesterUser { get; set; }

        [Required]
        [Display(Name = "Receiver")]
        public string? ReceiverUserId { get; set; }
        public User? ReceiverUser { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Status { get; set; } = "Pending";
    }
}
