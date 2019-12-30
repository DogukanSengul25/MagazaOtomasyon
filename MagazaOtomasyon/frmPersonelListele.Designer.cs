namespace MagazaOtomasyon
{
    partial class frmPersonelListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmdAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcKimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbKullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbYetki = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmdAd,
            this.cmbSoyad,
            this.cmbCinsiyet,
            this.TcKimlik,
            this.cmbKullaniciAdi,
            this.cmbSifre,
            this.cmbYetki});
            this.dataGridView1.Location = new System.Drawing.Point(29, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 264);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(350, 304);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(129, 55);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmdAd
            // 
            this.cmdAd.DataPropertyName = "Adı";
            this.cmdAd.HeaderText = "Adı";
            this.cmdAd.Name = "cmdAd";
            // 
            // cmbSoyad
            // 
            this.cmbSoyad.DataPropertyName = "Soyadı";
            this.cmbSoyad.HeaderText = "Soyadı";
            this.cmbSoyad.Name = "cmbSoyad";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DataPropertyName = "Cinsiyet";
            this.cmbCinsiyet.HeaderText = "Cinsiyeti";
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            // 
            // TcKimlik
            // 
            this.TcKimlik.DataPropertyName = "Tc_Kimlik";
            this.TcKimlik.HeaderText = "Tc Kimlik";
            this.TcKimlik.Name = "TcKimlik";
            // 
            // cmbKullaniciAdi
            // 
            this.cmbKullaniciAdi.DataPropertyName = "KullaniciAdi";
            this.cmbKullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.cmbKullaniciAdi.Name = "cmbKullaniciAdi";
            // 
            // cmbSifre
            // 
            this.cmbSifre.DataPropertyName = "Sifre";
            this.cmbSifre.HeaderText = "Şifre";
            this.cmbSifre.Name = "cmbSifre";
            // 
            // cmbYetki
            // 
            this.cmbYetki.DataPropertyName = "YetkiID";
            this.cmbYetki.HeaderText = "Yetki";
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbYetki.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(318, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "PERSONEL TABLOSU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersonelListele";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmdAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcKimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbKullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbSifre;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbYetki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}