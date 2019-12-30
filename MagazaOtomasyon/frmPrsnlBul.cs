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
    public partial class frmPrsnlBul : Form
    {
        frmIslem frm = new frmIslem();
        public frmPrsnlBul()
        {
            InitializeComponent();
        }
        public frmPrsnlBul(frmIslem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Personel per = new Personel();
            PersonelBL personelBl = new PersonelBL();
            per.PersonelTC = this.txtTc.Text.Trim();
            Personel personel = personelBl.PersonelBul(per);
            this.frm.personelID = personel.PersonelID;
            this.frm.txtPrsnlAd.Text = personel.PersonelAdi;
            this.frm.txtPrsnlCinsiyet.Text = personel.PersonelCinsiyet;
            this.frm.txtPrsnlSoyad.Text = personel.PersonelSoyadi;
            this.frm.txtPrsnlKullaniciAdi.Text = personel.KullaniciAdi;
            this.frm.txtPrsnlSifre.Text = personel.Sifre;
            this.frm.txtPrsnlTc.Text = personel.PersonelTC;
            this.frm.cmbPrsnlYetki.SelectedValue = (object)personel.YetkiID;
            this.frm.btnPrsnlEkle.Text = "Güncelle";
            this.frm.btnPrsnlSil.Visible = true;
            this.frm.btnPrsnlVazgec.Visible = true;
            if (frm.btnPrsnlSil.Visible = true)
            {
                MessageBox.Show("Personel Bilgileri Getirildi");
            }
        }
    }
}
