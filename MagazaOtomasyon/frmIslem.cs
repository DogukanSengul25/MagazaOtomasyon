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
                p.PersonelAdi = txtPrsnlAd.Text.Trim();
                p.PersonelSoyadi = this.txtPrsnlSoyad.Text.Trim();
                p.PersonelTC = this.txtPrsnlTc.Text.Trim();
                p.PersonelCinsiyet = this.txtPrsnlCinsiyet.Text.Trim();
                p.KullaniciAdi = this.txtPrsnlKullaniciAdi.Text.Trim();
                p.Sifre = this.txtPrsnlSifre.Text.Trim();
                p.YetkiID = (int)this.cmbPrsnlYetki.SelectedValue;
                p.PersonelID = personelID;
                ++this.personel_counter;
                if (personelID == 0)
                {
                    personelBl.Personel_Ekle(p);
                    MessageBox.Show(this.personel_counter.ToString() + " Yeni Personel Eklendi");
                }

                else
                {
                    personelBl.Personel_Guncelle(p);
                    MessageBox.Show("Personel Güncellendi");
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
            Urun urun = new Urun();
            UrunBL urunbl = new UrunBL();

            try
            {
                urun.kategori_id =(int) cmbUrunKategori.SelectedValue;
                urun.Urun_ad = txtUrunAd.Text.Trim();
                urun.Urun_kodu = txtUrunNo.Text.Trim();
                urun.urun_renk = txtUrunRenk.Text.Trim();
                urun.Stok_mik = int.Parse(txtUrunStok.Text);
                urun.Fiyat = int.Parse(txtUrunFiyat.Text);
                
               

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
            foreach (Control control in panel2.Controls)
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
            //if (MessageBox.Show("Kullanıcı Silinecek. Devam Etmek İstiyor musunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || !personelBl.Personel_Sil(new Personel()
            //{
            //    PersonelID = this.personelID
            //}))
            DialogResult cvp = MessageBox.Show("Emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cvp == DialogResult.No) return;
            if (personelBl.Personel_Sil(personelID))
            {
                MessageBox.Show("Silme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız.");
            }
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

        private void btnUrunSatis_Click_1(object sender, EventArgs e)
        {
            UrunSatis f = new UrunSatis();
            f.Show();
        }
        
        private void textclear(Control ctl)//TEXTBOX TEMİZLEME METODU
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item.Controls.Count > 0)
                {
                    textclear(item);
                }
            }
        }

        private void btnPrsnlVazgec_Click(object sender, EventArgs e)
        {
            textclear(this);
        }

        private void btnUrunVazgec_Click(object sender, EventArgs e)
        {
            textclear(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SatisBilgileri stl = new SatisBilgileri();
            stl.Show();
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
