using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.MODEL
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string PersonelCinsiyet { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string PersonelTC { get; set; }
        public int YetkiID { get; set; }

        public override string ToString()
        {
            return $"{PersonelAdi}, {PersonelSoyadi}";
        }
    }
}
