using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Razor_Data.Models
{
    public static class DataBase
    {
        private static List<Personel> _liste;

        static DataBase()
        {
            _liste = new List<Personel>()
            {
                new Personel() {PersonalId=1, Ad = "Ali", Soyad = "KESKİN", K_Tarihi = new DateTime(1970, 3, 15), EmeklilikDrumu = null, IsActive = true, Resim = "1.jpg"},
                new Personel() {PersonalId=2, Ad = "Veli", Soyad = "KEKLİK", K_Tarihi = new DateTime(1960, 3, 15), EmeklilikDrumu = null, IsActive = false,Resim = "2.jpg"},
                new Personel() {PersonalId=3, Ad = "Alp", Soyad = "KENE", K_Tarihi = new DateTime(1980, 3, 15), EmeklilikDrumu = null, IsActive = false,Resim = "3.jpg"},
                new Personel() {PersonalId=4, Ad = "Akın", Soyad = "KEVSER", K_Tarihi = new DateTime(1985, 3, 15), EmeklilikDrumu = null, IsActive = true,Resim = "4.jpg"},
                new Personel() {PersonalId=5, Ad = "Ayaz", Soyad = "KEDİ", K_Tarihi = new DateTime(1999, 3, 15), EmeklilikDrumu = null, IsActive = true,Resim = "5.jpg"},
                new Personel() {PersonalId=6, Ad = "Ayçin", Soyad = "KEVGİR", K_Tarihi = new DateTime(1995, 3, 15), EmeklilikDrumu = null, IsActive = true,Resim = "6.jpg"},
                new Personel() {PersonalId=7, Ad = "Aykut", Soyad = "KENT", K_Tarihi = new DateTime(2000, 3, 15), EmeklilikDrumu = null, IsActive = true,Resim = "7.jpg"},
                new Personel() {PersonalId=8, Ad = "Aras", Soyad = "KELEK", K_Tarihi = new DateTime(2005, 3, 15), EmeklilikDrumu = null, IsActive = false,Resim = "8.jpg"}
            };
        }

        public static List<Personel> PerListe
        {
            get { return _liste; }
        }
        public static void PerEkle(Personel entity)
        {
            _liste.Add(entity);
        }
    }
}