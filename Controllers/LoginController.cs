using Student_management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_management.Controllers
{
    public class LoginController : Controller
    {
        Student_managementEntities db = new Student_managementEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User ObjCheck)

        {
            if (ModelState.IsValid)
            {
                using (Student_managementEntities db = new Student_managementEntities())
                {



                    var obj = db.Users.Where(a => a.User_Id.Equals(ObjCheck.User_Id) && a.User_Password.Equals(ObjCheck.User_Password)).FirstOrDefault();

                    if (obj != null)
                    {
                        Session["UserID"] = obj.User_Id.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Yhe username or password incorrect");
                    }
                }

               // return View(ObjCheck);

            }
            return View(ObjCheck);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}