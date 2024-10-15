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

namespace LIBRARY_lite
{
    /// <summary>
    /// Логика взаимодействия для server_search.xaml
    /// </summary>
    public partial class server_search : Window
    {
        public server_search()
        {
            InitializeComponent();
            
        }

        private void search(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 255; i++)
            {
                for (int j = 1; j <= 255; j++)
                {
                    string name = $"10.23.{i}.{j}";
                    string connect = $"Server={name};Database=lib4;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
                    list.Text += "попытка номер 1";
                    try
                    {
                        using (var connection = new SqlConnection(connect))
                        {
                            connection.Open();
                            //MessageBox.Show($"10.23.{i}.{j}");
                            list.Text += name + "\tУСПЕХ!!!\n";
                        }
                    }
                    catch
                    {
                        list.Text += name + "\tпровал\n";
                    }
                }
            }
        }
    }
}
