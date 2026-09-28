using System;
using System.Data;
using TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim;

namespace TeknikServisOtomasyonu.IsMantigi
{
    public class PersonelManager
    {
        private PersonelDAL personelDAL = new PersonelDAL();

        public DataTable PersonelListesi()
        {
            return personelDAL.PersonelleriGetir();
        }

        public bool PersonelKaydet(Personel p, out string mesaj)
        {
            // İŞ KURALLARI (Validation)
            if (string.IsNullOrWhiteSpace(p.AdSoyad))
            {
                mesaj = "Personel ad soyad alanı boş bırakılamaz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(p.UzmanlikAlani))
            {
                mesaj = "Uzmanlık alanı boş bırakılamaz!";
                return false;
            }

            // Kurallar sağlandıysa DAL katmanına gönder
            int sonuc = personelDAL.PersonelEkle(p);

            if (sonuc > 0)
            {
                mesaj = "Personel kaydı başarıyla oluşturuldu.";
                return true;
            }
            else
            {
                mesaj = "Personel veritabanına eklenirken bir hata oluştu.";
                return false;
            }
        }

        public bool PersonelGuncelle(Personel p, out string mesaj)
        {
            if (p.PersonelID <= 0)
            {
                mesaj = "Lütfen güncellenecek personeli listeden seçiniz!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(p.AdSoyad) || string.IsNullOrWhiteSpace(p.UzmanlikAlani))
            {
                mesaj = "Ad Soyad ve Uzmanlık Alanı boş geçilemez!";
                return false;
            }

            int sonuc = personelDAL.PersonelGuncelle(p);

            if (sonuc > 0)
            {
                mesaj = "Personel bilgileri güncellendi.";
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