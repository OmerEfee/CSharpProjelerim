namespace otomasyondeneme2b
{
    partial class DanismanGirisi
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
            this.sifreunuttum_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cıkıs_button1 = new System.Windows.Forms.Button();
            this.giris_button1 = new System.Windows.Forms.Button();
            this.sifre_textBox1 = new System.Windows.Forms.TextBox();
            this.kulAdi_textBox1 = new System.Windows.Forms.TextBox();
            this.sifre_label = new System.Windows.Forms.Label();
            this.kul_adi_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifreunuttum_linkLabel1
            // 
            this.sifreunuttum_linkLabel1.AutoSize = true;
            this.sifreunuttum_linkLabel1.Location = new System.Drawing.Point(454, 235);
            this.sifreunuttum_linkLabel1.Name = "sifreunuttum_linkLabel1";
            this.sifreunuttum_linkLabel1.Size = new System.Drawing.Size(99, 16);
            this.sifreunuttum_linkLabel1.TabIndex = 13;
            this.sifreunuttum_linkLabel1.TabStop = true;
            this.sifreunuttum_linkLabel1.Text = "Şifremi Unuttum";
            this.sifreunuttum_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifreunuttum_linkLabel1_LinkClicked);
            // 
            // cıkıs_button1
            // 
            this.cıkıs_button1.BackColor = System.Drawing.Color.IndianRed;
            this.cıkıs_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkıs_button1.Location = new System.Drawing.Point(293, 265);
            this.cıkıs_button1.Name = "cıkıs_button1";
            this.cıkıs_button1.Size = new System.Drawing.Size(100, 41);
            this.cıkıs_button1.TabIndex = 12;
            this.cıkıs_button1.Text = "Çıkış Yap";
            this.cıkıs_button1.UseVisualStyleBackColor = false;
            this.cıkıs_button1.Click += new System.EventHandler(this.cıkıs_button1_Click);
            // 
            // giris_button1
            // 
            this.giris_button1.BackColor = System.Drawing.Color.SeaGreen;
            this.giris_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_button1.Location = new System.Drawing.Point(431, 265);
            this.giris_button1.Name = "giris_button1";
            this.giris_button1.Size = new System.Drawing.Size(122, 42);
            this.giris_button1.TabIndex = 11;
            this.giris_button1.Text = "Giriş Yap";
            this.giris_button1.UseVisualStyleBackColor = false;
            this.giris_button1.Click += new System.EventHandler(this.giris_button1_Click);
            // 
            // sifre_textBox1
            // 
            this.sifre_textBox1.Location = new System.Drawing.Point(399, 195);
            this.sifre_textBox1.Name = "sifre_textBox1";
            this.sifre_textBox1.Size = new System.Drawing.Size(154, 22);
            this.sifre_textBox1.TabIndex = 10;
            this.sifre_textBox1.UseSystemPasswordChar = true;
            // 
            // kulAdi_textBox1
            // 
            this.kulAdi_textBox1.Location = new System.Drawing.Point(399, 144);
            this.kulAdi_textBox1.Name = "kulAdi_textBox1";
            this.kulAdi_textBox1.Size = new System.Drawing.Size(154, 22);
            this.kulAdi_textBox1.TabIndex = 9;
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_label.Location = new System.Drawing.Point(306, 193);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(71, 25);
            this.sifre_label.TabIndex = 8;
            this.sifre_label.Text = "Şİfre :";
            // 
            // kul_adi_label
            // 
            this.kul_adi_label.AutoSize = true;
            this.kul_adi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kul_adi_label.Location = new System.Drawing.Point(248, 144);
            this.kul_adi_label.Name = "kul_adi_label";
            this.kul_adi_label.Size = new System.Drawing.Size(145, 25);
            this.kul_adi_label.TabIndex = 7;
            this.kul_adi_label.Text = "Kullanıcı Adı :";
            // 
            // DanismanGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifreunuttum_linkLabel1);
            this.Controls.Add(this.cıkıs_button1);
            this.Controls.Add(this.giris_button1);
            this.Controls.Add(this.sifre_textBox1);
            this.Controls.Add(this.kulAdi_textBox1);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.kul_adi_label);
            this.Name = "DanismanGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanısmanGirisi";
            this.Load += new System.EventHandler(this.DanismanGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel sifreunuttum_linkLabel1;
        private System.Windows.Forms.Button cıkıs_button1;
        private System.Windows.Forms.Button giris_button1;
        private System.Windows.Forms.TextBox sifre_textBox1;
        private System.Windows.Forms.TextBox kulAdi_textBox1;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.Label kul_adi_label;
    }
}