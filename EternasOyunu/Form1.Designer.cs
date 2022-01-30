namespace EternasOyunu
{
    partial class frmEternas
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstListele = new System.Windows.Forms.ListBox();
            this.btnOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListele
            // 
            this.lstListele.FormattingEnabled = true;
            this.lstListele.Location = new System.Drawing.Point(12, 10);
            this.lstListele.Name = "lstListele";
            this.lstListele.Size = new System.Drawing.Size(819, 407);
            this.lstListele.TabIndex = 0;
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOyna.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnOyna.Location = new System.Drawing.Point(287, 423);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(257, 49);
            this.btnOyna.TabIndex = 1;
            this.btnOyna.Text = "HAMLE YAP";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // frmEternas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(843, 501);
            this.Controls.Add(this.btnOyna);
            this.Controls.Add(this.lstListele);
            this.Name = "frmEternas";
            this.Text = "ETERNAS OYUNU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstListele;
        private System.Windows.Forms.Button btnOyna;
    }
}

