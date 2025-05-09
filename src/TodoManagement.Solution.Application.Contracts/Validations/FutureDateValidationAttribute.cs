using System;
using System.ComponentModel.DataAnnotations;

namespace TodoManagement.Solution.Validations
{
    public class FutureDateValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value is DateTime dueDate)
            {
                if (dueDate.Date < DateTime.Now.Date)
                {
                    return new ValidationResult(ErrorMessage ?? "Due date cannot be in the past!");
                }
            }
            return ValidationResult.Success;
        }
    }
}
