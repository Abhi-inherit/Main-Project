using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Models;

namespace BLL.Models
{
    public partial class EntyMotors
    {
        public int Id { get; set; }
        public string cat { get; set; }
        public int Job_Id { get; set; }
        public string Job_Cat { get; set; }
        public int Pro_Id { get; set; }
        public string Pro_Cat { get; set; }
        public int Community_ID { get; set; }
        public string Community_Cat { get; set; }
        public int Classifieds_ID { get; set; }
        public string Classifieds_Cat { get; set; }

    }
}
