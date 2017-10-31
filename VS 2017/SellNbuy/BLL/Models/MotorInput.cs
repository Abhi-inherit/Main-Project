using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Web;

namespace BLL.Models
{
    public class MotorInput 
    {
        [Required(ErrorMessage = "Select a category for your vehicle.")]
        public int CatID { get; set; }
        
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Enter a title for your advertisement.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter your vehicle company.")]
        public string Company { get; set; }

        //[Required(ErrorMessage = "Please upload a picture of your vehicle.")]
        public string Photo { get; set; }

        [Required(ErrorMessage = "Please upload a picture of your vehicle.")]
        public HttpPostedFileBase file1 { get; set; }

        [Required(ErrorMessage = "Mention the total kilometer run by vehicle.")]
        public int KM { get; set; }

        [Required(ErrorMessage = "Mention year of manufacturing.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Mention Body condition.")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Mention engine type and specifications.")]
        public string Engine { get; set; }

        [Required(ErrorMessage = "Enter fuel type.")]
        public string Fuel { get; set; }

        [Required(ErrorMessage = "Enter HP of your vehicle.")]
        public string HP { get; set; }

        [Required(ErrorMessage = "Enter valid phone number.")]
        public string Phoneno { get; set; }

        [Required(ErrorMessage = "Enter price expectation of seller.")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Briefly describe about your vehicle.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter the location of vehicle.")]
        public string Location { get; set; }

        public string D_Discription { get; set; }

        public bool PowerWindow { get; set; }
        public bool AirBag { get; set; }
        public bool FoggLight { get; set; }
        public bool NitroPack { get; set; }
        public bool CoolFilim { get; set; }
        public bool MultiBraking { get; set; }
        public bool AC { get; set; }
        public bool TopLight { get; set; }
        public bool OffRoadKit { get; set; }
        public bool RadialTyre { get; set; }
    }
}
