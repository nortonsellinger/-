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
            PublishersDG.ItemsSource = App.BOOKS.PUBLISHERS.ToList();
        }

        private void open_add_publishers(object sender, RoutedEventArgs e)
        {
            AddPublisher ap = new AddPublisher(PublishersDG);
            ap.Owner = BOOKSwindow;
            ap.ShowDialog();
        }

        private void edit_publisher(object sender, RoutedEventArgs e)
        {
            EditPublisher er = new EditPublisher(PublishersDG, (PUBLISHERS)PublishersDG.SelectedItem);
            er.Owner = BOOKSwindow;
            er.ShowDialog();
            //var selpub = PublishersDG.SelectedItems;
            //if (selpub.Count != 0)
            //{
            //    if (selpub.Count == 1)
            //    {
            //        EditPublisher er = new EditPublisher(PublishersDG, (PUBLISHERS)PublishersDG.SelectedItem);
            //        er.Owner = BOOKSwindow;
            //        er.ShowDialog();
            //    }
            //    else
            //    {
            //        publerror.Text = "Выберите только одно издательство";
            //        publerror.Visibility = Visibility.Visible;
            //    }
            //}
            //else
            //{
            //    publerror.Text = "Выберите издательство для редактирования";
            //    publerror.Visibility = Visibility.Visible;
            //}
        }

        private void publ_select(object sender, SelectionChangedEventArgs e)
        {
            if (PublishersDG.SelectedItems.Count != 0)
            {
                publerror.Visibility = Visibility.Collapsed;
            }
        }
    }
}
