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
using System.Windows.Shapes;

namespace LIBRARY_lite.windows
{
    /// <summary>
    /// Логика взаимодействия для AddPublisher.xaml
    /// </summary>
    public partial class AddPublisher : Window
    {
        DataGrid pdg;
        TextBlock p;
        public AddPublisher(DataGrid dg, TextBlock publ)
        {
            InitializeComponent();
            pdg = dg;
            p = publ;
        }
        private void author_typing(object sender, TextChangedEventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(newpublisher.Text)))
            {
                publisherlackerror.Visibility = Visibility.Collapsed;
            }
        }
        private void add_publisher(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(newpublisher.Text))
            {
                App.BOOKS.PUBLISHERS.Add(new PUBLISHERS {PublisherName = newpublisher.Text });
                App.BOOKS.SaveChanges();
                pdg.ItemsSource = App.BOOKS.PUBLISHERS.ToList();
                p.Text = $"Издательства ({pdg.Items.Count})";
                this.Close();
            }
            else
            {
                publisherlackerror.Visibility = Visibility.Visible;
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
