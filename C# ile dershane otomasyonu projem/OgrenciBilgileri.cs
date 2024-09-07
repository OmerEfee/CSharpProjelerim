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
    public partial class OgrenciBilgileri : Form
    {
        public OgrenciBilgileri()
        {
            InitializeComponent();
        }

        private void OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1otomasyonDataSet.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrenciTableAdapter.Fill(this.deneme1otomasyonDataSet.Ogrenci);

        }
    }
}
