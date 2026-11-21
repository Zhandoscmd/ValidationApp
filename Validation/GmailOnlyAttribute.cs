using System.ComponentModel.DataAnnotations;

namespace ValidationApp.Validation
{
    public class GmailOnlyAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(
            object? value, ValidationContext validationContext)
        {
            if (value is string email &&
                !email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                return new ValidationResult("Тек @gmail.com пошта қабылданады");
            }

            return ValidationResult.Success;
        }
    }
}