namespace MagazaOtomasyon
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEklemeSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünBulmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelIslem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEklemeSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBulmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunIslem,
            this.personelIslem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunIslem
            // 
            this.urunIslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEklemeSilmeToolStripMenuItem,
            this.ürünBulmaToolStripMenuItem});
            this.urunIslem.Name = "urunIslem";
            this.urunIslem.Size = new System.Drawing.Size(92, 20);
            this.urunIslem.Text = "Ürün İşlemleri";
            // 
            // ürünEklemeSilmeToolStripMenuItem
            // 
            this.ürünEklemeSilmeToolStripMenuItem.Name = "ürünEklemeSilmeToolStripMenuItem";
            this.ürünEklemeSilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünEklemeSilmeToolStripMenuItem.Text = "Ürün Ekleme,Silme";
            this.ürünEklemeSilmeToolStripMenuItem.Click += new System.EventHandler(this.ürünEklemeSilmeToolStripMenuItem_Click);
            // 
            // ürünBulmaToolStripMenuItem
            // 
            this.ürünBulmaToolStripMenuItem.Name = "ürünBulmaToolStripMenuItem";
            this.ürünBulmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünBulmaToolStripMenuItem.Text = "Ürün Bulma";
            this.ürünBulmaToolStripMenuItem.Click += new System.EventHandler(this.ürünBulmaToolStripMenuItem_Click);
            // 
            // personelIslem
            // 
            this.personelIslem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEklemeSilmeToolStripMenuItem,
            this.personelBulmaToolStripMenuItem});
            this.personelIslem.Name = "personelIslem";
            this.personelIslem.Size = new System.Drawing.Size(111, 20);
            this.personelIslem.Text = "Personel İşlemleri";
            // 
            // personelEklemeSilmeToolStripMenuItem
            // 
            this.personelEklemeSilmeToolStripMenuItem.Name = "personelEklemeSilmeToolStripMenuItem";
            this.personelEklemeSilmeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.personelEklemeSilmeToolStripMenuItem.Text = "Personel Ekleme,Silme";
            this.personelEklemeSilmeToolStripMenuItem.Click += new System.EventHandler(this.personelEklemeSilmeToolStripMenuItem_Click);
            // 
            // personelBulmaToolStripMenuItem
            // 
            this.personelBulmaToolStripMenuItem.Name = "personelBulmaToolStripMenuItem";
            this.personelBulmaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.personelBulmaToolStripMenuItem.Text = "Personel Bulma";
            this.personelBulmaToolStripMenuItem.Click += new System.EventHandler(this.personelBulmaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ürünEklemeSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünBulmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEklemeSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelBulmaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem urunIslem;
        public System.Windows.Forms.ToolStripMenuItem personelIslem;
        public System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}