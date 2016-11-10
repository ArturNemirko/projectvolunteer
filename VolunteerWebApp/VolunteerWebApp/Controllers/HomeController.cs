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
        private Context db = new Context();
        public ActionResult Index()
        {
            var list = db.Ads.ToList();
            return View(db.Ads.ToList());
        }

        public ActionResult AddAds()
        {
            return View();
        }

        public ActionResult AddAdsToDB(string helpType, string description, string address, string organizer, string comments)
        {
            db.Ads.Add(new Ads() {Id = Guid.NewGuid(), IsOpen = true, TimeOfStart = DateTime.Now, Coments = comments });
            db.SaveChangesAsync();
            return View("AddAds");
        }

        public ActionResult FindAds(string nameAds)
        {
            Func<Ads, bool> selector = ads => true;
            if (!string.IsNullOrWhiteSpace(nameAds))
            {
                selector = (x) => x.Coments.ToUpper() == nameAds.ToUpper();
            }
            if (Request.IsAjaxRequest())
            {
                return PartialView("ListAdsView", db.Ads.ToList());
            }
            else
            {
                return View("Index", db.Ads.ToList());
            }
        }
    }
}
