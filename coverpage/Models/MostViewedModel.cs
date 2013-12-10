using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coverpage.Models
{
    public class MostViewedModel
    {
        public string Language { get; set; }
        public List<ArticleModel> Articles { get; set; }
        public bool LoggedIn { get; set; }
        public string Name { get; set; }
    }
}