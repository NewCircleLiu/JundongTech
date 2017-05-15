using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JundongTech.Models.Product
{
    public class ProductContext:DbContext
    {
        public ProductContext()
            : base("name=Product-Context")
        { }
        public DbSet<Product> productList { get; set; }
    }
}