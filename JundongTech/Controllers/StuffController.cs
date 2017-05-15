using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JundongTech.Models.Stuff;
namespace JundongTech.Controllers
{
    public class StuffController : Controller
    {
        //
        // GET: /Stuff/
        StuffContext stuffContext = new StuffContext();

        public ActionResult Index()
        {
            return View(stuffContext.stuffLists.ToList());
        }

    }
}
