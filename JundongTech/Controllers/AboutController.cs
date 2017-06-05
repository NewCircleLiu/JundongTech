using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JundongTech.Models.Service;

namespace JundongTech.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/
        ServiceContext serviceContext = new ServiceContext();
        public ActionResult Index()
        {
            return View(serviceContext.serviceLists.ToList());
        }

    }
}
