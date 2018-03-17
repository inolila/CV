using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curriculum_Vitae.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult ContactsIndex()
        {
            return View();
        }
    }
}