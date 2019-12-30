namespace MagazaOtomasyon
{
    partial class frmPrsnlBul
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
            this.btnBul = new System.Windows.Forms.Button();
            this.txtTc = new CustomControls.MyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(157, 120);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(130, 43);
            this.btnBul.TabIndex = 0;
            this.btnBul.Text = "ARA";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtTc
            // 
            this.txtTc.CalismaModu = CustomControls.WorkMode.Rakam;
            this.txtTc.Location = new System.Drawing.Point(146, 84);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(159, 20);
            this.txtTc.TabIndex = 1;
            this.txtTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc Kimlik Numarası";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPrsnlBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.btnBul);
            this.Name = "frmPrsnlBul";
            this.Text = "frmPrsnlBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private CustomControls.MyTextBox txtTc;
        private System.Windows.Forms.Label label1;
    }
}