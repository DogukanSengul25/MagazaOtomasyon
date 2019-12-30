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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIslem));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrsnlCinsiyet = new CustomControls.MyTextBox();
            this.txtPrsnlAd = new CustomControls.MyTextBox();
            this.txtPrsnlTc = new CustomControls.MyTextBox();
            this.txtPrsnlSoyad = new CustomControls.MyTextBox();
            this.btnPrsnlEkle = new System.Windows.Forms.Button();
            this.btnPrsnlBul = new System.Windows.Forms.Button();
            this.btnPrsnlSil = new System.Windows.Forms.Button();
            this.btnPrsnlVazgec = new System.Windows.Forms.Button();
            this.btnUrunListele = new System.Windows.Forms.Button();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.btnUrunSatis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUrunFiyat);
            this.panel1.Controls.Add(this.txtUrunStok);
            this.panel1.Controls.Add(this.txtUrunRenk);
            this.panel1.Controls.Add(this.txtUrunNo);
            this.panel1.Controls.Add(this.txtUrunAd);
            this.panel1.Location = new System.Drawing.Point(118, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 142);
            this.panel1.TabIndex = 0;
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtUrunFiyat.Location = new System.Drawing.Point(4, 111);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.Size = new System.Drawing.Size(121, 26);
            this.txtUrunFiyat.TabIndex = 14;
            // 
            // txtUrunStok
            // 
            this.txtUrunStok.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtUrunStok.Location = new System.Drawing.Point(4, 85);
            this.txtUrunStok.Name = "txtUrunStok";
            this.txtUrunStok.Size = new System.Drawing.Size(121, 26);
            this.txtUrunStok.TabIndex = 13;
            // 
            // txtUrunRenk
            // 
            this.txtUrunRenk.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtUrunRenk.Location = new System.Drawing.Point(4, 60);
            this.txtUrunRenk.Name = "txtUrunRenk";
            this.txtUrunRenk.Size = new System.Drawing.Size(121, 26);
            this.txtUrunRenk.TabIndex = 11;
            // 
            // txtUrunNo
            // 
            this.txtUrunNo.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtUrunNo.Location = new System.Drawing.Point(4, 34);
            this.txtUrunNo.Name = "txtUrunNo";
            this.txtUrunNo.Size = new System.Drawing.Size(121, 26);
            this.txtUrunNo.TabIndex = 12;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtUrunAd.Location = new System.Drawing.Point(4, 8);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(121, 26);
            this.txtUrunAd.TabIndex = 11;
            // 
            // txtPrsnlKullaniciAdi
            // 
            this.txtPrsnlKullaniciAdi.Location = new System.Drawing.Point(26, 118);
            this.txtPrsnlKullaniciAdi.Name = "txtPrsnlKullaniciAdi";
            this.txtPrsnlKullaniciAdi.Size = new System.Drawing.Size(121, 26);
            this.txtPrsnlKullaniciAdi.TabIndex = 5;
            // 
            // txtPrsnlSifre
            // 
            this.txtPrsnlSifre.Location = new System.Drawing.Point(26, 145);
            this.txtPrsnlSifre.Name = "txtPrsnlSifre";
            this.txtPrsnlSifre.Size = new System.Drawing.Size(121, 26);
            this.txtPrsnlSifre.TabIndex = 6;
            // 
            // cmbPrsnlYetki
            // 
            this.cmbPrsnlYetki.FormattingEnabled = true;
            this.cmbPrsnlYetki.Location = new System.Drawing.Point(26, 172);
            this.cmbPrsnlYetki.Name = "cmbPrsnlYetki";
            this.cmbPrsnlYetki.Size = new System.Drawing.Size(121, 28);
            this.cmbPrsnlYetki.TabIndex = 7;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(122, 60);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(121, 28);
            this.cmbUrunKategori.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Barkod No ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürün Renk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ürün Stok";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(34, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ürün Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(68, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(42, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Personel Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(59, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = " Personel TC ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(32, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Personel Cinsiyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(68, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Kullanıcı Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(121, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Şifre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(52, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Personel Yetki";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Location = new System.Drawing.Point(154, 387);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(116, 34);
            this.btnUrunEkle.TabIndex = 18;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunBul
            // 
            this.btnUrunBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunBul.Location = new System.Drawing.Point(287, 388);
            this.btnUrunBul.Name = "btnUrunBul";
            this.btnUrunBul.Size = new System.Drawing.Size(116, 33);
            this.btnUrunBul.TabIndex = 19;
            this.btnUrunBul.Text = "Ürün Bul";
            this.btnUrunBul.UseVisualStyleBackColor = true;
            this.btnUrunBul.Click += new System.EventHandler(this.btnUrunBul_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.Location = new System.Drawing.Point(154, 427);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(116, 33);
            this.btnUrunSil.TabIndex = 20;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Visible = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunVazgec
            // 
            this.btnUrunVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunVazgec.Location = new System.Drawing.Point(287, 427);
            this.btnUrunVazgec.Name = "btnUrunVazgec";
            this.btnUrunVazgec.Size = new System.Drawing.Size(116, 33);
            this.btnUrunVazgec.TabIndex = 21;
            this.btnUrunVazgec.Text = "Vazgeç";
            this.btnUrunVazgec.UseVisualStyleBackColor = true;
            this.btnUrunVazgec.Visible = false;
            this.btnUrunVazgec.Click += new System.EventHandler(this.btnUrunVazgec_Click);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(113, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 244);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(570, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 243);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Ekle";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPrsnlCinsiyet);
            this.panel2.Controls.Add(this.txtPrsnlAd);
            this.panel2.Controls.Add(this.txtPrsnlTc);
            this.panel2.Controls.Add(this.cmbPrsnlYetki);
            this.panel2.Controls.Add(this.txtPrsnlSoyad);
            this.panel2.Controls.Add(this.txtPrsnlSifre);
            this.panel2.Controls.Add(this.txtPrsnlKullaniciAdi);
            this.panel2.Location = new System.Drawing.Point(167, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 211);
            this.panel2.TabIndex = 31;
            // 
            // txtPrsnlCinsiyet
            // 
            this.txtPrsnlCinsiyet.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtPrsnlCinsiyet.Location = new System.Drawing.Point(26, 92);
            this.txtPrsnlCinsiyet.Name = "txtPrsnlCinsiyet";
            this.txtPrsnlCinsiyet.Size = new System.Drawing.Size(121, 26);
            this.txtPrsnlCinsiyet.TabIndex = 21;
            // 
            // txtPrsnlAd
            // 
            this.txtPrsnlAd.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtPrsnlAd.Location = new System.Drawing.Point(26, 10);
            this.txtPrsnlAd.Name = "txtPrsnlAd";
            this.txtPrsnlAd.Size = new System.Drawing.Size(121, 26);
            this.txtPrsnlAd.TabIndex = 18;
            // 
            // txtPrsnlTc
            // 
            this.txtPrsnlTc.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtPrsnlTc.Location = new System.Drawing.Point(26, 65);
            this.txtPrsnlTc.Name = "txtPrsnlTc";
            this.txtPrsnlTc.Size = new System.Drawing.Size(121, 26);
            this.txtPrsnlTc.TabIndex = 20;
            // 
            // txtPrsnlSoyad
            // 
            this.txtPrsnlSoyad.CalismaModu = CustomControls.WorkMode.Harf;
            this.txtPrsnlSoyad.Location = new System.Drawing.Point(26, 39);
            this.txtPrsnlSoyad.Name = "txtPrsnlSoyad";
            this.txtPrsnlSoyad.Size = new System.Drawing.Size(121, 26);
            this.txtPrsnlSoyad.TabIndex = 19;
            // 
            // btnPrsnlEkle
            // 
            this.btnPrsnlEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrsnlEkle.Location = new System.Drawing.Point(625, 387);
            this.btnPrsnlEkle.Name = "btnPrsnlEkle";
            this.btnPrsnlEkle.Size = new System.Drawing.Size(116, 34);
            this.btnPrsnlEkle.TabIndex = 24;
            this.btnPrsnlEkle.Text = "Personel Ekle";
            this.btnPrsnlEkle.UseVisualStyleBackColor = true;
            this.btnPrsnlEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrsnlBul
            // 
            this.btnPrsnlBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrsnlBul.Location = new System.Drawing.Point(768, 388);
            this.btnPrsnlBul.Name = "btnPrsnlBul";
            this.btnPrsnlBul.Size = new System.Drawing.Size(116, 35);
            this.btnPrsnlBul.TabIndex = 25;
            this.btnPrsnlBul.Text = "Personel Bul";
            this.btnPrsnlBul.UseVisualStyleBackColor = true;
            this.btnPrsnlBul.Click += new System.EventHandler(this.btnPrsnlBul_Click);
            // 
            // btnPrsnlSil
            // 
            this.btnPrsnlSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrsnlSil.Location = new System.Drawing.Point(625, 425);
            this.btnPrsnlSil.Name = "btnPrsnlSil";
            this.btnPrsnlSil.Size = new System.Drawing.Size(116, 35);
            this.btnPrsnlSil.TabIndex = 26;
            this.btnPrsnlSil.Text = "Personel Sil";
            this.btnPrsnlSil.UseVisualStyleBackColor = true;
            this.btnPrsnlSil.Visible = false;
            this.btnPrsnlSil.Click += new System.EventHandler(this.btnPrsnlSil_Click);
            // 
            // btnPrsnlVazgec
            // 
            this.btnPrsnlVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrsnlVazgec.Location = new System.Drawing.Point(768, 425);
            this.btnPrsnlVazgec.Name = "btnPrsnlVazgec";
            this.btnPrsnlVazgec.Size = new System.Drawing.Size(116, 35);
            this.btnPrsnlVazgec.TabIndex = 27;
            this.btnPrsnlVazgec.Text = "Vazgeç";
            this.btnPrsnlVazgec.UseVisualStyleBackColor = true;
            this.btnPrsnlVazgec.Visible = false;
            this.btnPrsnlVazgec.Click += new System.EventHandler(this.btnPrsnlVazgec_Click);
            // 
            // btnUrunListele
            // 
            this.btnUrunListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunListele.Location = new System.Drawing.Point(231, 466);
            this.btnUrunListele.Name = "btnUrunListele";
            this.btnUrunListele.Size = new System.Drawing.Size(101, 35);
            this.btnUrunListele.TabIndex = 29;
            this.btnUrunListele.Text = "Ürün Listele";
            this.btnUrunListele.UseVisualStyleBackColor = true;
            this.btnUrunListele.Click += new System.EventHandler(this.btnUrunListele_Click);
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelListele.Location = new System.Drawing.Point(694, 468);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(147, 35);
            this.btnPersonelListele.TabIndex = 30;
            this.btnPersonelListele.Text = "Personel Listele";
            this.btnPersonelListele.UseVisualStyleBackColor = true;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // btnUrunSatis
            // 
            this.btnUrunSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSatis.Location = new System.Drawing.Point(408, 473);
            this.btnUrunSatis.Name = "btnUrunSatis";
            this.btnUrunSatis.Size = new System.Drawing.Size(210, 83);
            this.btnUrunSatis.TabIndex = 31;
            this.btnUrunSatis.Text = "Ürün Satış";
            this.btnUrunSatis.UseVisualStyleBackColor = true;
            this.btnUrunSatis.Click += new System.EventHandler(this.btnUrunSatis_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(349, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 133);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(485, 411);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(725, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(231, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 92);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(408, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 81);
            this.button1.TabIndex = 36;
            this.button1.Text = "Satış Bilgileri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUrunSatis);
            this.Controls.Add(this.btnPersonelListele);
            this.Controls.Add(this.btnUrunListele);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmIslem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnUrunBul;
        public System.Windows.Forms.Button btnUrunSil;
        public System.Windows.Forms.Button btnUrunVazgec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrsnlBul;
        public System.Windows.Forms.Button btnPrsnlSil;
        public System.Windows.Forms.Button btnPrsnlVazgec;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUrunSatis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Button btnUrunEkle;
        public System.Windows.Forms.Button button1;
    }
}