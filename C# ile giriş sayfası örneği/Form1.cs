using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
     namespace GİRİŞ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@.;Initial Catalog=giris;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select*from giris1 where k_adi=@kul_adi and şifre=@şifre", con);
                cmd.Parameters.AddWithValue("@kul_adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@şifre", textBox2.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("GİRİŞ BAŞARILI !");
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı !");
                }

            }

            catch
            {
                MessageBox.Show("ERROR !");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2= new Form2();
            frm2.Show();
        }
    }
}
