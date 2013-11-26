using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coverpage.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        public string ArticleText { get; set; }
        public string Headline { get; set; }
    }
}