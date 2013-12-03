using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace coverpage
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           // routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AccountRoute",
                url: "members/account/{action}",
                defaults: new { controller = "Account", action = "Index" }
           );

            routes.MapRoute(
                name: "ArticleRoute",
                url: "content/article",
                defaults: new { controller = "Home", action = "Article" }
            );


            routes.MapRoute(
                name: "Default",
                url: "{action}/",
                defaults: new { controller = "Home", action = "MostViewed" }
            );
        }
    }
}