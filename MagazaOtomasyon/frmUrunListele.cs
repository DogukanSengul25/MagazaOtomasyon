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
            dataGridUrunler.AutoGenerateColumns = false;
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunBL ub = new UrunBL();
            dt = ub.UrunlerTablosu();
            dataGridUrunler.DataSource = dt;
            ub.Dispose();
            
            clmKategori.DisplayMember = "Kat_Ad";
            clmKategori.ValueMember = "ID";
            clmKategori.DataSource = ub.cmbDataSourceKategori();

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
                    u.Stok_mik = (Convert.ToInt32(item[3]));
                    u.Fiyat = (Convert.ToInt32(item[4]));
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
                        u.Urun_kodu = item["Urun_Kod"].ToString();
                        urun.Urun_Guncelle(u);
                        break;
                    default:
                        break;
                }
            }
        }

        private void dataGridUrunler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridUrunler.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (!((DataGridViewComboBoxColumn)dataGridUrunler.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridUrunler.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }
    }
}

