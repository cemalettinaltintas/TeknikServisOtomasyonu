using System.Data;
using TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim;

namespace TeknikServisOtomasyonu.IsMantigi
{
    public class CihazManager
    {
        private CihazDAL cihazDAL = new CihazDAL();

        public DataTable CihazTurListesi()
        {
            return cihazDAL.CihazTurleriniGetir();
        }

        public DataTable CihazListesi()
        {
            return cihazDAL.CihazlariGetir();
        }

        public bool CihazKaydet(Cihaz c, out string mesaj)
        {
            // İŞ KURALLARI
            if (c.MusteriID <= 0)
            {
                mesaj = "Lütfen cihazın ait olduğu müşteriyi seçiniz!";
                return false;
            }

            if (c.TurID <= 0)
            {
                mesaj = "Lütfen cihaz türünü seçiniz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(c.MarkaModel))
            {
                mesaj = "Cihaz marka ve model bilgisi boş bırakılamaz!";
                return false;
            }

            int sonuc = cihazDAL.CihazEkle(c);

            if (sonuc > 0)
            {
                mesaj = "Cihaz kaydı başarıyla eklendi.";
                return true;
            }
            else
            {
                mesaj = "Cihaz kaydedilirken veritabanı hatası oluştu.";
                return false;
            }
        }
    }
}