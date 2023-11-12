using PROG3050.Validations;
using System.ComponentModel.DataAnnotations;

namespace PROG3050.Models
{
    public class Report
    {
        public int ReportId { get; set; }

        [Required(ErrorMessage = "Please, enter a name")]
        public string Name { get; set; }

        public byte[]? Content { get; set; }

        [ValidationReportCreatedDate(ErrorMessage = "Created Date Time is out of range.")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
