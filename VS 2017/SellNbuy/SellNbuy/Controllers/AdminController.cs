using BLL.Models;
using System.Web.Mvc;
using BLL.Manager;
using System.Collections.Generic;
using DAL;
using System.Linq;
using System.Data;



namespace SellNbuy.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        AdminManager db = new AdminManager();
        SellNbuyEntities db1 = new SellNbuyEntities();

        public ActionResult Ctaegory_Edit_Delete()
        {
            var result = db1.motors.ToList();
            List<EntyMotors> obj = new List<EntyMotors>();
            foreach (var item in result)
            {
                obj.Add(new EntyMotors
                {
                    Id = item.id,
                    cat = item.cat
                }
                );

            }

            return View(obj);
        }
        

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Category(EntyMotors collection)
        {
            if (collection.cat != null)
            {

                EntyMotors tbl_obj = new EntyMotors
                {
                    cat = collection.cat
                };
                string result = db.saveCat(collection);
                    ViewBag.Res = result;
                    if (result == "Success")
                    {
                        ModelState.Clear();
                    }
                
            }
            else if(collection.Job_Cat!=null)
            {

                EntyMotors tbl_obj = new EntyMotors
                {
                    Job_Cat = collection.Job_Cat
                };
                string res = db.JobCat(collection);
                    ViewBag.Result = res;
                    if (res == "Success")
                    {
                        ModelState.Clear();
                    }
            }
            else if (collection.Pro_Cat != null)
            {
                EntyMotors tbl_obj = new EntyMotors
                {
                    Pro_Cat = collection.Pro_Cat
                };
                string res = db.ProCat(collection);
                ViewBag.pro = res;
                if (res == "Success")
                {
                    ModelState.Clear();
                }
            }
            else if (collection.Community_Cat != null)
            {
                EntyMotors tbl_obj = new EntyMotors
                {
                    Community_Cat = collection.Community_Cat
                };
                string res = db.CommunityCat(collection);
                ViewBag.Community = res;
                if (res == "Success")
                {
                    ModelState.Clear();
                }
            }
            else if (collection.Classifieds_Cat != null)
            {
                EntyMotors tbl_obj = new EntyMotors
                {
                    Classifieds_Cat = collection.Classifieds_Cat
                };
                string res = db.ClassifiedsCat(collection);
                ViewBag.Classifieds = res;
                if (res == "Success")
                {
                    ModelState.Clear();
                }
            }


            return View();
        }

        public ActionResult Category()
        {
            return View();
        }

        //
        // GET: /Admin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Admin/Create

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
        // GET: /Admin/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/Edit/5

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
        // GET: /Admin/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/Delete/5

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
