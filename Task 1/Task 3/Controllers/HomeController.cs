using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            string str = Task_3.Models.Connect.getJSON("https://jsonplaceholder.typicode.com/albums", "");
            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Task_3.Models.Album>>(str);
            return View(list);
        }
    }
}
