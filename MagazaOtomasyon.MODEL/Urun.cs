using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaOtomasyon.MODEL
{
    public class Urun
    {
        string urun_kodu, urun_ad;
        int stok_mik, fiyat;

        public int UrunId { get; set; }
        public string Urun_kodu { get => urun_kodu; set => urun_kodu = value.Trim(); }
        public string Urun_ad { get => urun_ad; set => urun_ad = value.Trim(); }
        public int Stok_mik { get => stok_mik; set => stok_mik = value; }
        public int Fiyat { get => fiyat; set => fiyat = value; }
        public string urun_renk{ get; set; }
        public int kategori_id { get; set; }

        public override string ToString()
        {
            return $"Ürün Ad: {Urun_ad},Fiyat: {Fiyat} , Kalan Stok: {Stok_mik}";
        }
    }
}
