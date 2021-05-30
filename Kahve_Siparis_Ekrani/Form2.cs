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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            string[] kahveler = { "Misto", "Americano", "Bianco", "Cappucino", "Macchiato", "Con Panna", "Mocha" };

            foreach (string k in kahveler)
            {
                comboBox1.Items.Add(k);
                //comboBox1.Items.Add(weekDays2[i]);
            }

            string[] sogukicecekler = { "Frappe", "Limonata", "Ayran"};

            foreach (string soguk in sogukicecekler)
            {
                comboBox2.Items.Add(soguk);
            }

            string[] sicakicecekler = { "Çay", "Hot Chocolate", "Chai Tea Latte"};

            foreach (string sicak in sicakicecekler)
            {
                comboBox3.Items.Add(sicak);
            }



        }      

        private void siparişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3(); 
            fr.Show(); 
            this.Hide(); 
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siparişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2(); 
            fr.Show(); 
            this.Hide(); 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
