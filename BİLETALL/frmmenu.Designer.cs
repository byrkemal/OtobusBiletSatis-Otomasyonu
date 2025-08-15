namespace BİLETALL
{
    partial class frmmenu
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
            this.btnBİLETLERİM = new System.Windows.Forms.Button();
            this.btnBİLETAL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBİLETLERİM
            // 
            this.btnBİLETLERİM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBİLETLERİM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBİLETLERİM.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBİLETLERİM.ForeColor = System.Drawing.Color.White;
            this.btnBİLETLERİM.Location = new System.Drawing.Point(31, 273);
            this.btnBİLETLERİM.Name = "btnBİLETLERİM";
            this.btnBİLETLERİM.Size = new System.Drawing.Size(206, 46);
            this.btnBİLETLERİM.TabIndex = 53;
            this.btnBİLETLERİM.Text = "BİLETLERİM";
            this.btnBİLETLERİM.UseVisualStyleBackColor = false;
            this.btnBİLETLERİM.Click += new System.EventHandler(this.btnBİLETLERİM_Click);
            // 
            // btnBİLETAL
            // 
            this.btnBİLETAL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBİLETAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBİLETAL.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBİLETAL.ForeColor = System.Drawing.Color.White;
            this.btnBİLETAL.Location = new System.Drawing.Point(31, 206);
            this.btnBİLETAL.Name = "btnBİLETAL";
            this.btnBİLETAL.Size = new System.Drawing.Size(206, 46);
            this.btnBİLETAL.TabIndex = 52;
            this.btnBİLETAL.Text = "BİLET AL";
            this.btnBİLETAL.UseVisualStyleBackColor = false;
            this.btnBİLETAL.Click += new System.EventHandler(this.btnBİLETAL_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 25);
            this.panel1.TabIndex = 51;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Vineta BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(386, 41);
            this.label7.TabIndex = 66;
            this.label7.Text = "BiletKolay.com";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BİLETALL.Properties.Resources.bilet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 573);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBİLETLERİM);
            this.Controls.Add(this.btnBİLETAL);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBİLETLERİM;
        private System.Windows.Forms.Button btnBİLETAL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label7;
    }
}