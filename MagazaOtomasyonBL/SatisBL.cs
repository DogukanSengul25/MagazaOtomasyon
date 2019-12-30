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
    public class SatisBL : IDisposable
    {
        Helper hlp = new Helper();

        public bool SatisYap(Satis s)
        {
            SqlParameter[] p = { new SqlParameter("@PersonelId", s.PersonelId), new SqlParameter("@UrunId", s.UrunId) };
            int stok = 0;
            hlp.ExecuteNonQuery("Insert into Satislar values (@PersonelId, @UrunId)", p);

            SqlParameter[] p1 = { new SqlParameter("@Id", s.UrunId) };
            SqlDataReader dr = hlp.ExecuteReader("Select Urun_Stok from Urun_Tablosu where UrunID = @Id", p1);
            if (dr.Read())
            {
                stok = Convert.ToInt32(dr["Urun_Stok"]);
                stok--;
            }
            dr.Close();

            SqlParameter[] p2 = { new SqlParameter("@Stok", stok),new SqlParameter("@Urunid",s.UrunId) };
            hlp.ExecuteNonQuery("Update Urun_Tablosu set Urun_Stok = @Stok where UrunID=@Urunid", p2);
            return true;
        }

        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
