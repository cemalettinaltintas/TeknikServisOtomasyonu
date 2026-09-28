using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServisOtomasyonu.Varliklar.TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim.Altyapi;

namespace TeknikServisOtomasyonu.VeriErisim
{
    public class MusteriDAL
    {
        public DataTable MusterileriGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Musteriler ORDER BY MusteriID DESC");
            return Veritabani.TabloGetir(cmd);
        }
        public int MusteriEkle(Musteri m)
        {
            string sql = "INSERT INTO Musteriler (AdSoyad, Telefon, Eposta) VALUES (@ad, @tel, @mail)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@ad", m.AdSoyad);
            cmd.Parameters.AddWithValue("@tel", m.Telefon);
            cmd.Parameters.AddWithValue("@mail", string.IsNullOrEmpty(m.Eposta) ? (object)DBNull.Value : m.Eposta);

            return Veritabani.KomutCalistir(cmd);
        }

        public int MusteriGuncelle(Musteri m)
        {
            string sql = "UPDATE Musteriler SET AdSoyad=@ad, Telefon=@tel, Eposta=@mail WHERE MusteriID=@id";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@ad", m.AdSoyad);
            cmd.Parameters.AddWithValue("@tel", m.Telefon);
            cmd.Parameters.AddWithValue("@mail", string.IsNullOrEmpty(m.Eposta) ? (object)DBNull.Value : m.Eposta);
            cmd.Parameters.AddWithValue("@id", m.MusteriID);

            return Veritabani.KomutCalistir(cmd);
        }
    }
}
