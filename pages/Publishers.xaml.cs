using LIBRARY_lite.windows;
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

namespace LIBRARY_lite.pages
{
    /// <summary>
    /// Логика взаимодействия для Publishers.xaml
    /// </summary>
    public partial class Publishers : Page
    {
        Window BOOKSwindow;
        Frame frame;
        public Publishers(Window w, Frame f)
        {
            InitializeComponent();
            BOOKSwindow = w;
            frame = f;
            List<PUBLISHERS> p = App.BOOKS.PUBLISHERS.ToList();
            PublishersDG.ItemsSource = p;
            publ_header.Text = $"Издательства ({p.Count})";
        }

        private void open_add_publishers(object sender, RoutedEventArgs e)
        {
            AddPublisher ap = new AddPublisher(PublishersDG, publ_header);
            ap.Owner = BOOKSwindow;
            ap.ShowDialog();
        }

        private void edit_publisher(object sender, RoutedEventArgs e)
        {
            EditPublisher er = new EditPublisher(PublishersDG, (PUBLISHERS)PublishersDG.SelectedItem)
            {
                Owner = BOOKSwindow
            };
            er.ShowDialog();
        }

        private void publ_search(object sender, TextChangedEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            PublishersDG.ItemsSource = App.BOOKS.PUBLISHERS.Where(em => em.PublisherName.Contains(s)).ToList();
            publ_header.Text = $"Издательства ({PublishersDG.Items.Count})";
        }
    }
}