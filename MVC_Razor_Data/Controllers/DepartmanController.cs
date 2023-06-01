using MVC_Razor_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_Data.Controllers
{
    public class DepartmanController : Controller
    {
        // GET: Departman
        public ActionResult Index()
        {
            

            return View();
        }
        public PartialViewResult Departmans()
        {
            List<Departman> departmanlar = new List<Departman>()
            {
                new Departman() {DepartmanId=1, DepartanAdi = "Finans"},
                new Departman() {DepartmanId=2, DepartanAdi = "Muhasebe"},
                new Departman() {DepartmanId=3, DepartanAdi = "Pazarlama"},
                new Departman() {DepartmanId=4, DepartanAdi = "Bakım Onarım"},
                new Departman() {DepartmanId=5, DepartanAdi = "İnsan Kaynakları"}
            };

            return PartialView("DepartmanView", departmanlar);
        }
    }
}