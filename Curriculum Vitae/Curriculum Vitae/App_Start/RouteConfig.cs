using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Curriculum_Vitae
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { Controller = "Posts", Action = "homeIndex" });
            routes.MapRoute("AboutMe", "AboutMe", new { Controller = "AboutMe", Action = "AboutMeIndex" });
            routes.MapRoute("Contacts", "Contacts", new { Controller = "Contacts", Action = "ContactsIndex" });
            routes.MapRoute("WE", "WE", new { Controller = "WorkExperience", Action = "WorkIndex" });

        }
    }
}
