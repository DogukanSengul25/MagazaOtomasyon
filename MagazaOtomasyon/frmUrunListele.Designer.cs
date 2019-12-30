namespace MagazaOtomasyon
{
    partial class frmUrunListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunListele));
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRenk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKategori = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAd,
            this.clmBarkod,
            this.clmStok,
            this.clmFiyat,
            this.clmRenk,
            this.clmKategori});
            this.dataGridUrunler.Location = new System.Drawing.Point(74, 58);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.Size = new System.Drawing.Size(639, 287);
            this.dataGridUrunler.TabIndex = 0;
            this.dataGridUrunler.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridUrunler_DataError);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(334, 351);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 54);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmAd
            // 
            this.clmAd.DataPropertyName = "Urun_Ad";
            this.clmAd.HeaderText = "Ad";
            this.clmAd.Name = "clmAd";
            // 
            // clmBarkod
            // 
            this.clmBarkod.DataPropertyName = "Urun_Kod";
            this.clmBarkod.HeaderText = "Barkod";
            this.clmBarkod.Name = "clmBarkod";
            // 
            // clmStok
            // 
            this.clmStok.DataPropertyName = "Urun_Stok";
            this.clmStok.HeaderText = "Stok";
            this.clmStok.Name = "clmStok";
            // 
            // clmFiyat
            // 
            this.clmFiyat.DataPropertyName = "Urun_Fiyat";
            this.clmFiyat.HeaderText = "Fiyat";
            this.clmFiyat.Name = "clmFiyat";
            // 
            // clmRenk
            // 
            this.clmRenk.DataPropertyName = "Urun_Renk";
            this.clmRenk.HeaderText = "Renk";
            this.clmRenk.Name = "clmRenk";
            // 
            // clmKategori
            // 
            this.clmKategori.DataPropertyName = "Kat_Ad";
            this.clmKategori.HeaderText = "Kategori";
            this.clmKategori.Name = "clmKategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(330, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜN TABLOSU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridUrunler);
            this.Name = "frmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUrunListele";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRenk;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}