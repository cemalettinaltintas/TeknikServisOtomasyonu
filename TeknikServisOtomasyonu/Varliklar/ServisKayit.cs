using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisOtomasyonu.Varliklar
{
    public class ServisKayit
    {
        public int KayitID { get; set; }
        public int CihazID { get; set; }
        public int PersonelID { get; set; }
        public DateTime GelisTarihi { get; set; }
        public string ArizaTanimi { get; set; }
        public string YapilanIslem { get; set; }
        public decimal Ucret { get; set; }
        public string Durum { get; set; }
    }
}
