namespace MagazaOtomasyon
{
    partial class frmIslem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUrunFiyat = new CustomControls.MyTextBox();
            this.txtUrunStok = new CustomControls.MyTextBox();
            this.txtUrunRenk = new CustomControls.MyTextBox();
            this.txtUrunNo = new CustomControls.MyTextBox();
            this.txtUrunAd = new CustomControls.MyTextBox();
            this.txtPrsnlKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtPrsnlSifre = new System.Windows.Forms.TextBox();
            this.cmbPrsnlYetki = new System.Windows.Forms.ComboBox();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunBul = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunVazgec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrsnlCinsiyet = new CustomControls.MyTextBox();
            this.txtPrsnlTc = new CustomControls.MyTextBox();
            this.txtPrsnlSoyad = new CustomControls.MyTextBox();
            this.txtPrsnlAd = new CustomControls.MyTextBox();
            this.btnPrsnlEkle = new System.Windows.Forms.Button();
            this.btnPrsnlBul = new System.Windows.Forms.Button();
            this.btnPrsnlSil = new System.Windows.Forms.Button();
            this.btnPrsnlVazgec = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUrunFiyat);
            this.panel1.Controls.Add(this.txtUrunStok);
            this.panel1.Controls.Add(this.txtUrunRenk);
            this.panel1.Controls.Add(this.txtUrunNo);
            this.panel1.Controls.Add(this.txtUrunAd);
            this.panel1.Location = new System.Drawing.Point(106, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 142);
            this.panel1.TabIndex = 0;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtUrunFiyat.Location = new System.Drawing.Point(4, 111);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyat.TabIndex = 14;
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtUrunStok.Location = new System.Drawing.Point(4, 81);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(100, 20);
            this.txtUrunStok.TabIndex = 13;
            // 
            // txtUrunRenk
            // 
            this.txtUrunRenk.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtUrunRenk.Location = new System.Drawing.Point(4, 55);
            this.txtUrunRenk.Name = "txtUrunRenk";
            this.txtUrunRenk.Size = new System.Drawing.Size(100, 20);
            this.txtUrunRenk.TabIndex = 11;
            // 
            // txtUrunNo
            // 
            this.txtUrunNo.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtUrunNo.Location = new System.Drawing.Point(4, 34);
            this.txtUrunNo.Name = "txtUrunNo";
            this.txtUrunNo.Size = new System.Drawing.Size(100, 20);
            this.txtUrunNo.TabIndex = 12;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtUrunAd.Location = new System.Drawing.Point(4, 8);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAd.TabIndex = 11;
            // 
            // txtPrsnlKullaniciAdi
            // 
            this.txtPrsnlKullaniciAdi.Location = new System.Drawing.Point(167, 141);
            this.txtPrsnlKullaniciAdi.Name = "txtPrsnlKullaniciAdi";
            this.txtPrsnlKullaniciAdi.Size = new System.Drawing.Size(121, 20);
            this.txtPrsnlKullaniciAdi.TabIndex = 5;
            // 
            // txtPrsnlSifre
            // 
            this.txtPrsnlSifre.Location = new System.Drawing.Point(167, 168);
            this.txtPrsnlSifre.Name = "txtPrsnlSifre";
            this.txtPrsnlSifre.Size = new System.Drawing.Size(121, 20);
            this.txtPrsnlSifre.TabIndex = 6;
            // 
            // cmbPrsnlYetki
            // 
            this.cmbPrsnlYetki.FormattingEnabled = true;
            this.cmbPrsnlYetki.Location = new System.Drawing.Point(167, 195);
            this.cmbPrsnlYetki.Name = "cmbPrsnlYetki";
            this.cmbPrsnlYetki.Size = new System.Drawing.Size(121, 21);
            this.cmbPrsnlYetki.TabIndex = 7;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(110, 28);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunKategori.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Barkod No ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün Stok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Personel Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = " Personel TC ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Personel Cinsiyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Kullanıcı Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Şifre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Personel Yetki";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(25, 280);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 18;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunBul
            // 
            this.btnUrunBul.Location = new System.Drawing.Point(121, 279);
            this.btnUrunBul.Name = "btnUrunBul";
            this.btnUrunBul.Size = new System.Drawing.Size(75, 23);
            this.btnUrunBul.TabIndex = 19;
            this.btnUrunBul.Text = "Ürün Bul";
            this.btnUrunBul.UseVisualStyleBackColor = true;
            this.btnUrunBul.Click += new System.EventHandler(this.btnUrunBul_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(218, 278);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSil.TabIndex = 20;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Visible = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunVazgec
            // 
            this.btnUrunVazgec.Location = new System.Drawing.Point(310, 278);
            this.btnUrunVazgec.Name = "btnUrunVazgec";
            this.btnUrunVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnUrunVazgec.TabIndex = 21;
            this.btnUrunVazgec.Text = "Vazgeç";
            this.btnUrunVazgec.UseVisualStyleBackColor = true;
            this.btnUrunVazgec.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUrunKategori);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(45, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 213);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrsnlCinsiyet);
            this.groupBox2.Controls.Add(this.txtPrsnlTc);
            this.groupBox2.Controls.Add(this.txtPrsnlSoyad);
            this.groupBox2.Controls.Add(this.txtPrsnlAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPrsnlKullaniciAdi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtPrsnlSifre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbPrsnlYetki);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(503, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 243);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Ekle";
            // 
            // txtPrsnlCinsiyet
            // 
            this.txtPrsnlCinsiyet.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtPrsnlCinsiyet.Location = new System.Drawing.Point(167, 115);
            this.txtPrsnlCinsiyet.Name = "txtPrsnlCinsiyet";
            this.txtPrsnlCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtPrsnlCinsiyet.TabIndex = 21;
            // 
            // txtPrsnlTc
            // 
            this.txtPrsnlTc.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtPrsnlTc.Location = new System.Drawing.Point(167, 88);
            this.txtPrsnlTc.Name = "txtPrsnlTc";
            this.txtPrsnlTc.Size = new System.Drawing.Size(100, 20);
            this.txtPrsnlTc.TabIndex = 20;
            // 
            // txtPrsnlSoyad
            // 
            this.txtPrsnlSoyad.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtPrsnlSoyad.Location = new System.Drawing.Point(167, 62);
            this.txtPrsnlSoyad.Name = "txtPrsnlSoyad";
            this.txtPrsnlSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtPrsnlSoyad.TabIndex = 19;
            // 
            // txtPrsnlAd
            // 
            this.txtPrsnlAd.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtPrsnlAd.Location = new System.Drawing.Point(167, 33);
            this.txtPrsnlAd.Name = "txtPrsnlAd";
            this.txtPrsnlAd.Size = new System.Drawing.Size(100, 20);
            this.txtPrsnlAd.TabIndex = 18;
            // 
            // btnPrsnlEkle
            // 
            this.btnPrsnlEkle.Location = new System.Drawing.Point(514, 279);
            this.btnPrsnlEkle.Name = "btnPrsnlEkle";
            this.btnPrsnlEkle.Size = new System.Drawing.Size(96, 23);
            this.btnPrsnlEkle.TabIndex = 24;
            this.btnPrsnlEkle.Text = "Personel Ekle";
            this.btnPrsnlEkle.UseVisualStyleBackColor = true;
            this.btnPrsnlEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrsnlBul
            // 
            this.btnPrsnlBul.Location = new System.Drawing.Point(613, 278);
            this.btnPrsnlBul.Name = "btnPrsnlBul";
            this.btnPrsnlBul.Size = new System.Drawing.Size(93, 23);
            this.btnPrsnlBul.TabIndex = 25;
            this.btnPrsnlBul.Text = "Personel Bul";
            this.btnPrsnlBul.UseVisualStyleBackColor = true;
            this.btnPrsnlBul.Click += new System.EventHandler(this.btnPrsnlBul_Click);
            // 
            // btnPrsnlSil
            // 
            this.btnPrsnlSil.Location = new System.Drawing.Point(712, 278);
            this.btnPrsnlSil.Name = "btnPrsnlSil";
            this.btnPrsnlSil.Size = new System.Drawing.Size(75, 23);
            this.btnPrsnlSil.TabIndex = 26;
            this.btnPrsnlSil.Text = "Personel Sil";
            this.btnPrsnlSil.UseVisualStyleBackColor = true;
            this.btnPrsnlSil.Visible = false;
            this.btnPrsnlSil.Click += new System.EventHandler(this.btnPrsnlSil_Click);
            // 
            // btnPrsnlVazgec
            // 
            this.btnPrsnlVazgec.Location = new System.Drawing.Point(793, 278);
            this.btnPrsnlVazgec.Name = "btnPrsnlVazgec";
            this.btnPrsnlVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnPrsnlVazgec.TabIndex = 27;
            this.btnPrsnlVazgec.Text = "Vazgeç";
            this.btnPrsnlVazgec.UseVisualStyleBackColor = true;
            this.btnPrsnlVazgec.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(325, 374);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(269, 42);
            this.label14.TabIndex = 28;
            this.label14.Text = "HOŞGELDİNİZ";
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Location = new System.Drawing.Point(154, 317);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(101, 35);
            this.btnUrunListele.TabIndex = 29;
            this.btnUrunListele.Text = "Ürün Listele";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Location = new System.Drawing.Point(670, 317);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(100, 35);
            this.btnPersonelListele.TabIndex = 30;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // frmIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 450);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnUrunListele);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnPrsnlVazgec);
            this.Controls.Add(this.btnPrsnlSil);
            this.Controls.Add(this.btnPrsnlBul);
            this.Controls.Add(this.btnPrsnlEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUrunVazgec);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunBul);
            this.Controls.Add(this.btnUrunEkle);
            this.Name = "frmIslem";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmIslem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunBul;
        public System.Windows.Forms.Button btnUrunSil;
        public System.Windows.Forms.Button btnUrunVazgec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrsnlBul;
        public System.Windows.Forms.Button btnPrsnlSil;
        public System.Windows.Forms.Button btnPrsnlVazgec;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtPrsnlKullaniciAdi;
        public System.Windows.Forms.TextBox txtPrsnlSifre;
        public System.Windows.Forms.ComboBox cmbPrsnlYetki;
        public System.Windows.Forms.ComboBox cmbUrunKategori;
        public System.Windows.Forms.Button btnPrsnlEkle;
        public System.Windows.Forms.Button btnUrunListele;
        public System.Windows.Forms.Button btnPersonelListele;
        public CustomControls.MyTextBox txtUrunAd;
        public CustomControls.MyTextBox txtUrunFiyat;
        public CustomControls.MyTextBox txtUrunStok;
        public CustomControls.MyTextBox txtUrunRenk;
        public CustomControls.MyTextBox txtUrunNo;
        public CustomControls.MyTextBox txtPrsnlCinsiyet;
        public CustomControls.MyTextBox txtPrsnlTc;
        public CustomControls.MyTextBox txtPrsnlSoyad;
        public CustomControls.MyTextBox txtPrsnlAd;
    }
}