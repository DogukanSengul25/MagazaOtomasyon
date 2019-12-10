using MagazaOtomasyon.BL;
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
        public frmUrunListele()
        {
            InitializeComponent();
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunBL ub = new UrunBL();
            dataGridView1.DataSource = ub.OgrenciTablosu();
        }
    }
}
