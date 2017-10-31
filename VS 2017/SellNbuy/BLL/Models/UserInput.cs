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
    public class UserInput
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter your name.")]
        public string name { get; set; }

        [CustomEmailValidator]
        public string mail { get; set; }

        [Required(ErrorMessage = "Enter your password.")]
        public string password { get; set; }

        [Required(ErrorMessage = "Check your re-entered password.")]
#pragma warning disable CS0618 // Type or member is obsolete
        [System.Web.Mvc.Compare("password",ErrorMessage = "The password and confirmation password do not match.")]
#pragma warning restore CS0618 // Type or member is obsolete
        public string conPassword { get; set; }

        [Required(ErrorMessage = "Enter a vaild phone number.")]
        public string phoneno { get; set; }

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
