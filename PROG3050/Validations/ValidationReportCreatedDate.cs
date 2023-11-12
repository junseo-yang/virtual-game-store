using System.ComponentModel.DataAnnotations;

namespace PROG3050.Validations
{
    public class ValidationReportCreatedDate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var createdDate = value as DateTime? ?? new DateTime();

            if (createdDate < DateTime.MinValue || DateTime.Now < createdDate)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
    }
}
