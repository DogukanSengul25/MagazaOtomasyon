using MagazaOtomasyon.DAL;
using MagazaOtomasyon.MODEL;
using System;
using System.Data.SqlClient;

namespace PersonelApp.BLL
{
    public class KullaniciBL : IDisposable
    {
        private Helper hlp;

        public void Dispose()
        {
            this.hlp.Dispose();
        }

        public Kullanici Giris(Kullanici k)
        {
            this.hlp = new Helper();
            SqlDataReader sqlDataReader = this.hlp.ExecuteReader("Select YetkiID from Personel where KullaniciAdi=@KullaniciAd and Sifre=@Sifre", new SqlParameter[2]
            {
        new SqlParameter("@KullaniciAd", (object) k.KullaniciAdi),
        new SqlParameter("@Sifre", (object) k.Sifre)
            });
            if (sqlDataReader.Read())
                k.YetkiID = Convert.ToInt32(sqlDataReader["YetkiID"]);
            return k;
        }
    }
}
