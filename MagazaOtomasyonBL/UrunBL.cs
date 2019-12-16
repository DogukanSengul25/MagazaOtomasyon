using MagazaOtomasyon.DAL;
using MagazaOtomasyon.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.BL
{
    public class UrunBL:IDisposable
    {
        Helper hlp = new Helper();


        public bool Urun_Ekle(Urun urun)
        {

            SqlParameter[] p = { new SqlParameter("@Urun_Renk", urun.urun_renk), new SqlParameter("@Urun_Kod", urun.Urun_kodu), new SqlParameter("@Urun_Ad", urun.Urun_ad), new SqlParameter("@Urun_Stok", urun.Stok_mik), new SqlParameter("@Urun_Fiyat", urun.Fiyat), new SqlParameter("@Urun_KategoriID", urun.kategori_id) };
            return hlp.ExecuteNonQuery("Insert into Urun_Tablosu values(@Urun_Renk,@Urun_Kod,@Urun_Ad,@Urun_Stok,@Urun_Fiyat,@Urun_KategoriID)", p) > 0; /*executenonquery int türünde olduğu için dönülen değerin bool şartı taşıması için 0 dan büyüklüğne bakarız*/
        }
        public bool Urun_Guncelle(Urun urun)
        {

            SqlParameter[] p = { new SqlParameter("@Urun_Renk", urun.urun_renk), new SqlParameter("@Urun_Kod", urun.Urun_kodu), new SqlParameter("@Urun_Ad", urun.Urun_ad), new SqlParameter("@Urun_Stok", urun.Stok_mik), new SqlParameter("@Urun_Fiyat", urun.Fiyat) };
            return hlp.ExecuteNonQuery("UPDATE Urun_Tablosu SET urun_renk=@Urun_Renk,Urun_kodu=@Urun_Kod,Urun_ad=@Urun_Ad,Stok_mik=@Urun_Stok,Fiyat=@Urun_Fiyat WHERE Urun_kodu=@Urun_Kod", p) > 0;
        }
        public bool Urun_Sil(Urun urun)
        {
            SqlParameter[] p = { new SqlParameter("@Urun_Kod", urun.Urun_kodu) };
            return hlp.ExecuteNonQuery("Delete from Urun_Tablosu where Urun_kodu=@Urun_Kod", p) > 0;

        }
        public Urun Urun_Ara(string urunKodu)
        {
            Urun urun = null;
            SqlParameter[] p = { new SqlParameter("@Urun_Kod", urunKodu) };
            SqlDataReader dr = hlp.ExecuteReader("Select Urun_Kod,Urun_Ad,Urun_Renk,Urun_Stok,Urun_Fiyat,Urun_KategoriID from Urun_Tablosu where urun_kodu=@Urun_Kod", p);

            if (dr.Read())
            {
                urun = new Urun();
                urun.Urun_kodu = dr["Urun_Kod"].ToString();
                urun.Urun_ad = dr["Urun_Ad"].ToString();
                urun.urun_renk = dr["Urun_Renk"].ToString();
                urun.Stok_mik = Convert.ToInt32(dr["Urun_Stok"]);
                urun.Fiyat = Convert.ToInt32(dr["Urun_Fiyat"]);
                urun.kategori_id = Convert.ToInt32(dr["Urun_KategoriID"]);

            }
            dr.Close();
            return urun;

        }
        public DataTable UrunlerTablosu => hlp.GetDataTable("Select * from Urunler");
        public void Dispose()
        {
           hlp.Dispose();
        }

    }
}
