using MagazaOtomasyon.BL;
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
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        private void UrunSatis_Load(object sender, EventArgs e)
        {
            PersonelBL pbl = new PersonelBL();
            UrunBL ubl = new UrunBL();
            Personel p = new Personel();
            Urun u = new Urun();
            

            cmbPersonel.DisplayMember = p.ToString();
            cmbPersonel.ValueMember = "PersonelID";

            cmbUrun.DisplayMember = u.ToString();
            cmbUrun.ValueMember = "UrunID";

            cmbPersonel.DataSource = pbl.cmbDataSourcePersonel();
            cmbUrun.DataSource = ubl.cmbDataSourceUrun();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SatisBL sbl = new SatisBL();
            try
            {
                Satis s = new Satis();
                s.UrunId = (int)cmbUrun.SelectedValue;
                s.PersonelId = (int)cmbPersonel.SelectedValue;
                if (sbl.SatisYap(s))
                {
                    MessageBox.Show("Satış başarılı.");
                    cmbPersonel.SelectedItem = null;
                    cmbUrun.SelectedItem = null;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Satış başarısız.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
