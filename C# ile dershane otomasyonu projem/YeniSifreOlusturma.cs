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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using otomasyondeneme2b.deneme1otomasyonDataSetTableAdapters;

namespace otomasyondeneme2b
{
    public partial class YeniSifreOlusturma : Form
    {
        public YeniSifreOlusturma()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=deneme1otomasyon;Integrated Security=True");

        private void sifreonayla_button1_Click(object sender, EventArgs e)
        {
            if (yenisifre_textBox1.Text == ysifreonay_textBox2.Text && yenisifre_textBox1.Text != null & ysifreonay_textBox2.Text != null)
            {
                con.Open();
                // SqlCommand komut= new SqlCommand("insert into giris1(yeni_sifre)values(@yenisifre)",con);
                SqlCommand komut = new SqlCommand("update YoneticiGirisi set sifre='" + ysifreonay_textBox2.Text + "'where kullaniciAdi='" + kuladii_textBox3.Text + "'", con);

                komut.Parameters.AddWithValue("@yenisifre", ysifreonay_textBox2.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Şifreniz Başarıyla Yenilenmiştir !");
                yoneticigiris_Form1 ygform1 = new yoneticigiris_Form1();
                ygform1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifreleriniz uyuşmuyor.Lütfen tekrar deneyin!");
            }
        }

        private void YeniSifreOlusturma_Load(object sender, EventArgs e)
        {

        }
    }
}
