using MVC_Razor_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public ActionResult PersonelEkle() {
            return View();
        }

        [HttpPost]
        public ActionResult PersonelEkle (string Ad,string Soyad,double Maas,string EmeklilikDurumu,bool IsActive,string Resim)
        {
            Personel entity=new Personel();

            entity.Ad= Ad;
            entity.Soyad= Soyad;
            entity.Maas= Maas;
            entity.EmeklilikDrumu= EmeklilikDurumu;
            entity.IsActive = IsActive;
            entity.K_Tarihi = DateTime.Now;
            entity.Resim = Resim;

            DataBase.PerEkle(entity);

            return View("PersonelList",DataBase.PerListe);
        }
        public ActionResult PersonelList()
        {
            Sube model = new Sube();

            model.PersonelList = DataBase.PerListe;

            return View(model);
        }


    }
}