using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JundongTech.Models.Partner
{
    public class Partner
    {
        [Key]
        public int partner_id { get; set; }
        public string partner_name { get; set; }
        public string partner_website { get; set; }
        public string partner_logo { get; set; }
        public string partner_description { get; set; }
    }
}