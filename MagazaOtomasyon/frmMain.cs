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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ürünEklemeSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIslem urunekle = new frmIslem();
            urunekle.Show();
        }

        private void ürünBulmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBul urunbul = new frmBul();
            urunbul.Show();
        }

        private void personelEklemeSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIslem urunekle = new frmIslem();
            urunekle.Show();
        }

        private void personelBulmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrsnlBul personelbul = new frmPrsnlBul();
            personelbul.Show();
        }

        private void girişYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
