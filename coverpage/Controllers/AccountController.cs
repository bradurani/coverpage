using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coverpage.Models;
using coverpage.data;

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
            if (!ModelState.IsValid)
                return View(model);
            else
            {
                CoverPageEntities context = new CoverPageEntities();
                string hashedPassword = model.Password.GetHashCode().ToString();
                User user = context.Users.Where(u => u.email == model.UserName && u.password == hashedPassword).SingleOrDefault();
                if (user == null)
                    return View(model);
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
        public ActionResult Register(User model)
        {
            if(ModelState.IsValid)
            {
                model.password = model.password.GetHashCode().ToString();
                CoverPageEntities context = new CoverPageEntities();
                context.Users.Add(model);
                context.SaveChanges();
                return View("User", model);
            }
            else
            {
                return View(model);
            }
           
        }

        public ActionResult EditAccount()
        {
            if ((bool)Session["logged_in"] != true)
                throw new Exception("User not logged in");
            return View();
        }

        
    }
}
