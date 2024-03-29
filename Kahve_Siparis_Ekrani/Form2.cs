﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //komutları kullanmak için gerekli kütüphane
using Kahve_Siparis_Ekrani.DataAccess;

namespace Kahve_Siparis_Ekrani
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            string[] kahveler = { "Misto", "Americano", "Bianco", "Cappucino", "Macchiato", "Con Panna", "Mocha" };

            //comboBox1.Items.Add(kahveler[2]); 2.olanı almak için kullanırız

            foreach (string k in kahveler) //form closing 
            {
                comboBox1.Items.Add(k);
            }

            string[] sogukicecekler = { "Frappe", "Limonata", "Ayran" };

            foreach (string soguk in sogukicecekler)
            {
                comboBox2.Items.Add(soguk);
            }

            string[] sicakicecekler = { "Çay", "Hot Chocolate", "Chai Tea Latte" };

            foreach (string sicak in sicakicecekler)
            {
                comboBox3.Items.Add(sicak);
            }

        }

        private void siparişlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
            //this.Hide(); 
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

        double toplamtutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string khvsec, sgkicsec, sicaksec;
            string c1 = "";
            string c2 = "";
            string r1 = "";
            string r2 = "";
            string r3 = "";

            int khvadet, sgkkadet, sicakadet;
            double toplam = 0;

            khvsec = comboBox1.Text;
            sgkicsec = comboBox2.Text;
            sicaksec = comboBox3.Text;

            khvadet = Convert.ToInt16(numericUpDown1.Value);
            sgkkadet = Convert.ToInt16(numericUpDown2.Value);
            sicakadet = Convert.ToInt16(numericUpDown3.Value);



            switch (khvsec)
            {
                case "Misto": toplam = toplam + 4.5 * khvadet; break;
                case "Americano": toplam = toplam + 5.75 * khvadet; break;
                case "Bianco": toplam = toplam + 6 * khvadet; break;
                case "Cappucino": toplam = toplam + 7.5 * khvadet; break;
                case "Macchiato": toplam = toplam + 6.75 * khvadet; break;
                case "Con Panna": toplam = toplam + 8.0 * khvadet; break;
                case "Mocha": toplam = toplam + 7.75 * khvadet; break;
                default: break;
            }

            switch (sgkicsec)
            {
                case "Frappe": toplam = toplam + 5.5 * sgkkadet; break;
                case "Limonata": toplam = toplam + 5.5 * sgkkadet; break;
                case "Ayran": toplam = toplam + 5.5 * sgkkadet; break;
                default: break;
            }

            switch (sicaksec)
            {
                case "Çay": toplam = toplam + 3 * sicakadet; break;
                case "Hot Chocolate": toplam = toplam + 4.5 * sicakadet; break;
                case "Chai Tea Latte": toplam = toplam + 6.5 * sicakadet; break;
                default: break;
            }

            if (check1x.Checked == true)
            {
                toplam = toplam + 0.75;
                c1 = check1x.Text;
            }

            if (check2x.Checked == true)
            {
                toplam = toplam + 1.5;
                c2 = check2x.Text;
            }

            if (radioYagsiz.Checked == true)
            {
                toplam = toplam + 0.5;
                r1 = radioYagsiz.Text;
            }
            if (radioSoya.Checked == true)
            {
                toplam = toplam + 0.5;
                r2 = radioSoya.Text;
            }
            if (radioVenti.Checked == true)
            {
                toplam = toplam + 1;
                r3 = radioVenti.Text;
            }
            if (radioGrande.Checked == true)
            {
                toplam = toplam + 1.25;
                r3 = radioGrande.Text;
            }
            if (radioTall.Checked == true)
            {
                toplam = toplam + 1.75;
                r3 = radioTall.Text;
            }

            if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0 && numericUpDown3.Value == 0)
            {
                // Eğer hepsi sıfırsa hata mesajını göster
                MessageBox.Show("Hata: Tüm değerler sıfır olamaz Lütfen en az 1 ürün seçiniz!");
                return;
            }

            // listBox1.Items.Add(mus.AdSoyad + mus.Telefon + mus.Adres);
            lsbSiparisler.Items.Add(khvsec + " , " + sgkicsec + " , " + sicaksec + " ,"
                + " " + " Shot = " + c1 + "," + c2 + " Süt = " + r1 + " , " + r2 + " Boyut =" + r3
                + " , " + "Toplam =" + toplam
                );



            toplamtutar = toplamtutar + toplam;


            label13.Text = toplamtutar.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri mus = new Musteri();
            mus.AdSoyad = textBox1.Text;
            mus.Telefon = maskedTextBox1.Text;
            mus.Adres = richTextBox1.Text;
            SqlConnection con = null;

            if (toplamtutar > 0)
            {
                try
                {
                    Connection connection = new Connection();
                    con = connection.GetConnection(); // con değişkenini try bloğu dışında tanımla                    
                        using (SqlCommand komut = new SqlCommand("INSERT INTO orders (SipAdSoyad, SipTelNo, SipAdres, SipTutar) VALUES (@p1, @p2, @p3, @p4)", con))
                        {
                            // Komut nesnesini türettik

                            komut.Parameters.Add("@p1", SqlDbType.NVarChar).Value = mus.AdSoyad;
                            komut.Parameters.Add("@p2", SqlDbType.NVarChar).Value = mus.Telefon;
                            komut.Parameters.Add("@p3", SqlDbType.NVarChar).Value = mus.Adres;
                            komut.Parameters.Add("@p4", SqlDbType.Decimal).Value = toplamtutar;

                            int adet = komut.ExecuteNonQuery();

                            if (adet > 0)
                                MessageBox.Show("Sipariş başarılı bir şekilde kayıt edildi");
                            else
                                MessageBox.Show("Sipariş kayıt edilemedi");
                        }

                        MessageBox.Show("Toplam " + lsbSiparisler.Items.Count + " Adet siparişiniz " + toplamtutar.ToString("C") + " Tutarındadır");
                                       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Hata olsa da olmasa da bağlantıyı kapat
                }
            }
            else
            {
                MessageBox.Show("Sipariş Verebilmek İçin Toplam Tutar 0'dan Büyük Olmalıdır");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Kapatmak İstediginizden Emin Misiniz ?", "Kahve Otomasyonu",
         MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
