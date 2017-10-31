using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace BLL.Models
{
   public class LoginInput
    {
        [CustomEmailValidator]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Enter your password.")]
        public string Password { get; set; }

        public class CustomEmailValidator : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value != null)
                {
                    string email = value.ToString();

                    if (Regex.IsMatch(email, @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", RegexOptions.IgnoreCase))
                    {
                        return ValidationResult.Success;
                    }
                    else
                    {
                        return new ValidationResult("Entered Email is not in good format.");
                    }
                }
                else
                {
                    return new ValidationResult("Enter a valid Email.");
                }
            }
        }
    }
}
