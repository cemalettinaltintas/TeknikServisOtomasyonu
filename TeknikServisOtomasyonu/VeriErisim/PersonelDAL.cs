using System;
using System.Data;
using System.Data.SqlClient;
using TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim.Altyapi;

namespace TeknikServisOtomasyonu.VeriErisim
{
    public class PersonelDAL
    {
        public DataTable PersonelleriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Personeller ORDER BY PersonelID DESC");
            return Veritabani.TabloGetir(cmd);
        }

        public int PersonelEkle(Personel p)
        {
            string sql = "INSERT INTO Personeller (AdSoyad, UzmanlikAlani) VALUES (@ad, @uzmanlik)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@ad", p.AdSoyad);
            cmd.Parameters.AddWithValue("@uzmanlik", string.IsNullOrEmpty(p.UzmanlikAlani) ? (object)DBNull.Value : p.UzmanlikAlani);

            return Veritabani.KomutCalistir(cmd);
        }

        public int PersonelGuncelle(Personel p)
        {
            string sql = "UPDATE Personeller SET AdSoyad=@ad, UzmanlikAlani=@uzmanlik WHERE PersonelID=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@ad", p.AdSoyad);
            cmd.Parameters.AddWithValue("@uzmanlik", string.IsNullOrEmpty(p.UzmanlikAlani) ? (object)DBNull.Value : p.UzmanlikAlani);
            cmd.Parameters.AddWithValue("@id", p.PersonelID);

            return Veritabani.KomutCalistir(cmd);
        }
    }
}