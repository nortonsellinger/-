using LIBRARY_lite.pages;
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
    /// Логика взаимодействия для EditPublisher.xaml
    /// </summary>
    public partial class EditPublisher : Window
    {
        DataGrid pdg;
        PUBLISHERS PUBL;
        public EditPublisher(DataGrid dg, PUBLISHERS p)
        {
            InitializeComponent();
            pdg = dg;
            PUBL = p;
            newpubl.Text = PUBL.PublisherName;
        }

        private void publ_typing(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newpubl.Text))
            {
                publerror.Visibility = Visibility.Collapsed;
            }
        }

        private void edit_publisher(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(newpubl.Text))
            {
                App.BOOKS.PUBLISHERS.Find(PUBL.PublisherID).PublisherName = newpubl.Text;
                App.BOOKS.SaveChanges();
                pdg.ItemsSource = App.BOOKS.PUBLISHERS.ToList();
                this.Close();
            }
            else
            {
                publerror.Visibility = Visibility.Visible;
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
