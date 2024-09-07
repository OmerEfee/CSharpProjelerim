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
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otomasyondeneme2b
{
    public partial class Ogrenci_Kayit : Form
    {
        public Ogrenci_Kayit()
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
        private void listele_button1_Click(object sender, EventArgs e)
        {
            verilerigoster("Select*from Ogrenci");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kaydet_button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ogrenci(adSoyad,ogrncNo,ogrncSınıf,ogrncSube,ogrncBolumu,ogrncTelNo,ogrncTcNo,ogrncCinsiyet,veliAdSoyad,veliTelNo,ogrncKayitÜcreti)    values(@adsoyadi,@ogrncino,@ogrncisınıf,@ogrncisube,@ogrncibolumu,@ogrncitelno,@ogrncitcno,@ogrncicinsiyet,@veliadsoyad,@velitelno,@öğrencikayitücreti)", baglanti);
            komut.Parameters.AddWithValue("@adsoyadi", adsoyad_textBox1.Text);
            komut.Parameters.AddWithValue("@ogrncino", ogrncno_textBox2.Text);
            komut.Parameters.AddWithValue("@ogrncisınıf", ogrncsnf_textBox3.Text);
            komut.Parameters.AddWithValue("@ogrncisube", ogrncsube_textBox4.Text);
            komut.Parameters.AddWithValue("@ogrncibolumu", ogrncbolumu_textBox5.Text);
            komut.Parameters.AddWithValue("@ogrncitelno", ogrnctelno_textBox6.Text);
            komut.Parameters.AddWithValue("@ogrncitcno", ogrnctcno_textBox7.Text);
            komut.Parameters.AddWithValue("@ogrncicinsiyet", ogrnccinsiyet_textBox8.Text);
            komut.Parameters.AddWithValue("@veliadsoyad", veliadsoyad_textBox9.Text);
            komut.Parameters.AddWithValue("@velitelno", velitelno_textBox10.Text);
            komut.Parameters.AddWithValue("@öğrencikayitücreti",kayitücreti_textBox1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select*from Ogrenci");
            baglanti.Close();
            adsoyad_textBox1.Clear();
            ogrncno_textBox2.Clear();
            ogrncsnf_textBox3.Clear();
            ogrncsube_textBox4.Clear();
            ogrncbolumu_textBox5.Clear();
            ogrnctelno_textBox6.Clear();
            ogrnctcno_textBox7.Clear();
            ogrnccinsiyet_textBox8.Clear();
            veliadsoyad_textBox9.Clear();
            velitelno_textBox10.Clear();
            kayitücreti_textBox1.Clear();
        }

    private void kayitsil_button1_Click(object sender, EventArgs e)
        {
                baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ogrenci where adSoyad=@adisoyadi",baglanti);
            komut.Parameters.AddWithValue("@adisoyadi",silkayit_textBox1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select*from Ogrenci");
            baglanti.Close();
            silkayit_textBox1.Clear();
        }

        private void ogrncara_button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*from Ogrenci where adSoyad like '%"+ara_textBox1.Text+"%'",baglanti);
            SqlDataAdapter da =new SqlDataAdapter(komut);
            DataSet ds=new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string adSoyad = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string ogrencino = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string ogrencisınıf = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string ogrencisube = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string ogrencibolum = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string ogrencitelno = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string ogrencitcno = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string ogrencicinsiyet= dataGridView1.Rows[secilialan].Cells[7].Value.ToString();
            string veliAdsoyad = dataGridView1.Rows[secilialan].Cells[8].Value.ToString();
            string veliTelNo= dataGridView1.Rows[secilialan].Cells[9].Value.ToString();
            string ogrncKayitÜcreti = dataGridView1.Rows[secilialan].Cells[10].Value.ToString() ;
            adsoyad_textBox1.Text = adSoyad;
            ogrncno_textBox2.Text = ogrencino;
            ogrncsnf_textBox3.Text = ogrencisınıf;
            ogrncsube_textBox4.Text = ogrencisube;
            ogrncbolumu_textBox5.Text = ogrencibolum;
            ogrnctelno_textBox6.Text= ogrencitelno;
            ogrnctcno_textBox7.Text = ogrencitcno;
            ogrnccinsiyet_textBox8.Text = ogrencicinsiyet;
            veliadsoyad_textBox9.Text = veliAdsoyad;
            velitelno_textBox10.Text= veliTelNo;
            kayitücreti_textBox1.Text= ogrncKayitÜcreti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ogrenci set ogrncNo='"+ogrncno_textBox2.Text+"',ogrncSınıf='"+ogrncsnf_textBox3.Text+"',ogrncSube='"+ogrncsube_textBox4.Text+"',ogrncBolumu='"+ogrncbolumu_textBox5.Text+"',ogrncTelNo='"+ogrnctelno_textBox6.Text+"',ogrncTcNo='"+ogrnctcno_textBox7.Text+"',ogrncCinsiyet='"+ogrnccinsiyet_textBox8.Text+"',veliAdSoyad='"+veliadsoyad_textBox9.Text+"',veliTelNo='"+velitelno_textBox10.Text+"',ogrncKayitÜcreti='"+kayitücreti_textBox1.Text+"'where adSoyad='"+adsoyad_textBox1.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select *from Ogrenci");
            baglanti.Close();
        }

        private void anasayfa_button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfa= new AnaSayfa();
            anaSayfa.Show();
            this.Close();
        }

        private void Ogrenci_Kayit_Load(object sender, EventArgs e)
        {

        }
    }
}
