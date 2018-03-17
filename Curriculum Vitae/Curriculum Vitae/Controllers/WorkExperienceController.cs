using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curriculum_Vitae.Controllers
{
    public class WorkExperienceController : Controller
    {
        // GET: RelatedWorkExperience
        public ActionResult WorkIndex()
        {
            return View();
        }
    }
}