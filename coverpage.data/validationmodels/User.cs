using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coverpage.data
{
    [MetadataType(typeof(UserMetaData))]
    public partial class User
    {
    }

    public class UserMetaData
    {
        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        public string phone { get; set; }
    }

}