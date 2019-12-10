using MagazaOtomasyon.DAL;
using MagazaOtomasyon.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyonBL
{
    public class PersonelBL
    {
        private Helper hlp = new Helper();

        public bool Personel_Ekle(Personel personel)
        {
            SqlParameter[] p ={
        new SqlParameter("@KullaniciAdi", (object) personel.KullaniciAdi),
        new SqlParameter("@Sifre", (object) personel.Sifre),
        new SqlParameter("@YetkiID", (object) personel.YetkiID),
        new SqlParameter("@Adı", (object) personel.PersonelAdi),
        new SqlParameter("@Soyadı", (object) personel.PersonelSoyadi),
        new SqlParameter("@TC_Kimlik", (object) personel.PersonelTC),
        new SqlParameter("@Cinsiyet", (object) personel.PersonelCinsiyet)
            };
            return this.hlp.ExecuteNonQuery("Insert into Personel values(@Adı,@Soyadı,@TC_Kimlik,@Cinsiyet,@KullaniciAdi,@Sifre,@YetkiID)", p) > 0;
        }

        public Personel PersonelBul(Personel per)
        {
            SqlParameter[] p = { new SqlParameter("@TC", per.PersonelTC) };
            SqlDataReader sqlDataReader = hlp.ExecuteReader("Select * from Personel where TC_Kimlik=@TC", p);
            if (sqlDataReader.Read())
            {
                per.PersonelAdi = sqlDataReader["Adı"].ToString();
                per.PersonelSoyadi = sqlDataReader["Soyadı"].ToString();
                per.PersonelCinsiyet = sqlDataReader["Cinsiyet"].ToString();
                per.PersonelTC = sqlDataReader["TC_Kimlik"].ToString();
                per.KullaniciAdi = sqlDataReader["KullaniciAdi"].ToString();
                per.Sifre = sqlDataReader["Sifre"].ToString();
                per.YetkiID = Convert.ToInt32(sqlDataReader["YetkiID"]);
                per.PersonelID = Convert.ToInt32(sqlDataReader["ID"]);
            }
            sqlDataReader.Close();
            return per;
        }

        public bool Personel_Guncelle(Personel personel)
        {
            SqlParameter[] p = {
        new SqlParameter("@Adı", (object) personel.PersonelAdi),
        new SqlParameter("@Soyadı", (object) personel.PersonelSoyadi),
        new SqlParameter("@TC_Kimlik", (object) personel.PersonelTC),
        new SqlParameter("@Cinsiyet", (object) personel.PersonelCinsiyet)
            };
            return this.hlp.ExecuteNonQuery("UPDATE into Personel Set Personel_ad=@Adı,Personel_soyad=@Soyadı,personel_tc=@TC_Kimlik,personel_cinsiyet=@Cinsiyet)", p) > 0;
        }

        public bool Personel_Sil(Personel personel)
        {
            SqlParameter[] p ={
        new SqlParameter("@ID", (object) personel.PersonelID)
            };
            return this.hlp.ExecuteNonQuery("Delete from Personel where ID=@ID", p) > 0;
        }

        public void Dispose()
        {
            this.hlp.Dispose();
        }
    }
}
