namespace MagazaOtomasyon
{
    partial class frmBul
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
            this.btnUrunBul = new System.Windows.Forms.Button();
            this.txtUrunBul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUrunBul
            // 
            this.btnUrunBul.Location = new System.Drawing.Point(138, 80);
            this.btnUrunBul.Name = "btnUrunBul";
            this.btnUrunBul.Size = new System.Drawing.Size(111, 42);
            this.btnUrunBul.TabIndex = 0;
            this.btnUrunBul.Text = "Ürün Bul";
            this.btnUrunBul.UseVisualStyleBackColor = true;
            this.btnUrunBul.Click += new System.EventHandler(this.btnUrunBul_Click);
            // 
            // txtUrunBul
            // 
            this.txtUrunBul.Location = new System.Drawing.Point(124, 54);
            this.txtUrunBul.Name = "txtUrunBul";
            this.txtUrunBul.Size = new System.Drawing.Size(125, 20);
            this.txtUrunBul.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod No :";
            // 
            // frmBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrunBul);
            this.Controls.Add(this.btnUrunBul);
            this.Name = "frmBul";
            this.Text = "frmUrunBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrunBul;
        private System.Windows.Forms.TextBox txtUrunBul;
        private System.Windows.Forms.Label label1;
    }
}