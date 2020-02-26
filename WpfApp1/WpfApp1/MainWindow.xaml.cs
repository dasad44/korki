using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string napis = t.Text;
            MessageBox.Show(napis);
            List<string> reserveList = new List<string>();
            string query = "SELECT * FROM rezerwacje";
            DbConnection dbconnection = new DbConnection();
            dbconnection.connectToDB(query, reserveList);
            foreach (var k in reserveList as List<string>)
            {
                textbox.Text = k.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string napis = t.Text;
            string query = "INSERT INTO cos (id, imie) VALUES(1,  @imie )";
            DbConnection dbconnection = new DbConnection();
            dbconnection.Executequery(query);
        }
    }
}
