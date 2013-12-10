using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coverpage.Models;

namespace coverpage.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

       

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(SignInModel model)
        {
            bool isValid = IsValidUser(model);
            if (!isValid)
            {
                ModelState.AddModelError("", "Your username or password is invalid");
                return View(model);
            }
            else
            {
                Session["logged_in"] = true;
                Session["name"] = model.UserName;
                return RedirectToAction("MostViewed", "Home");
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("MostViewed", "Home");
            }
            return View(model);
        }

        private bool IsValidUser(SignInModel model)
        {
            //DATABASE WOULD DO THIS NORMALLY
            if(model.UserName == "brad" && model.Password == "password")
                return true;
            return false;
        }

        
    }
}
