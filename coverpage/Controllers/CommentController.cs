using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coverpage.Models;
namespace coverpage.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Comment/
        [HttpPost]
        public ActionResult AddComment(CommentModel model)
        {
            return View();
        }

    }
}
