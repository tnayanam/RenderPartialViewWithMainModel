using System.ComponentModel.DataAnnotations;
using WebApplication3.Models;

namespace WebApplication3.CustomValidation
{
    public class AmountBasedOnAge : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var form = (Form)validationContext.ObjectInstance;

            return (form.age > 18 && form.amount > 100) ? ValidationResult.Success : new ValidationResult("Age is less than 18 nand amount is grteater than 100");
        }
    }
}