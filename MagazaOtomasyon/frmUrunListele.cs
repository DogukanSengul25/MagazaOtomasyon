using MagazaOtomasyon.BL;
using MagazaOtomasyon.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazaOtomasyon
{
    public partial class frmUrunListele : Form
    {
        DataTable dt;
        public frmUrunListele()
        {
            InitializeComponent();
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunBL ub = new UrunBL();
            dt = ub.UrunlerTablosu();
            dataGridView1.DataSource = dt;
            ub.Dispose();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunBL urun = new UrunBL();

            foreach (DataRow item in dt.Rows)
            {
                Urun u = new Urun();
                if (item.RowState != DataRowState.Deleted)
                {
                    u.Urun_ad = item[1].ToString();
                    u.Urun_kodu = item[2].ToString();
                    u.Stok_mik = Convert.ToInt32(item[3]);
                    u.Fiyat = Convert.ToInt32(item[4]);
                    u.urun_renk= item[5].ToString();
                    u.kategori_id = Convert.ToInt32(item[6]);
                    
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                       urun.Urun_Ekle(u);
                        break;
                    case DataRowState.Deleted:
                        urun.Urun_Sil(u);
                        break;
                    case DataRowState.Modified:
                        u.Urun_kodu = Convert.ToInt32(item[2]);
                        urun.Urun_Guncelle(u);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

