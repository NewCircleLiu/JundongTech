using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace JundongTech.Models.Service
{
    public class Service
    {
        [Key]
        public int service_id { get; set; }
        public string service_name { get; set; }
        public string service_description { get; set; }
        public int service_price { get; set; }
    }
}