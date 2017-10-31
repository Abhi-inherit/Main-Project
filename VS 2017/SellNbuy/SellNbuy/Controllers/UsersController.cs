using System.Web;
using System.Web.Mvc;
using BLL.Models;
using BLL.Manager;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;



namespace SellNbuy.Controllers
{
    public class UsersController : Controller
    {
        UserManager db = new UserManager();
        SellNbuyEntities db1 = new SellNbuyEntities();

        public ActionResult Motors()
        {
            this.ViewBag.CatID = new SelectList(this.db1.motors, "id", "cat");
            return View();
        }



        [HttpPost]
        public ActionResult Motors(MotorInput collection, HttpPostedFileBase file1)
        {

                try
                {
                        this.ViewBag.CatID = new SelectList(this.db1.motors, "id", "cat");

                        if (ModelState.IsValid)
                        {

                                

                                string y = "";

                                if (file1 != null && file1.ContentLength > 0)
                                {

                                    string FIlePath = System.IO.Path.GetFileName(file1.FileName).ToString();
                                    string FullPath = Server.MapPath("~/images/" + FIlePath);
                                    if (System.IO.File.Exists(FullPath))
                                    {
                                        int x = 1;
                                        while (System.IO.File.Exists(FullPath))
                                        {
                                            y = x.ToString() + FIlePath;
                                            FullPath = Server.MapPath("~/images/" + y);
                                            x++;
                                        }
                                        file1.SaveAs(FullPath);
                                    }
                                    else
                                    {
                                        file1.SaveAs(Server.MapPath("~/images/" + FIlePath));
                                        y = FIlePath;
                                    }
                                }

                                else
                                {
                                    // ViewData.Clear();
                                    // ViewBag.FileUpload = "Please select a clear photo of your vehicle.(Its important for selling advt).";
                                    return View(collection);
                                }

                            string description = "";

                            if (collection.PowerWindow == true)
                            {
                                description = description + "PowerWindow,";
                            }
                            if (collection.AirBag == true)
                            {
                                description = description + "AirBag,";
                            }
                            if (collection.FoggLight == true)
                            {
                                description = description + "FoggLight,";
                            }
                            if (collection.NitroPack == true)
                            {
                                description = description + "NitroPack,";
                            }
                            if (collection.CoolFilim == true)
                            {
                                description = description + "CoolFilim,";
                            }
                            if (collection.MultiBraking == true)
                            {
                                description = description + "MultiBraking,";
                            }
                            if (collection.AC == true)
                            {
                                description = description + "AC,";
                            }
                            if (collection.TopLight == true)
                            {
                                description = description + "TopLight,";
                            }
                            if (collection.OffRoadKit == true)
                            {
                                description = description + "OffRoadKit,";
                            }
                            if (collection.RadialTyre == true)
                            {
                                description = description + "RadialTyre,";
                            }

                            if (description != "")
                            {
                                description = description.Substring(0, description.Length - 1);
                            }






                            MotorInput obj = new MotorInput
                            {
                                CatID = collection.CatID,
                                Title = collection.Title,
                                Company = collection.Company,
                                Photo = y,
                                KM = collection.KM,
                                Year = collection.Year,
                                Body = collection.Body,
                                Engine = collection.Engine,
                                Fuel = collection.Fuel,
                                HP = collection.HP,
                                Phoneno = collection.Phoneno,
                                Price = collection.Price,
                                Description = collection.Description,
                                Location = collection.Location,
                                D_Discription = description
                            };

                            string res = db.Pro_Motor_Insert(obj);
                            if (res == "Success")
                            {
                                ModelState.Clear();
                                return RedirectToAction("Home", User);
                            }
                        }
                    return View(collection);

                }
            catch
                {
                    return View();
                }
        
        }

        public void BindMotorCat(int Id = 0)
        {

           

        }

        public ActionResult Classifieds()
        {
            return View();
        }

        public ActionResult Community()
        {
            return View();
        }

        public ActionResult Jobs()
        {
            return View();
        }

        public ActionResult PropSale()
        {
            return View();
        }

        public ActionResult PropRent()
        {
            return View();
        }

        public ActionResult PostAdd()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginInput collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    LoginInput obj = new LoginInput
                    {
                        Mail = collection.Mail,
                        Password = collection.Password
                    };

                    string res = db.LoginCheck(collection);

                    if (res != "Please check your inputs.")
                    {
                        ModelState.Clear();
                        Session.Add("Username", res);
                        return RedirectToAction("Home", User);
                    }
                    else
                    {
                        ViewBag.LoginError = res;
                    }

                    return View();
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
                
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserInput collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserInput obj = new UserInput
                    {
                        name = collection.name,
                        mail = collection.mail,
                        phoneno = collection.phoneno,
                        password = collection.password,
                        conPassword = collection.conPassword
                    };

                    string res = db.UserInsert(collection);

                    ViewBag.Result = res;
                    if (res == "Success")
                    {
                        ModelState.Clear();
                        return RedirectToAction("Home", User);
                    }
                    else if (res == "Already Exist")
                    {
                        ViewBag.result = "This Mail-Id is already registered with us.";
                        return View();
                    }

                    return View();
                }
                return View(collection);

            }
            catch
            {
                return View();
            }
                
        }

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Users/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Users/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Users/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Users/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Users/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Users/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Users/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
