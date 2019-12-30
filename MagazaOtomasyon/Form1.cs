using MagazaOtomasyon.MODEL;
using PersonelApp.BLL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullan = new Kullanici();
            KullaniciBL kbl = new KullaniciBL();
            kullan.KullaniciAdi = this.txtKullaniciAdi.Text.Trim();
            kullan.Sifre = this.txtSifre.Text.Trim();
            kullan = kbl.Giris(kullan);
            switch (kullan.YetkiID)
            {
                case 1:
                    frmIslem frmIslem = new frmIslem();
                    frmIslem.groupBox2.Visible = true;
                    frmIslem.Show();
                    this.Hide();

                    break;
                case 2:
                    new frmIslem().Show();
                    this.Hide();
                    break;
                case 3:
                    new frmIslem().Show();
                    this.Hide();
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                //checkBox işaretli ise
                if (checkBox1.Checked)
                {
                    //karakteri göster.
                    txtSifre.PasswordChar = '\0';
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    txtSifre.PasswordChar = '*';
                }
            }
        }
    }
}
