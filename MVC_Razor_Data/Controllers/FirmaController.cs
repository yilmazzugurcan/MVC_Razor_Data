using MVC_Razor_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_Data.Controllers
{
    public class FirmaController : Controller
    {
        // GET: Firma
        public ActionResult FirmaIndex()
        {
            Sube model = new Sube();

            model.PersonelList = DataBase.PerListe;

            return View(model);
        }

        public ActionResult Detay(int id) 
        {
            var person = DataBase.PerListe.Where(p => p.PersonalId == id).FirstOrDefault();

            return View(person);
        }


    }
}