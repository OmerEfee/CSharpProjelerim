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

namespace otomasyondeneme2b
{
    public partial class DanismanSifreSıfırlamakicinOnaylama : Form
    {
        public DanismanSifreSıfırlamakicinOnaylama()
        {
            InitializeComponent();
        }

        private void sifresifirla_button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=deneme1otomasyon;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select*from YoneticiGirisi where kullaniciAdi=@kul_adi and TCNOSON4=@tcnoson4", con);
                cmd.Parameters.AddWithValue("@kul_adi", kuladi_textBox1.Text);
                cmd.Parameters.AddWithValue("@tcnoson4", tcson4hane_textBox2.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    DanismanYeniSifreOlusturma dyso = new DanismanYeniSifreOlusturma();
                    dyso.Show();
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

        private void DanismanSifreSıfırlamakicinOnaylama_Load(object sender, EventArgs e)
        {

        }
    }
}
