using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace GİRİŞ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@.;Initial Catalog=giris;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select*from giris1 where k_adi=@kul_adi and TCNOSON4=@tcnoson4", con);
                cmd.Parameters.AddWithValue("@kul_adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@tcnoson4", textBox2.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya TC no son 4 hanesi hatalı !");
                }

            }

            catch
            {
                MessageBox.Show("ERROR !");
            }

        }
    }
    }

