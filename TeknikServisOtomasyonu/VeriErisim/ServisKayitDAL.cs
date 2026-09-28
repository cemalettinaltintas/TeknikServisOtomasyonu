using System;
using System.Data;
using System.Data.SqlClient;
using TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim.Altyapi;

namespace TeknikServisOtomasyonu.VeriErisim
{
    public class ServisKayitDAL
    {
        // Personelleri ComboBox doldurmak için çekme
        public DataTable PersonelleriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT PersonelID, AdSoyad FROM Personeller");
            return Veritabani.TabloGetir(cmd);
        }

        // Tüm servis kayıtlarını tüm ilişkili detaylarıyla listeleme (Çoklu INNER JOIN)
        public DataTable ServisKayitlariniGetir()
        {
            string sql = @"SELECT sk.KayitID, m.AdSoyad AS [Musteri], c.MarkaModel AS [Cihaz], 
                                  p.AdSoyad AS [Teknisyen], sk.GelisTarihi, sk.ArizaTanimi, 
                                  sk.YapilanIslem, sk.Ucret, sk.Durum
                           FROM ServisKayitlari sk
                           INNER JOIN Cihazlar c ON sk.CihazID = c.CihazID
                           INNER JOIN Musteriler m ON c.MusteriID = m.MusteriID
                           INNER JOIN Personeller p ON sk.PersonelID = p.PersonelID
                           ORDER BY sk.KayitID DESC";
            SqlCommand cmd = new SqlCommand(sql);
            return Veritabani.TabloGetir(cmd);
        }

        public int ServisKaydiEkle(ServisKayit sk)
        {
            string sql = @"INSERT INTO ServisKayitlari (CihazID, PersonelID, ArizaTanimi, Durum) 
                           VALUES (@cihazId, @personelId, @ariza, @durum)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@cihazId", sk.CihazID);
            cmd.Parameters.AddWithValue("@personelId", sk.PersonelID);
            cmd.Parameters.AddWithValue("@ariza", sk.ArizaTanimi);
            cmd.Parameters.AddWithValue("@durum", "Kayıt Alındı");

            return Veritabani.KomutCalistir(cmd);
        }

        public int ServisDurumGuncelle(int kayitId, string yapilanIslem, decimal ucret, string durum)
        {
            string sql = @"UPDATE ServisKayitlari 
                           SET YapilanIslem=@islem, Ucret=@ucret, Durum=@durum 
                           WHERE KayitID=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@islem", yapilanIslem);
            cmd.Parameters.AddWithValue("@ucret", ucret);
            cmd.Parameters.AddWithValue("@durum", durum);
            cmd.Parameters.AddWithValue("@id", kayitId);

            return Veritabani.KomutCalistir(cmd);
        }
    }
}