namespace otomasyondeneme2b
{
    partial class YeniSifreOlusturma
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
            this.kuladii_textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ysifreonay_textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreonayla_button1 = new System.Windows.Forms.Button();
            this.yenisifre_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kuladii_textBox3
            // 
            this.kuladii_textBox3.Location = new System.Drawing.Point(406, 131);
            this.kuladii_textBox3.Name = "kuladii_textBox3";
            this.kuladii_textBox3.Size = new System.Drawing.Size(140, 22);
            this.kuladii_textBox3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(260, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // ysifreonay_textBox2
            // 
            this.ysifreonay_textBox2.Location = new System.Drawing.Point(406, 221);
            this.ysifreonay_textBox2.Name = "ysifreonay_textBox2";
            this.ysifreonay_textBox2.Size = new System.Drawing.Size(140, 22);
            this.ysifreonay_textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(207, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şifrenizi Onaylayın";
            // 
            // sifreonayla_button1
            // 
            this.sifreonayla_button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sifreonayla_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreonayla_button1.Location = new System.Drawing.Point(402, 276);
            this.sifreonayla_button1.Name = "sifreonayla_button1";
            this.sifreonayla_button1.Size = new System.Drawing.Size(192, 43);
            this.sifreonayla_button1.TabIndex = 16;
            this.sifreonayla_button1.Text = "Şifreyi Onayla";
            this.sifreonayla_button1.UseVisualStyleBackColor = false;
            this.sifreonayla_button1.Click += new System.EventHandler(this.sifreonayla_button1_Click);
            // 
            // yenisifre_textBox1
            // 
            this.yenisifre_textBox1.Location = new System.Drawing.Point(406, 175);
            this.yenisifre_textBox1.Name = "yenisifre_textBox1";
            this.yenisifre_textBox1.Size = new System.Drawing.Size(140, 22);
            this.yenisifre_textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Yeni Şifreniz";
            // 
            // YeniSifreOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kuladii_textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ysifreonay_textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreonayla_button1);
            this.Controls.Add(this.yenisifre_textBox1);
            this.Controls.Add(this.label1);
            this.Name = "YeniSifreOlusturma";
            this.Text = "YeniSifreOlusturma";
            this.Load += new System.EventHandler(this.YeniSifreOlusturma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kuladii_textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ysifreonay_textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sifreonayla_button1;
        private System.Windows.Forms.TextBox yenisifre_textBox1;
        private System.Windows.Forms.Label label1;
    }
}