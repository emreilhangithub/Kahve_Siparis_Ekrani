﻿using System;
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
    }
}
