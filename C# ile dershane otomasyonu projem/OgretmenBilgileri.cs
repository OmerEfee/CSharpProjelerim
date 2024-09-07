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
    public partial class OgretmenBilgileri : Form
    {
        public OgretmenBilgileri()
        {
            InitializeComponent();
        }

        private void OgretmenBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'deneme1otomasyonDataSet.Ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogretmenTableAdapter.Fill(this.deneme1otomasyonDataSet.Ogretmen);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
