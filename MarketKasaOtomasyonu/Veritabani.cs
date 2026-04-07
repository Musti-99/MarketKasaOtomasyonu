using System.Data.SqlClient;

namespace MarketKasaOtomasyonu
{
    public class Veritabani
    {
        private readonly string baglantiMetni = @"Server=.\SQLEXPRESS;Database=MarketDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection BaglantiGetir()
        {
            return new SqlConnection(baglantiMetni);
        }
    }
}
