using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServisOtomasyonu.Varliklar.TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim;

namespace TeknikServisOtomasyonu.IsMantigi
{
    public class MusteriManager
    {
        private MusteriDAL musteriDAL = new MusteriDAL();

        public DataTable MusteriListesi()
        {
            return musteriDAL.MusterileriGetir();
        }
        public bool MusteriKaydet(Musteri m, out string mesaj)
        {
            // İŞ KURALLARI (Validation)
            if (string.IsNullOrWhiteSpace(m.AdSoyad))
            {
                mesaj = "Müşteri ad soyad alanı boş bırakılamaz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.Telefon) || m.Telefon.Length < 10)
            {
                mesaj = "Geçerli bir telefon numarası giriniz (En az 10 hane)!";
                return false;
            }

            // Kurallar sağlandıysa DAL katmanına gönder
            int sonuc = musteriDAL.MusteriEkle(m);

            if (sonuc > 0)
            {
                mesaj = "Müşteri kaydı başarıyla oluşturuldu.";
                return true;
            }
            else
            {
                mesaj = "Müşteri veritabanına eklenirken bir hata oluştu.";
                return false;
            }
        }
        public bool MusteriGuncelle(Musteri m, out string mesaj)
        {
            if (m.MusteriID <= 0)
            {
                mesaj = "Lütfen güncellenecek müşteriyi listeden seçiniz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(m.AdSoyad) || string.IsNullOrWhiteSpace(m.Telefon))
            {
                mesaj = "Ad Soyad ve Telefon alanları boş geçilemez!";
                return false;
            }

            int sonuc = musteriDAL.MusteriGuncelle(m);

            if (sonuc > 0)
            {
                mesaj = "Müşteri bilgileri güncellendi.";
                return true;
            }
            else
            {
                mesaj = "Güncelleme sırasında bir hata oluştu.";
                return false;
            }
        }
    }
}
