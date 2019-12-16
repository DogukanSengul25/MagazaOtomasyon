using MagazaOtomasyon.BL;
using MagazaOtomasyon.DAL;
using MagazaOtomasyon.MODEL;
using MagazaOtomasyonBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace MagazaOtomasyon
{
    public partial class frmIslem : Form
    {
        public frmIslem()
        {
            InitializeComponent();
        }
        int urun_counter = 0, personel_counter = 0;
        public int personelID = 0;
        public string urunKod = "0";
        private void button1_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            PersonelBL personelBl = new PersonelBL();
            try
            {
                if (personelBl.Personel_Ekle(new Personel()))
                {
                    p.PersonelAdi = txtPrsnlAd.Text.Trim();
                    p.PersonelSoyadi = this.txtPrsnlSoyad.Text.Trim();
                    p.PersonelTC = this.txtPrsnlTc.Text.Trim();
                    p.PersonelCinsiyet = this.txtPrsnlCinsiyet.Text.Trim();
                    p.KullaniciAdi = this.txtPrsnlKullaniciAdi.Text.Trim();
                    p.Sifre = this.txtPrsnlSifre.Text.Trim();
                    p.YetkiID = (int)this.cmbPrsnlYetki.SelectedValue;
                    ++this.personel_counter;
                    MessageBox.Show(this.personel_counter.ToString() + " Yeni Personel Eklendi");
                }

                else
                {
                    MessageBox.Show("Bir Hata Oluştu");
                }
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    default:
                        MessageBox.Show("Veritabanı hatası!" + ex.Number);
                        break;
                }

            }
            finally
            {
                Temizle("groupBox2", "panel2");

            }
        }
        private void btnUrunBul_Click(object sender, EventArgs e)
        {
            frmBul frm = new frmBul();
            frm.Show();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Helper hlp = new Helper();
            UrunBL urunbl = new UrunBL();
            try
            {

                Urun urun = new Urun();
                urun.Urun_kodu = txtUrunNo.Text.Trim();
                urun.Urun_ad = txtUrunAd.Text.Trim();
                urun.Fiyat = int.Parse(txtUrunFiyat.Text);
                urun.Stok_mik = int.Parse(txtUrunStok.Text);
                urun.urun_renk = txtUrunRenk.Text.Trim();

                if (urunbl.Urun_Ekle(urun))
                {
                    urun_counter++;
                    MessageBox.Show(urun_counter + " Yeni Ürün Eklendi");


                }
                else
                {
                    MessageBox.Show("Bir Hata Oluştu");

                }


            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    default:
                        MessageBox.Show("Veritabanı hatası!" + ex.Number);
                        break;
                }

            }
            finally
            {
                Temizle("groupBox1", "panel1");
                urunbl.Dispose();
            }
        }

        private void Temizle(string grpIsim, string pnlIsım)
        {
            foreach (Control control in (ArrangedElementCollection)this.Controls[grpIsim].Controls[pnlIsım].Controls)
                control.Text = string.Empty;
        }

        private void frmIslem_Load(object sender, EventArgs e)
        {
            UrunKategoriBL urunKategoriBl = new UrunKategoriBL();
            this.cmbUrunKategori.ValueMember = "KategoriID";
            this.cmbUrunKategori.DisplayMember = "KategoriAd";
            this.cmbUrunKategori.DataSource = (object)urunKategoriBl.KategoriListesi();
            PersonelYetkiBL personelYetkiBl = new PersonelYetkiBL();
            this.cmbPrsnlYetki.ValueMember = "YetkiID";
            this.cmbPrsnlYetki.DisplayMember = "YetkiAd";
            this.cmbPrsnlYetki.DataSource = (object)personelYetkiBl.YetkiListesi();
        }

        private void btnPrsnlSil_Click(object sender, EventArgs e)
        {
            PersonelBL personelBl = new PersonelBL();
            if (MessageBox.Show("Kullanıcı Silinecek. Devam Etmek İstiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !personelBl.Personel_Sil(new Personel()
            {
                PersonelID = this.personelID
            }))
                return;
            this.personelID = 0;
            this.Temizle("groupBox2", "pnlEkle2");
            this.cmbPrsnlYetki.SelectedIndex = 0;
            this.btnPrsnlEkle.Text = "Ekle";
            this.btnPrsnlSil.Visible = false;
            this.btnPrsnlVazgec.Visible = false;
        }

        private void btnPrsnlBul_Click(object sender, EventArgs e)
        {
            frmPrsnlBul frm = new frmPrsnlBul(this);
            frm.Show();
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            frmUrunListele frm = new frmUrunListele();
            frm.Show();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            frm.Show();

        }

        private void frmIslem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["Form1"].Show();
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            UrunBL ubl = new UrunBL();
            DialogResult cvp = MessageBox.Show("Ürün Silinecek. Devam etmek istiyormusunuz?", "Ürün Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp==DialogResult.Yes)
            {
                Urun u = new Urun();
                u.Urun_kodu = urunKod;
                if (ubl.Urun_Sil(u))
                {
                    this.urunKod = "0";
                    this.Temizle("groupBox1", "pnlUrun");
                    this.cmbUrunKategori.SelectedIndex = 0;
                    this.btnUrunEkle.Text = "Ekle";
                    this.btnUrunSil.Visible = false;
                    this.btnUrunVazgec.Visible = false;
                    MessageBox.Show("Ürün Silindi.");
                }
                else
                {
                    MessageBox.Show("Ürün Silinemedi.");
                }
            }
        }
    }
}
