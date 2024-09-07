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
    public partial class OgretmenKayit : Form
    {
        public OgretmenKayit()
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
            SqlCommand komut = new SqlCommand("insert into Ogretmen(adSoyad,ogrtmnBrans,ogrtmnTelNo,ogrtmnTcNo,ogrtmnMaas)    values(@adsoyadi,@ogrtmnbrans,@ogrtmntelno,@ogrtmntcno,@ogrtmnmaas)", baglanti);
            komut.Parameters.AddWithValue("@adsoyadi", ogrtmnadsoyad_textBox1.Text);
            komut.Parameters.AddWithValue("@ogrtmnbrans", brans_textBox2.Text);
            komut.Parameters.AddWithValue("@ogrtmntelno", ogrtmntelno_textBox3.Text);
            komut.Parameters.AddWithValue("@ogrtmntcno", ogrtmntcno_textBox4.Text);
            komut.Parameters.AddWithValue("@ogrtmnmaas", ogrtmnmaas_textBox5.Text);
            
            
            komut.ExecuteNonQuery();
            verilerigoster("Select*from Ogretmen");
            baglanti.Close();
            ogrtmnadsoyad_textBox1.Clear();
            brans_textBox2.Clear();
            ogrtmntelno_textBox3.Clear();
            ogrtmntcno_textBox4.Clear();
            ogrtmnmaas_textBox5.Clear();
        }

        private void listele_button2_Click(object sender, EventArgs e)
        {
            verilerigoster("Select* from Ogretmen");
        }

        private void kayitsil_button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Ogretmen where adSoyad=@adisoyadi", baglanti);
            komut.Parameters.AddWithValue("@adisoyadi", kayitsil_textBox1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select*from Ogretmen");
            baglanti.Close();
            kayitsil_textBox1.Clear();
        }

        private void aramayap_button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*from Ogretmen where adSoyad like '%" + aramayap_textBox1.Text + "%'", baglanti);
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
            string ogretmenbrans = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string ogretmentelno = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string ogretmentcno = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string ogretmenmaas = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            
            ogrtmnadsoyad_textBox1.Text = adSoyad;
            brans_textBox2.Text = ogretmenbrans;
            ogrtmntelno_textBox3.Text = ogretmentelno;
            ogrtmntcno_textBox4.Text = ogretmentcno;
            ogrtmnmaas_textBox5.Text = ogretmenmaas;
        }

        private void guncelle_button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Ogretmen set ogrtmnBrans='" + brans_textBox2.Text + "',ogrtmnTelNo='" + ogrtmntelno_textBox3.Text + "',ogrtmnTcNo='" + ogrtmntcno_textBox4.Text + "',ogrtmnMaas='" + ogrtmnmaas_textBox5.Text +  "'where adSoyad='" + ogrtmnadsoyad_textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            verilerigoster("select *from Ogretmen");
            baglanti.Close();
        }

        private void anasayfa_button1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa =new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }

        private void OgretmenKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
