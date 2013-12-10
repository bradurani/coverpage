using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace coverpage.Models
{
    public class CommentSectionModel
    {
        public List<CommentModel> Comments { get; set; }
        public CommentFormModel CommentForm { get; set; }
    }
}