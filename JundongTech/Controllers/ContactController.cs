using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JundongTech.Models.Contact;

namespace JundongTech.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string test)
        {
            if (Request.IsAjaxRequest())
            {
                Contact contact = new Contact();
                contact.contact_name = Request["name"];
                contact.contact_email = Request["email"];
                contact.contact_message = Request["message"];
                contact.contact_subject = Request["subject"];
                ContactContext contactContext = new ContactContext();
                contactContext.contactList.Add(contact);
                contactContext.SaveChanges();
                return Content("提交成功");
            }
            else
            {
                return View();
            }
        }
    }
}
