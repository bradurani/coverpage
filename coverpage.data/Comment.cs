//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace coverpage.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_modified { get; set; }
        public string author { get; set; }
        public int article_id { get; set; }
    
        public virtual Article Article { get; set; }
    }
}