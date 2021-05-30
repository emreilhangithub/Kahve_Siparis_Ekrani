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
using System.Data.OleDb; 
using System.Data.SqlClient;

namespace Kahve_Siparis_Ekrani
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection();

        public Form1()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-E9UTSVL;Initial Catalog=KahveSiparis;Integrated Security=True";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E9UTSVL;Initial Catalog=KahveSiparis;Integrated Security=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-E9UTSVL;Initial Catalog=KahveSiparis;Integrated Security=True";
            con.Open();
            string userid = textBox1.Text;
            string password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select UserName,password from login where UserName='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Giriş başarılı Ana Sayfaya Hoş Geldiniz");
                Form2 fr = new Form2(); //sınıfın özelliklerini kullanmak için nesne türettik
                fr.Show(); //formu göster
                this.Hide(); // Şuanki formu gizler bunu gizlersek kapanmaz program

            }
            else
            {
                MessageBox.Show("Geçersiz Giriş, lütfen kullanıcı adı ve şifreyi kontrol edin");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
