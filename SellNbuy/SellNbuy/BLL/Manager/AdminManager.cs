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

        SellNbuyEntities db1 = new SellNbuyEntities();

        public string saveCat(EntyMotors obj)
        {
            return db1.MotorInsert(obj.cat).FirstOrDefault();
        }

        public string JobCat(EntyMotors obj)
        {
            return db1.JobInsert(obj.Job_Cat).FirstOrDefault();
        }

        public string ProCat(EntyMotors obj)
        {
            return db1.PropInsert(obj.Pro_Cat).FirstOrDefault();
        }

        public string ClassifiedsCat(EntyMotors obj)
        {
            return db1.classifiedsInsert(obj.Classifieds_Cat).FirstOrDefault();
        }

        public string CommunityCat(EntyMotors obj)
        {
            return db1.communityInsert(obj.Community_Cat).FirstOrDefault();
        }

    }
}
