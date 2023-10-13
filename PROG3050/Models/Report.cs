using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Report
    {
        public int ReportId { get; set; }

        [Required(ErrorMessage = "Please, enter a name")]
        public string Name { get; set; }

        public byte[]? Content { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
