using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kahve_Siparis_Ekrani
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siparişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3(); //sınıfın özelliklerini kullanmak için nesne türettik
            fr.Show(); //formu göster
            this.Hide(); // Şuanki formu gizler bunu gizlersek kapanmaz program
        }

        private void siparişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show(); //formu göster
            this.Hide(); // Şuanki formu gizler bunu gizlersek kapanmaz program
        }
    }
}
