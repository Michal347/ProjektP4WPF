using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektP4WPF
{
    /// <summary>
    /// Logika interakcji dla klasy Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Zarejestruj_Click(object sender, RoutedEventArgs e)
        {
            string connection = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lotniskodb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                string query = "Insert into Logowanie(Login,haslo,Imię,Nazwisko) Values('" + RegLoginbox.Text + "','" + regpasswordbos.Password + "','" + regImiębox.Text + "','" + Regnazwiskobox.Text + "')";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();
                da.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Stworzono pomyślnie");
                ClearData();
            }
            catch
            {
                MessageBox.Show("Błąd");
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearData()
            {
                RegLoginbox.Text = "";
                regpasswordbos.Password = "";
                regImiębox.Text = "";
                Regnazwiskobox.Text = "";

            }
        

        private void Cofnij_Click(object sender, RoutedEventArgs e)
        {
            Login main = new Login();
            main.Show();
            this.Hide();
        }
    }
}
