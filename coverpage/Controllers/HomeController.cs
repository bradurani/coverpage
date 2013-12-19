using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coverpage.Models;
using coverpage.data;

namespace coverpage.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Article(string language, string country, int articleId)
        {
            if (language == null)
                language = "en";
            CoverPageEntities context = new CoverPageEntities();
            var model = context.Articles.Where(article => article.article_id == articleId && article.language == language).First();
            return View(model);
        }

        public ActionResult MostViewed(string language)
        {
            MostViewedModel model = new MostViewedModel();
            if (language == null)
                language = "en";
            model.Language = language;

            CoverPageEntities context = new CoverPageEntities();
            model.Articles = context.Articles.Where(article => article.language == language).ToList();
            
            model.LoggedIn = Session["logged_in"] == null ? false : (bool)Session["logged_in"];
            model.Name = model.LoggedIn ? (string)Session["name"] : "";
            return View(model);
        }

        public ActionResult MostPopular()
        {
            return View();
        }

       

        private CommentModel GetCommentModel()
        {
            //CommentModel model = new CommentModel();
            //model.Name = "Harry Smith;";
            //model.Comment = "Nice Article";

            return new CommentModel()
            {
                Comment = "Nice Article!!!!",
                Name = "Harry Smith"
            };
        }

        

    }
}
