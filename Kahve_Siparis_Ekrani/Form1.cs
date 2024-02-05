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
using Kahve_Siparis_Ekrani.Entities;
using Kahve_Siparis_Ekrani.DataAccess;

namespace Kahve_Siparis_Ekrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                var result = new List<User>();
                Connection connection = new Connection();
                con = connection.GetConnection(); // con değişkenini try bloğu dışında tanımla
                string userid = textBox1.Text;
                string password = textBox2.Text;
                SqlCommand cmd = new SqlCommand("select UserName, password from login where UserName='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                result = dt.AsEnumerable().Select(s => new User
                {
                    UserName = s.Field<string>("UserName"),
                    Password = s.Field<string>("password")
                }).ToList();

                var user = result.FirstOrDefault(x => x.UserName == textBox1.Text && x.Password == textBox2.Text);
                if (user != null)
                {
                    MessageBox.Show("Giriş başarılı Ana Sayfaya Hoş Geldiniz");
                    Form2 fr = new Form2();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Geçersiz Giriş, lütfen kullanıcı adı ve şifreyi kontrol edin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
