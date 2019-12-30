using MagazaOtomasyon.BL;
using MagazaOtomasyon.DAL;
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
    public partial class frmBul : Form
    {
        frmIslem frm = new frmIslem();
        public frmBul()
        {
            InitializeComponent();
           
        }
        public frmBul(frmIslem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            Helper hlp = new Helper();
            Urun u = new Urun();
            UrunBL urunBl = new UrunBL();
            
            u.Urun_kodu = this.txtUrunBul.Text.Trim();
            if (u == null)
            {
                MessageBox.Show("Müşteri Bulunamadı!");
            }
            Urun urun1 = urunBl.Urun_Ara(u);
            this.frm.txtUrunAd.Text = urun1.Urun_ad;
            this.frm.txtUrunNo.Text=urun1.Urun_kodu;
            this.frm.txtUrunRenk.Text = urun1.urun_renk;
            this.frm.txtUrunStok.Text = Convert.ToString(urun1.Stok_mik);
            this.frm.txtUrunFiyat.Text = Convert.ToString(urun1.Fiyat);
            this.frm.cmbUrunKategori.SelectedValue = (object)urun1.kategori_id;
            this.frm.btnUrunEkle.Text = "Güncelle";
            this.frm.btnUrunSil.Visible = false;
            this.frm.btnUrunVazgec.Visible = true;
            if (frm.btnUrunSil.Visible=true)
            {
                MessageBox.Show("ÜRÜN BİLGİLERİ GETİRİLDİ.");
            }


        }
    }
}
