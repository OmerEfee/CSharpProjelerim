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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using System.Data.SqlClient;
namespace otomasyondeneme2b
{
    public partial class yoneticigiris_Form1 : Form
    {
        public yoneticigiris_Form1()
        {
            InitializeComponent();
        }

        private void giris_button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=deneme1otomasyon;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select*from YoneticiGirisi where kullaniciAdi=@kul_adi and sifre=@şifre", con);
                cmd.Parameters.AddWithValue("@kul_adi",kulAdi_textBox1.Text);
                cmd.Parameters.AddWithValue("@şifre", sifre_textBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("GİRİŞ BAŞARILI !");
                    AnaSayfa frm2 = new AnaSayfa();
                    frm2.Show();
                    this.Close();
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

        private void cıkıs_button1_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sifreunuttum_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreSıfırlamakicinOnaylama ssio=new SifreSıfırlamakicinOnaylama();
            ssio.Show();
        }

        private void yoneticigiris_Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
