//using ALR_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirLine_ClassLibrary;


namespace ALR_02.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View(objLoginModel);
        }
        public ActionResult Register()
        {
            RegisterModel objUserModel = new RegisterModel();
            return View(objUserModel);
        }


        [HttpPost]
        public ActionResult Register(RegisterModel objUserModel)
        {
            if (ModelState.IsValid)
            {
                RegisterModel objUSer = new RegisterModel();
               // objUSer.CreatedOn = DateTime.Now;
                // obj.UserId = objUserModel.UserId;
                objUSer.Username = objUserModel.Username;
               // objUSer.LastName = objUserModel.LastName;
                objUSer.EmailId = objUserModel.EmailId;
                objUSer.Password = objUserModel.Password;
               // objUserDBEntities.Users.Add(objUSer);
                //objUserDBEntities.SaveChanges();
               // objUserModel = new UserModel();
                //objUserModel.SuccessMessage = "User Registered successfully";
                // Console.log();
                //  UserModel objUserModel = new UserModel();
                return View(objUserModel);
            }
            else
            {
                return View();
            }
        }




        [HttpPost]
        public ActionResult Login(LoginModel objLoginModel)
        {
            /* if (ModelState.IsValid)
             {
                // var obj = objUserDBEntities.Users.Where(s => s.Email.Equals(objLoginModel.Email) && s.Password.Equals(objLoginModel.Password)).FirstOrDefault();
               //  if (obj != null)
                 {
                    // Session["Email"] = objLoginModel.Email;
                     return RedirectToAction("Index", "Home");
                     //return Redirect("/Home/Index");
                 }
                 else
                 {
                     ModelState.AddModelError("Error", "Email and Password is not Matching");
                     ViewBag.LoginError = "Invalid";
                     return View();
                 }
             }
             else
             {
                 ModelState.AddModelError("Error", "Email and Password is not Matching");
                 ViewBag.LoginError = "Please Enter EmailID and Pasword";
                 return View();
             }
             // objLoginModel=new LoginModel();*/

            //return Redirect("/Home/Index");
            return View(objLoginModel);
        }
    }
}