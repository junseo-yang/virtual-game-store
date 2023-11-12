using System.ComponentModel.DataAnnotations;

namespace PROG3050.Validations
{
    public class ValidationOrderDate : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var orderDate = value as DateTime? ?? new DateTime();

            if (orderDate < DateTime.MinValue || DateTime.Now.Date < orderDate.Date)
            {
                return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
    }
}
