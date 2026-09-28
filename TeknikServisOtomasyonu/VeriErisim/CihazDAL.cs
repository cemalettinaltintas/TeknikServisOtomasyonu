using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeknikServisOtomasyonu.Varliklar;
using TeknikServisOtomasyonu.VeriErisim.Altyapi;

namespace TeknikServisOtomasyonu.VeriErisim
{
    public class CihazDAL
    {
        // ComboBox doldurmak için Cihaz Türlerini çekme
        public DataTable CihazTurleriniGetir()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CihazTurleri");
            return Veritabani.TabloGetir(cmd);
        }

        // Cihazları Müşteri Adı ve Cihaz Türü adıyla birlikte listeleme (INNER JOIN)
        public DataTable CihazlariGetir()
        {
            string sql = @"SELECT c.CihazID, m.AdSoyad AS [MusteriAd], ct.TurAdi, c.MarkaModel, c.SeriNo 
                           FROM Cihazlar c
                           INNER JOIN Musteriler m ON c.MusteriID = m.MusteriID
                           INNER JOIN CihazTurleri ct ON c.TurID = ct.TurID
                           ORDER BY c.CihazID DESC";
            SqlCommand cmd = new SqlCommand(sql);
            return Veritabani.TabloGetir(cmd);
        }

        public int CihazEkle(Cihaz c)
        {
            string sql = "INSERT INTO Cihazlar (MusteriID, TurID, MarkaModel, SeriNo) VALUES (@musteriId, @turId, @marka, @seri)";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@musteriId", c.MusteriID);
            cmd.Parameters.AddWithValue("@turId", c.TurID);
            cmd.Parameters.AddWithValue("@marka", c.MarkaModel);
            cmd.Parameters.AddWithValue("@seri", string.IsNullOrEmpty(c.SeriNo) ? (object)System.DBNull.Value : c.SeriNo);

            return Veritabani.KomutCalistir(cmd);
        }
    }
}
