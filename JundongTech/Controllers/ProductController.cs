using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JundongTech.Models.Product;

namespace JundongTech.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /product/
        ProductContext productContext = new ProductContext();


        public ActionResult Index()
        {
            return View(productContext.productList.ToList());
        }

    }
}
