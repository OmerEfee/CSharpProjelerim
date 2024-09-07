namespace otomasyondeneme2b
{
    partial class yoneticigiris_Form1
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
            this.kul_adi_label = new System.Windows.Forms.Label();
            this.sifre_label = new System.Windows.Forms.Label();
            this.kulAdi_textBox1 = new System.Windows.Forms.TextBox();
            this.sifre_textBox1 = new System.Windows.Forms.TextBox();
            this.giris_button1 = new System.Windows.Forms.Button();
            this.cıkıs_button1 = new System.Windows.Forms.Button();
            this.sifreunuttum_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // kul_adi_label
            // 
            this.kul_adi_label.AutoSize = true;
            this.kul_adi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kul_adi_label.Location = new System.Drawing.Point(196, 109);
            this.kul_adi_label.Name = "kul_adi_label";
            this.kul_adi_label.Size = new System.Drawing.Size(145, 25);
            this.kul_adi_label.TabIndex = 0;
            this.kul_adi_label.Text = "Kullanıcı Adı :";
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_label.Location = new System.Drawing.Point(254, 158);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(71, 25);
            this.sifre_label.TabIndex = 1;
            this.sifre_label.Text = "Şİfre :";
            // 
            // kulAdi_textBox1
            // 
            this.kulAdi_textBox1.Location = new System.Drawing.Point(347, 109);
            this.kulAdi_textBox1.Name = "kulAdi_textBox1";
            this.kulAdi_textBox1.Size = new System.Drawing.Size(154, 22);
            this.kulAdi_textBox1.TabIndex = 2;
            // 
            // sifre_textBox1
            // 
            this.sifre_textBox1.Location = new System.Drawing.Point(347, 160);
            this.sifre_textBox1.Name = "sifre_textBox1";
            this.sifre_textBox1.Size = new System.Drawing.Size(154, 22);
            this.sifre_textBox1.TabIndex = 3;
            this.sifre_textBox1.UseSystemPasswordChar = true;
            // 
            // giris_button1
            // 
            this.giris_button1.BackColor = System.Drawing.Color.SeaGreen;
            this.giris_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_button1.Location = new System.Drawing.Point(379, 230);
            this.giris_button1.Name = "giris_button1";
            this.giris_button1.Size = new System.Drawing.Size(122, 42);
            this.giris_button1.TabIndex = 4;
            this.giris_button1.Text = "Giriş Yap";
            this.giris_button1.UseVisualStyleBackColor = false;
            this.giris_button1.Click += new System.EventHandler(this.giris_button1_Click);
            // 
            // cıkıs_button1
            // 
            this.cıkıs_button1.BackColor = System.Drawing.Color.IndianRed;
            this.cıkıs_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkıs_button1.Location = new System.Drawing.Point(241, 230);
            this.cıkıs_button1.Name = "cıkıs_button1";
            this.cıkıs_button1.Size = new System.Drawing.Size(100, 41);
            this.cıkıs_button1.TabIndex = 5;
            this.cıkıs_button1.Text = "Çıkış Yap";
            this.cıkıs_button1.UseVisualStyleBackColor = false;
            this.cıkıs_button1.Click += new System.EventHandler(this.cıkıs_button1_Click);
            // 
            // sifreunuttum_linkLabel1
            // 
            this.sifreunuttum_linkLabel1.AutoSize = true;
            this.sifreunuttum_linkLabel1.Location = new System.Drawing.Point(402, 200);
            this.sifreunuttum_linkLabel1.Name = "sifreunuttum_linkLabel1";
            this.sifreunuttum_linkLabel1.Size = new System.Drawing.Size(99, 16);
            this.sifreunuttum_linkLabel1.TabIndex = 6;
            this.sifreunuttum_linkLabel1.TabStop = true;
            this.sifreunuttum_linkLabel1.Text = "Şifremi Unuttum";
            this.sifreunuttum_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sifreunuttum_linkLabel1_LinkClicked);
            // 
            // yoneticigiris_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifreunuttum_linkLabel1);
            this.Controls.Add(this.cıkıs_button1);
            this.Controls.Add(this.giris_button1);
            this.Controls.Add(this.sifre_textBox1);
            this.Controls.Add(this.kulAdi_textBox1);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.kul_adi_label);
            this.Name = "yoneticigiris_Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi";
            this.Load += new System.EventHandler(this.yoneticigiris_Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kul_adi_label;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.TextBox kulAdi_textBox1;
        private System.Windows.Forms.TextBox sifre_textBox1;
        private System.Windows.Forms.Button giris_button1;
        private System.Windows.Forms.Button cıkıs_button1;
        private System.Windows.Forms.LinkLabel sifreunuttum_linkLabel1;
    }
}

