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
    public class PersonelYetkiBL
    {
        private Helper hlp = new Helper();

        public List<PersonelYetki> YetkiListesi()
        {
            SqlDataReader sqlDataReader = this.hlp.ExecuteReader("Select ID, YetkiAd from PersonelYetki", (SqlParameter[])null);
            List<PersonelYetki> personelYetkiList = new List<PersonelYetki>();
            while (sqlDataReader.Read())
                personelYetkiList.Add(new PersonelYetki()
                {
                    YetkiAd = sqlDataReader["YetkiAd"].ToString(),
                    YetkiID = Convert.ToInt32(sqlDataReader["ID"])
                });
            sqlDataReader.Close();
            personelYetkiList.Insert(0, new PersonelYetki()
            {
                YetkiAd = "Seçiniz"
            });
            return personelYetkiList;
        }
    }
}
