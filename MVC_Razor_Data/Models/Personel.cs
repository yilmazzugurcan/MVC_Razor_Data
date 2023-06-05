using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Razor_Data.Models
{
    public class Personel
    {
        public int PersonalId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime K_Tarihi { get; set; }
        public double Maas { get; set; }
        public string EmeklilikDrumu { get; set; }
        public bool? IsActive { get; set; }
        public string Resim { get; set; }

    }
}