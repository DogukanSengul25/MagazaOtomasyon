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
    public class UrunKategoriBL : IDisposable
    {
        private Helper hlp = new Helper();

        public void Dispose()
        {
            this.hlp.Dispose();
        }

        public List<UrunKategori> KategoriListesi()
        {
            SqlDataReader sqlDataReader = this.hlp.ExecuteReader("Select ID, Kat_Ad from Kategori", (SqlParameter[])null);
            List<UrunKategori> urunKategoriList = new List<UrunKategori>();
            while (sqlDataReader.Read())
                urunKategoriList.Add(new UrunKategori()
                {
                    KategoriAd = sqlDataReader["Kat_Ad"].ToString(),
                    KategoriID = Convert.ToInt32(sqlDataReader["ID"])
                });
            sqlDataReader.Close();
            urunKategoriList.Insert(0, new UrunKategori()
            {
                KategoriAd = "Seçiniz"
            });
            return urunKategoriList;
        }
    }
}
