namespace otomasyondeneme2b
{
    partial class DanismanSifreSıfırlamakicinOnaylama
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
            this.sifresifirla_button1 = new System.Windows.Forms.Button();
            this.tcson4hane_textBox2 = new System.Windows.Forms.TextBox();
            this.kuladi_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifresifirla_button1
            // 
            this.sifresifirla_button1.BackColor = System.Drawing.Color.Khaki;
            this.sifresifirla_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifresifirla_button1.Location = new System.Drawing.Point(436, 256);
            this.sifresifirla_button1.Name = "sifresifirla_button1";
            this.sifresifirla_button1.Size = new System.Drawing.Size(152, 45);
            this.sifresifirla_button1.TabIndex = 19;
            this.sifresifirla_button1.Text = "Şifremi Sıfırla";
            this.sifresifirla_button1.UseVisualStyleBackColor = false;
            this.sifresifirla_button1.Click += new System.EventHandler(this.sifresifirla_button1_Click);
            // 
            // tcson4hane_textBox2
            // 
            this.tcson4hane_textBox2.Location = new System.Drawing.Point(416, 201);
            this.tcson4hane_textBox2.Name = "tcson4hane_textBox2";
            this.tcson4hane_textBox2.Size = new System.Drawing.Size(172, 22);
            this.tcson4hane_textBox2.TabIndex = 18;
            // 
            // kuladi_textBox1
            // 
            this.kuladi_textBox1.Location = new System.Drawing.Point(416, 150);
            this.kuladi_textBox1.Name = "kuladi_textBox1";
            this.kuladi_textBox1.Size = new System.Drawing.Size(172, 22);
            this.kuladi_textBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(212, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "TC NO Son 4 Hane";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(241, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "KULLANICI ADI";
            // 
            // DanismanSifreSıfırlamakicinOnaylama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.sifresifirla_button1);
            this.Controls.Add(this.tcson4hane_textBox2);
            this.Controls.Add(this.kuladi_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanismanSifreSıfırlamakicinOnaylama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanismanSifreSıfırlamakicinOnaylama";
            this.Load += new System.EventHandler(this.DanismanSifreSıfırlamakicinOnaylama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sifresifirla_button1;
        private System.Windows.Forms.TextBox tcson4hane_textBox2;
        private System.Windows.Forms.TextBox kuladi_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}