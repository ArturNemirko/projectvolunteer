using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dbVolunteer;

namespace VolunteerWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //Context context = new Context();
            //context.Ads.Add(new Ads() {IsOpen = true});
            return View();
        }
    }
}
