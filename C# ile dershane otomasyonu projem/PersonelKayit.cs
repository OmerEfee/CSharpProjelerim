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
    public partial class PersonelKayit : Form
    {
        public PersonelKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=deneme1otomasyon;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void kaydet_button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Personel(adSoyad,personelGorevi,personelTelNo,personelTcNo,personelMaas)    values(@adsoyadi,@personelgorevi,@personeltelno,@personeltcno,@personelmaas)", baglanti);
            komut.Parameters.AddWithValue("@adsoyadi",   adsoyad_textBox1.Text);
            komut.Parameters.AddWithValue("@personelgorevi", personelgorevi_textBox2.Text);
            komut.Parameters.AddWithValue("@personeltelno", personeltelno_textBox3.Text);
            komut.Parameters.AddWithValue("@personeltcno", personeltcno_textBox4.Text);
            komut.Parameters.AddWithValue("@personelmaas", personelmaas_textBox5.Text);


            komut.ExecuteNonQuery();
            verilerigoster("Select*from Personel");
            baglanti.Close();
            adsoyad_textBox1.Clear();
            personelgorevi_textBox2.Clear();
            personeltelno_textBox3.Clear();
            personeltcno_textBox4.Clear();
            personelmaas_textBox5.Clear();
        }

        private void listele_button2_Click(object sender, EventArgs e)
        {
            verilerigoster("Select*from Personel");
        }

        private void kayitsil_button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Personel where adSoyad=@adisoyadi", baglanti);
            komut.Parameters.AddWithValue("@adisoyadi", kayitsil_textBox1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select*from Personel");
            baglanti.Close();
            kayitsil_textBox1.Clear();
        }

        private void aramayap_button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*from Personel where adSoyad like '%" + aramayap_textBox2.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string adSoyad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string personelgorevi = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string personeltelno = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string personeltcno = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string personelmaas = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();

            adsoyad_textBox1.Text = adSoyad;
            personelgorevi_textBox2.Text = personelgorevi;
            personeltelno_textBox3.Text =personeltelno;
            personeltcno_textBox4.Text = personeltcno;
            personelmaas_textBox5.Text = personelmaas;
        }

        private void guncelle_button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Personel set personelGorevi='" + personelgorevi_textBox2.Text + "',personelTelNo='" + personeltelno_textBox3.Text + "',personelTcNo='" + personeltcno_textBox4.Text + "',personelMaas='" + personelmaas_textBox5.Text + "'where adSoyad='" + adsoyad_textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select *from Personel");
            baglanti.Close();
        }

        private void anasayfa_button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa= new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }

        private void PersonelKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
