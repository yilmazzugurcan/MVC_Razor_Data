using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_Data.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string[] renkler = { "sarı", "kırmızı", "mavi", "kırmızı", "mavi", "siyah", "mor", "beyaz" };
            int[] rakamlar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            string[] markalar = { "Audi", "Volvo", "BMV", "KIA" };

            ViewBag.rakam = rakamlar;
            ViewBag.markalar = markalar;
 
            return View(renkler);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}