using otomasyondeneme2b.deneme1otomasyonDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyondeneme2b
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void ogrncKayıt_button1_Click(object sender, EventArgs e)
        {
            Ogrenci_Kayit ogrncikyt = new Ogrenci_Kayit();
            ogrncikyt.Show();
        }

        private void ogrncbilgileri_button1_Click(object sender, EventArgs e)
        {
            OgrenciBilgileri ogrncBilgileri = new OgrenciBilgileri();
            ogrncBilgileri.Show();
        }

        private void ogrtmnkayıt_button1_Click(object sender, EventArgs e)
        {
            OgretmenKayit ogrtmnkayit= new OgretmenKayit();
            ogrtmnkayit.Show();

        }

        private void ogrtmnbilgileri_button1_Click(object sender, EventArgs e)
        {
            OgretmenBilgileri ogrtmnblgileri = new OgretmenBilgileri();
            ogrtmnblgileri.Show();
        }

        private void personelkayıt_button1_Click(object sender, EventArgs e)
        {
            PersonelKayit personelKayit= new PersonelKayit();
            personelKayit.Show();
        }

        private void personelbilgileri_button1_Click(object sender, EventArgs e)
        {
            PersonelBilgileri personelbilgileri= new PersonelBilgileri();
            personelbilgileri.Show();
        }

        private void mali_button1_Click(object sender, EventArgs e)
        {
            Mali_islemler mali_islemler= new Mali_islemler();
            mali_islemler.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
