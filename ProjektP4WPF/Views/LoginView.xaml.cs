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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektP4WPF.Views
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        //private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    //if (e.LeftButton == MouseButtonState.Pressed)
        //    //    DragMove();
        //}

        //private void Loginbutton_Click(object sender, RoutedEventArgs e)
        //{
        //    //SqlConnection con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Lotniskodb; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        //    //SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Logowanie WHERE Login='" + Loginbox.Text + "' AND Haslo='" + passwordbox.Password + "'", con);

        //    //DataTable dt = new DataTable();
        //    //sda.Fill(dt);
        //    //if (dt.Rows[0][0].ToString() == "1")
        //    //{

        //    //    this.Hide();
        //    //    new MainWindow().Show();
        //    //}
        //    //else
        //    //    MessageBox.Show("Niepoprawne dane");
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //Register reg = new Register();
        //    //reg.Show();
        //    //this.Hide();
        //}
    }
}
