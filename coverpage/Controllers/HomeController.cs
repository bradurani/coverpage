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
            return View(model);
        }

        public ActionResult MostViewed(string language)
        {
            MostViewedModel model = new MostViewedModel();
            if (language == null)
                language = "en";
            model.Language = language;
            model.Articles = GetAllArticles(language);
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
            return model;
        }

        

    }
}
