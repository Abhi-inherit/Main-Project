using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BLL.Models
{
    public class EntyMotors
    {
        [ScaffoldColumn(false)] //ScaffoldColumn - Allows hiding fields from editor forms
        public int Id { get; set; }

        [Required]  //Required - Indicates that the property is a required field
        [DisplayName("Motor category")] //DisplayName - Defines the text to be used on form fields and validation messages
        public string cat { get; set; }

        [ScaffoldColumn(false)] //ScaffoldColumn - Allows hiding fields from editor forms
        public int Job_Id { get; set; }

        [Required]  //Required - Indicates that the property is a required field
        [DisplayName("Job category")] //DisplayName - Defines the text to be used on form fields and validation messages
        public string Job_Cat { get; set; }

        [ScaffoldColumn(false)] //ScaffoldColumn - Allows hiding fields from editor forms
        public int Pro_Id { get; set; }

        [Required]  //Required - Indicates that the property is a required field
        [DisplayName("Property category")] //DisplayName - Defines the text to be used on form fields and validation messages
        public string Pro_Cat { get; set; }
    }
}
