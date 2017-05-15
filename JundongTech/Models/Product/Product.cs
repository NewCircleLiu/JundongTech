using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace JundongTech.Models.Product
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_path { get; set; }
        public string product_image { get; set; }
        public string product_description { get; set; }
    }
}