using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisOtomasyonu.Varliklar
{
    public class Cihaz
    {
        public int CihazID { get; set; }
        public int MusteriID { get; set; }
        public int TurID { get; set; }
        public string MarkaModel { get; set; }
        public string SeriNo { get; set; }
    }
}
