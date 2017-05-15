using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JundongTech.Models.Home;
namespace JundongTech.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private HomeViewModel homeViewModel = new HomeViewModel();
        public ActionResult Index()
        {
            return View(homeViewModel);
        }

    }
}
