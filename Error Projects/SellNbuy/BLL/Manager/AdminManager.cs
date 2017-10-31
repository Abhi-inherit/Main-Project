using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Models;


namespace BLL.Manager
{
    public class AdminManager
    {

        SellNbuyEntities db = new SellNbuyEntities();

        public string saveCat(EntyMotors obj)
        {
            return db.MotorInsert(obj.cat).FirstOrDefault();
        }

        public string JobCat(EntyMotors obj)
        {
            return db.JobInsert(obj.Job_Cat).FirstOrDefault();
        }



    }
}
