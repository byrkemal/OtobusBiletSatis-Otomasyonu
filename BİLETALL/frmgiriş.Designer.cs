namespace BİLETALL
{
    partial class frmgiriş
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.btnKAYITOL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGİRİŞ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 25);
            this.panel1.TabIndex = 35;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.Dock = System.Windows.Forms.DockStyle.Right;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(649, 0);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(51, 25);
            this.button23.TabIndex = 0;
            this.button23.Text = "X";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // btnKAYITOL
            // 
            this.btnKAYITOL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKAYITOL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKAYITOL.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnKAYITOL.ForeColor = System.Drawing.Color.White;
            this.btnKAYITOL.Location = new System.Drawing.Point(12, 318);
            this.btnKAYITOL.Name = "btnKAYITOL";
            this.btnKAYITOL.Size = new System.Drawing.Size(197, 45);
            this.btnKAYITOL.TabIndex = 34;
            this.btnKAYITOL.Text = "KAYIT OL";
            this.btnKAYITOL.UseVisualStyleBackColor = false;
            this.btnKAYITOL.Click += new System.EventHandler(this.btnKAYITOL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 52);
            this.label1.TabIndex = 33;
            this.label1.Text = "En Uygun Biletler";
            // 
            // btnGİRİŞ
            // 
            this.btnGİRİŞ.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGİRİŞ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGİRİŞ.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGİRİŞ.ForeColor = System.Drawing.Color.White;
            this.btnGİRİŞ.Location = new System.Drawing.Point(12, 266);
            this.btnGİRİŞ.Name = "btnGİRİŞ";
            this.btnGİRİŞ.Size = new System.Drawing.Size(153, 46);
            this.btnGİRİŞ.TabIndex = 32;
            this.btnGİRİŞ.Text = "GİRİŞ";
            this.btnGİRİŞ.UseVisualStyleBackColor = false;
            this.btnGİRİŞ.Click += new System.EventHandler(this.btnGİRİŞ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vineta BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 41);
            this.label2.TabIndex = 44;
            this.label2.Text = "BiletKolay.com";
            // 
            // frmgiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BİLETALL.Properties.Resources.bilet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnKAYITOL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGİRİŞ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmgiriş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmgiriş_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button btnKAYITOL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGİRİŞ;
        private System.Windows.Forms.Label label2;
    }
}

