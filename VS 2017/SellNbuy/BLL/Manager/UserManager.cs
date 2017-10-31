using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.Models;
using System.Web.Mvc;

namespace BLL.Manager
{
    public class UserManager
    {
        SellNbuyEntities db1 = new SellNbuyEntities();

        public string UserInsert(UserInput obj)
        {
            return db1.userInsert(obj.name,obj.mail,obj.password,obj.phoneno).FirstOrDefault();
        }

        public string LoginCheck(LoginInput obj)
        {
            return db1.LoginCheck(obj.Mail, obj.Password).FirstOrDefault();
        }

        public string Pro_Motor_Insert(MotorInput obj)
        {
            return db1.Pro_Motor_Insert(obj.CatID, obj.Title, obj.Company, obj.Photo, obj.KM, obj.Year, obj.Body, obj.Engine, obj.Fuel, obj.HP, obj.Phoneno, obj.Price, obj.Description, obj.Location, obj.D_Discription).FirstOrDefault();
        }





    }
}
