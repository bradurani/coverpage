using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using coverpage.Models;
using coverpage.data;

namespace coverpage.Controllers
{
    public class LikeController : Controller
    {
        //
        // GET: /Like/
        [HttpPost]
        public ActionResult Index(int articleId)
        {
            CoverPageEntities context = new CoverPageEntities();
            var dbLike = context.Likes.Where(like => like.articleid == articleId).FirstOrDefault();
            int count =0;
            if(dbLike == null)
            {
                Like newLike = new Like();
                newLike.articleid = articleId;
                newLike.count = 1;
                count =1;
                context.Likes.Add(newLike);
            }
            else
            {
                dbLike.count++;
                count = (int)dbLike.count;
            }
        
            context.SaveChanges();
            return Json(new { count = count });
        }

    }
}
