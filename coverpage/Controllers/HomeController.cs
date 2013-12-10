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
                      
            ArticleModel model = new ArticleModel();
            DataFactory factory = new DataFactory(language);

            model.Headline = factory.GetHeadline(articleId);
            model.ArticleText = factory.GetArticleText(articleId);
            model.CommentSection = new CommentSectionModel();
            model.CommentSection.Comments = new List<CommentModel>();
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.CommentForm = new CommentFormModel();
            return View(model);
        }

        public ActionResult MostViewed(string language)
        {
            MostViewedModel model = new MostViewedModel();
            if (language == null)
                language = "en";
            model.Language = language;
            model.Articles = GetAllArticles(language);
            model.LoggedIn = Session["logged_in"] == null ? false : (bool)Session["logged_in"];
            model.Name = model.LoggedIn ? (string)Session["name"] : "";
            return View(model);
        }

        public ActionResult MostPopular()
        {
            return View();
        }

        private List<ArticleModel> GetAllArticles(string language)
        {
            
            List<ArticleModel> articles = new List<ArticleModel>();
            ArticleModel model1 = GetArticle(1, language);
            articles.Add(model1);
            ArticleModel model2 = GetArticle(2, language);
            articles.Add(model2);
            return articles;
        }

        private ArticleModel GetArticle(int articleId, string language)
        {
            DataFactory factory = new DataFactory(language);
            ArticleModel model = new ArticleModel();
            model.ArticleText = factory.GetArticleText(articleId);
            model.Headline = factory.GetHeadline(articleId);
            model.Id = articleId;
            model.CommentSection = new CommentSectionModel();
            model.CommentSection.Comments = new List<CommentModel>();
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.Comments.Add(GetCommentModel());
            model.CommentSection.CommentForm = new CommentFormModel();
            return model;
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
