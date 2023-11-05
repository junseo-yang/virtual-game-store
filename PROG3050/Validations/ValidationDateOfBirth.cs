using System.ComponentModel.DataAnnotations;

namespace PROG3050.Validations
{
    public class ValidationDateOfBirth : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var dateOfBirth = value as DateTime? ?? new DateTime();

            if (dateOfBirth < DateTime.MinValue || DateTime.Now.Date < dateOfBirth.Date)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
    }
}
