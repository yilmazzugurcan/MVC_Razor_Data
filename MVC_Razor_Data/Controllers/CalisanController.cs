using MVC_Razor_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor_Data.Controllers
{
    public class CalisanController : Controller
    {
        // GET: Calisan
        public PartialViewResult Index()
        {
            List<Personel> personeller = new List<Personel>()
            {
                new Personel() {PersonalId=1, Ad = "Ali", Soyad = "KESKİN", K_Tarihi = new DateTime(1970, 3, 15), EmeklilikDrumu =null},                                    
                new Personel() {PersonalId=2, Ad = "veli", Soyad = "KEKLİK",K_Tarihi = new DateTime(1960, 3, 15), EmeklilikDrumu =null},
                new Personel() {PersonalId=3, Ad = "Alp", Soyad = "KENE",    K_Tarihi = new DateTime(1980, 3, 15), EmeklilikDrumu =null},                                     
                new Personel() {PersonalId=4, Ad = "Akın", Soyad = "KEVSER", K_Tarihi = new DateTime(1985, 3, 15), EmeklilikDrumu =null},                                     
                new Personel() {PersonalId=5, Ad = "Ayaz", Soyad = "KEDİ",   K_Tarihi = new DateTime(1999, 3, 15), EmeklilikDrumu =null},
                new Personel() {PersonalId=6, Ad = "Ayçin", Soyad = "KEVGİR", K_Tarihi = new DateTime(1995, 3, 15), EmeklilikDrumu =null},                                      
                new Personel() {PersonalId=7, Ad = "Aykut", Soyad = "KENT",   K_Tarihi = new DateTime(2000, 3, 15), EmeklilikDrumu =null},                                      
                new Personel() {PersonalId=8, Ad = "Aras", Soyad = "KELEK",   K_Tarihi = new DateTime(2005, 3, 15), EmeklilikDrumu =null}

            };

            return PartialView("CalisanView", personeller);
        }
    }
}