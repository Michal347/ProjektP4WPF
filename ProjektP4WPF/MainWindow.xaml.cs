using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektP4WPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static bool check = false, com = false;



        public MainWindow()
        {
            InitializeComponent();
            //combobox
            SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lotniskodb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.CommandText = "select DISTINCT(Odlot) from Loty";
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr6 = cmd.ExecuteReader();

            while (dr6.Read())
            {
                combo1.Items.Add(dr6.GetString(0).ToString());
                combo2.Items.Add(dr6.GetString(0).ToString());

            }
            conn.Close();


        }
     
        private void bt3_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void rad1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listView1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ckb1_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void ckb1_Un_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void listView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
