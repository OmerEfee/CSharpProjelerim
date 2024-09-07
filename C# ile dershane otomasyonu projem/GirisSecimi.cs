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
    public partial class GirisSecimi : Form
    {
        public GirisSecimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           yoneticigiris_Form1 ygform1= new yoneticigiris_Form1();
            ygform1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanismanGirisi dg=new DanismanGirisi();
            dg.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void GirisSecimi_Load(object sender, EventArgs e)
        {

        }
    }
}
