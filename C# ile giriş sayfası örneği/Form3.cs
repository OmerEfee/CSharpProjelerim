﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GİRİŞ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text && textBox1.Text!=null & textBox2.Text!=null)
            {
                MessageBox.Show("Şifreniz Başarıyla Yenilenmiştir !");
            }
            else {
                MessageBox.Show("Şifreleriniz uyuşmuyor.Lütfen tekrar deneyin!");
            }
        }
    }
}
