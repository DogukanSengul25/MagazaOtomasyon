using MagazaOtomasyon.MODEL;
using MagazaOtomasyonBL;
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
    public partial class frmPersonelListele : Form
    {
        DataTable dt;
        public frmPersonelListele()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            PersonelBL prs = new PersonelBL();
            dt = prs.PersonelTablosu();
            dataGridView1.DataSource = dt;
            prs.Dispose();
            PersonelYetkiBL prsy = new PersonelYetkiBL();
            cmbYetki.DisplayMember = "YetkiAd";
            cmbYetki.ValueMember = "ID";
            cmbYetki.DataSource = prsy.YetkiListesi();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           PersonelBL prsnl = new PersonelBL();
            foreach (DataRow item in dt.Rows)
            {
                Personel p = new Personel();
                if (item.RowState != DataRowState.Deleted)
                {
                    p.PersonelAdi = item[1].ToString();
                    p.PersonelSoyadi = item[2].ToString();
                    p.PersonelCinsiyet = item[4].ToString(); ;
                    p.PersonelTC = item[3].ToString();
                    p.KullaniciAdi=item[5].ToString();
                    p.Sifre = item[6].ToString();
                    p.YetkiID = (Convert.ToInt32(item[7]));
                }
                switch (item.RowState)
                {
                    case DataRowState.Added:
                        prsnl.Personel_Ekle(p);
                        break;
                    case DataRowState.Deleted:
                        prsnl.Personel_Sil(Convert.ToInt32(item["PersonelID", DataRowVersion.Original]));
                        break;
                    case DataRowState.Modified:
                        p.PersonelID = Convert.ToInt32(item[0]);
                        prsnl.Personel_Guncelle(p);
                        break;
                    default:
                        break;
                }



            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message=="DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (!((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                  ((DataGridViewComboBoxColumn)dataGridView1.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }
    }
}
