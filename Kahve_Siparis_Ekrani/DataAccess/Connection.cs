using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //kutuphaneyi ekledik
using System.Windows.Forms;

namespace Kahve_Siparis_Ekrani.DataAccess
{
    public class Connection
    {
        public string DataSource { get; set; } = "DESKTOP-E9UTSVL";
        public string InitialCatalog { get; set; } = "KahveSiparis";
        public bool IntegratedSecurity { get; set; } = true;

        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection($"Data Source={DataSource};Initial Catalog={InitialCatalog};Integrated Security={IntegratedSecurity}");

            try
            {
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bağlantı hatası: {ex.Message}");
                throw; // Hata tekrar fırlatılıyor
            }
        }
    }
}
