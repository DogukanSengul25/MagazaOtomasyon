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
        List<Urun> urunList = new List<Urun>();
        List<UrunKategori> katList = new List<UrunKategori>();


        public bool Urun_Ekle(Urun urun)
        {

            SqlParameter[] p = {
                new SqlParameter("@Urun_Ad", urun.Urun_ad),
                new SqlParameter("@Urun_Kod", urun.Urun_kodu), 
                new SqlParameter("@Urun_Renk", urun.urun_renk), 
                new SqlParameter("@Urun_Stok", urun.Stok_mik), 
                new SqlParameter("@Urun_Fiyat", urun.Fiyat),
                new SqlParameter("@Urun_KategoriID", urun.kategori_id) 
            };
            return hlp.ExecuteNonQuery("Insert into Urun_Tablosu values(@Urun_Ad,@Urun_Kod,@Urun_Renk,@Urun_Stok,@Urun_Fiyat,@Urun_KategoriID)", p) > 0; /*executenonquery int türünde olduğu için dönülen değerin bool şartı taşıması için 0 dan büyüklüğne bakarız*/
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
        public List<UrunKategori> cmbDataSourceKategori()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select ID, Kat_Ad from Kategori", null);
            while (dr.Read())
            {
                UrunKategori k = new UrunKategori();
                k.KategoriAd = dr["Kat_Ad"].ToString();
                k.KategoriID = Convert.ToInt32(dr["ID"]);
                katList.Add(k);
            }
            dr.Close();
            return katList;
        }

        public List<Urun> cmbDataSourceUrun()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select UrunID, Urun_Ad, Urun_Fiyat, Urun_Stok from Urun_Tablosu", null);
            while (dr.Read())
            {
                Urun u = new Urun();
                u.UrunId = Convert.ToInt32(dr["UrunID"]);
                u.Urun_ad = dr["Urun_Ad"].ToString();
                u.Fiyat = Convert.ToInt32(dr["Urun_Fiyat"]);
                u.Stok_mik = Convert.ToInt32(dr["Urun_Stok"]);
                urunList.Add(u);
            }
            dr.Close();
            return urunList;
        }
        public Urun Urun_Ara(Urun urunKodu)
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


        public DataTable UrunlerTablosu() => hlp.GetDataTable("Select u.*,k.Kat_Ad from Urun_Tablosu u inner join Kategori k on k.ID=u.Urun_KategoriID");
        public void Dispose()
        {
           hlp.Dispose();
        }

    }
}
