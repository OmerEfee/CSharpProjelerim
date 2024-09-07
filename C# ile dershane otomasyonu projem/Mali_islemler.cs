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
using System.Data.OleDb;

namespace otomasyondeneme2b
{
    public partial class Mali_islemler : Form
    {
        public Mali_islemler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=deneme1otomasyon;Integrated Security=True");

        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void verikaydet_button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MaliKisim(dershaneKirası,tplmOgrtmnMaas,tplmPersonelMaas,tplmOgrncGeliri,ToplamGelir,ToplamGider,YıllıkKazanc)    values(@dershanekirasi,@tplmogrtmaas,@tplmpersonelmaas,@tplmogrncigeliri,@tplmgelir,@tplmgider,@yillikkazanc)", baglanti);
            komut.Parameters.AddWithValue("@dershanekirasi ", kira_textBox1.Text);
            komut.Parameters.AddWithValue("@tplmogrtmaas ", ogrtmnmaas_textBox2.Text);
            
            komut.Parameters.AddWithValue("@tplmpersonelmaas", personelmaas_textBox3.Text);
            komut.Parameters.AddWithValue("@tplmogrncigeliri", ogrncgeliri_textBox4.Text);
             komut.Parameters.AddWithValue("@tplmgelir", tplmgelir_textBox1.Text);
             komut.Parameters.AddWithValue("@tplmgider", tplmgider_textBox2.Text);
            komut.Parameters.AddWithValue("@yillikkazanc", yllkkznc_textBox1.Text);

            
            komut.ExecuteNonQuery();
            verilerigoster("Select*from MaliKisim");
            baglanti.Close();
            kira_textBox1.Clear();
            ogrtmnmaas_textBox2.Clear();
            personelmaas_textBox3.Clear();
            ogrncgeliri_textBox4.Clear();
            yllkkznc_textBox1.Clear();
          
        }


        private void verigncelle_button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MaliKisim set dershaneKirası='" + kira_textBox1.Text + "',tplmPersonelMaas='" + personelmaas_textBox3.Text + "',tplmOgrncGeliri='" + ogrncgeliri_textBox4.Text + "',ToplamGelir='" + tplmgelir_textBox1.Text + "',ToplamGider='" +tplmgider_textBox2.Text+"',YıllıkKazanc='" + yllkkznc_textBox1.Text + "'where tplmOgrtmnMaas='" + ogrtmnmaas_textBox2.Text + "'", baglanti);
            tplmgelir_textBox1.Text = ogrncgeliri_textBox4.Text;
            komut.ExecuteNonQuery();
           
            verilerigoster("select *from MaliKisim");
           baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
            string dershaneKirası = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string tplmOgrtmnMaas = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string tplmPersonelMaas = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string tplmOgrncGeliri = dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string ToplamGelir = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string ToplamGider = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string YıllıkKazanc = dataGridView1.Rows[secilialan].Cells[6].Value.ToString();

            kira_textBox1.Text = dershaneKirası;
            ogrtmnmaas_textBox2.Text = tplmOgrtmnMaas;
            personelmaas_textBox3.Text = tplmPersonelMaas;
            ogrncgeliri_textBox4.Text = tplmOgrncGeliri;
            tplmgelir_textBox1.Text= ToplamGelir;
            tplmgider_textBox2.Text= ToplamGider;
            yllkkznc_textBox1.Text = YıllıkKazanc;
        }

        private void ogrtmnmaas_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplamAlişSayisi = 0;
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from Ogretmen ", baglanti);
            SqlDataReader sorguoku = sorgu.ExecuteReader();
            while (sorguoku.Read())
            {
                if (int.TryParse(sorguoku["ogrtmnMaas"].ToString(), out int alış))
                {
                    toplamAlişSayisi += alış;
                }
            }
            ogrtmnmaas_textBox2.Text = toplamAlişSayisi.ToString();
            baglanti.Close();
            //----------------
            baglanti.Open();
            int toplamAlişSayisi1 = 0;
            
            SqlCommand sorgu1 = new SqlCommand("select * from Personel ", baglanti);
            SqlDataReader sorguoku1 = sorgu1.ExecuteReader();
            while (sorguoku1.Read())
            {
                if (int.TryParse(sorguoku1["personelMaas"].ToString(), out int alış1))
                {
                    toplamAlişSayisi1 += alış1;
                }
            }
            personelmaas_textBox3.Text = toplamAlişSayisi1.ToString();
            
            baglanti.Close();
            //-------------
            baglanti.Open();
            int toplamAlişSayisi2 = 0;

            SqlCommand sorgu2 = new SqlCommand("select * from Ogrenci ", baglanti);
            SqlDataReader sorguoku2 = sorgu2.ExecuteReader();
            while (sorguoku2.Read())
            {
                if (int.TryParse(sorguoku2["ogrncKayitÜcreti"].ToString(), out int alış2))
                {
                    toplamAlişSayisi2 += alış2;
                }
            }
            ogrncgeliri_textBox4.Text = toplamAlişSayisi2.ToString();
            tplmgelir_textBox1.Text = ogrncgeliri_textBox4.Text;
            tplmgider_textBox2.Text =  (kira_textBox1.Text) + (ogrtmnmaas_textBox2.Text) + (personelmaas_textBox3.Text);
           // yllkkznc_textBox1.Text = tplmgelir_textBox1.Text - tplmgider_textBox2.Text;
            baglanti.Close();
            progressBar1.Value=100;
            baglanti.Open();
            verilerigoster("Select*from MaliKisim");
            baglanti.Close();
        }

        private void kayitsil_button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MaliKisim where dershaneKirası=@dershanekirasi", baglanti);
            komut.Parameters.AddWithValue("@dershanekirasi", kayitsil_textBox1.Text);
            komut.ExecuteNonQuery();
            verilerigoster("select*from MaliKisim");
            baglanti.Close();
            kayitsil_textBox1.Clear();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           // progressBar1.Value = 100;
        }

        private void Mali_islemler_Load(object sender, EventArgs e)
        {

        }
    }
}
