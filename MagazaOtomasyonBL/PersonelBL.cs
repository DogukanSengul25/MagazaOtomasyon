using MagazaOtomasyon.DAL;
using MagazaOtomasyon.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyonBL
{
    public class PersonelBL
    {
        private Helper hlp = new Helper();
        DataTable dt;
        List<Personel> personelList = new List<Personel>();

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

        public List<Personel> cmbDataSourcePersonel()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select PersonelID, Adı, Soyadı from Personel", null);
            while (dr.Read())
            {
                Personel p = new Personel();
                p.PersonelID = Convert.ToInt32(dr["PersonelID"]);
                p.PersonelAdi = dr["Adı"].ToString();
                p.PersonelSoyadi = dr["Soyadı"].ToString();
                personelList.Add(p);

            }
            dr.Close();
            return personelList;
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
                per.PersonelID = Convert.ToInt32(sqlDataReader["PersonelID"]);
            }
            sqlDataReader.Close();
            return per;
        }


        public bool Personel_Guncelle(Personel personel)
        {
            SqlParameter[] p = {
        new SqlParameter("@Adı", personel.PersonelAdi),
        new SqlParameter("@Soyadı", personel.PersonelSoyadi),
        new SqlParameter("@TC_Kimlik", personel.PersonelTC),
        new SqlParameter("@Cinsiyet", personel.PersonelCinsiyet),
        new SqlParameter("@KullaniciAdi", personel.KullaniciAdi),
        new SqlParameter("@Sifre", personel.Sifre),
        new SqlParameter("@PersonelID", personel.PersonelID),
        new SqlParameter("@YetkiID", personel.YetkiID)
            };
            return this.hlp.ExecuteNonQuery("UPDATE Personel Set Adı=@Adı,Soyadı=@Soyadı,TC_Kimlik=@TC_Kimlik,Cinsiyet=@Cinsiyet,KullaniciAdi=@KullaniciAdi,Sifre=@Sifre,YetkiID=@YetkiID where PersonelID=@PersonelID", p) > 0;
        }

        public bool Personel_Sil(int id)
        {
            SqlParameter[] p ={
        new SqlParameter("@PersonelID", id)
            };
            return this.hlp.ExecuteNonQuery("Delete from Personel where PersonelID=@PersonelID", p) > 0;
        }
        public DataTable PersonelTablosu() => hlp.GetDataTable("Select * from Personel");
        public void Dispose()
        {
            this.hlp.Dispose();
        }
    }
}
