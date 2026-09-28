using System.Data;
using TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim;

namespace TeknikServisOtomasyonu.IsMantigi
{
    public class ServisKayitManager
    {
        private ServisKayitDAL servisDAL = new ServisKayitDAL();

        public DataTable PersonelListesi()
        {
            return servisDAL.PersonelleriGetir();
        }

        public DataTable ServisKayitListesi()
        {
            return servisDAL.ServisKayitlariniGetir();
        }

        public bool ServisKaydiAc(ServisKayit sk, out string mesaj)
        {
            // İŞ KURALLARI
            if (sk.CihazID <= 0)
            {
                mesaj = "Lütfen servis kaydı açılacak cihazı seçiniz!";
                return false;
            }

            if (sk.PersonelID <= 0)
            {
                mesaj = "Lütfen cihaza atanacak teknisyeni/personeli seçiniz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sk.ArizaTanimi))
            {
                mesaj = "Arıza tanımı boş bırakılamaz!";
                return false;
            }

            int sonuc = servisDAL.ServisKaydiEkle(sk);

            if (sonuc > 0)
            {
                mesaj = "Arıza kaydı başarıyla açıldı.";
                return true;
            }
            else
            {
                mesaj = "Arıza kaydı açılırken bir hata oluştu.";
                return false;
            }
        }

        public bool ServisDurumGuncelle(int kayitId, string yapilanIslem, decimal ucret, string durum, out string mesaj)
        {
            if (kayitId <= 0)
            {
                mesaj = "Lütfen işlem yapılacak servis kaydını seçiniz!";
                return false;
            }

            if (ucret < 0)
            {
                mesaj = "Servis ücreti negatif bir değer olamaz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(durum))
            {
                mesaj = "Lütfen geçerli bir servis durumu seçiniz!";
                return false;
            }

            int sonuc = servisDAL.ServisDurumGuncelle(kayitId, yapilanIslem, ucret, durum);

            if (sonuc > 0)
            {
                mesaj = "Servis kaydı ve durumu başarıyla güncellendi.";
                return true;
            }
            else
            {
                mesaj = "Servis güncelleme işlemi başarısız oldu.";
                return false;
            }
        }
    }
}