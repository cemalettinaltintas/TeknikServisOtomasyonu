using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServisOtomasyonu.VeriErisim.Altyapi
{
    public static class Veritabani
    {
        // SQL Server bağlantı cümlesi (Sunucu adınıza göre düzenleyebilirsiniz)
        private static string connectionString = @"Server=.\SQLEXPRESS;Database=TeknikServisDB;Trusted_Connection=True;";
        public static SqlConnection BaglantiAl()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        // INSERT, UPDATE, DELETE işlemleri için (Etkilenen satır sayısını döner)
        public static int KomutCalistir(SqlCommand cmd)
        {
            using (SqlConnection conn = BaglantiAl())
            {
                cmd.Connection = conn;
                return cmd.ExecuteNonQuery();
            }
        }

        // SELECT işlemleri için (DataTable döner)
        public static DataTable TabloGetir(SqlCommand cmd)
        {
            using (SqlConnection conn = BaglantiAl())
            {
                cmd.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
