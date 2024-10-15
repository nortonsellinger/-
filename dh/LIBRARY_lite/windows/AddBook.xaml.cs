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
    /// Логика взаимодействия для AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public AddBook()
        {
            InitializeComponent();
            authors.ItemsSource = App.BOOKS.AUTHORS.Select(a => a.AuthorName).ToList();
            publishers.ItemsSource = App.BOOKS.PUBLISHERS.Select(p => p.PublisherName).ToList();
        }

        private void isbn_typing(object sender, TextChangedEventArgs e)
        {
            
        }

        private void name_typing(object sender, TextChangedEventArgs e)
        {
            
        }

        private void author_typing(object sender, TextChangedEventArgs e)
        {
            if (newauthor.Text != "")
            {
                newauthor.BorderBrush = Brushes.Black;
                authborder.BorderThickness = new Thickness(0);
            }
            else
            {
                newauthor.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#555");
                authborder.BorderThickness = new Thickness(2);
            }
        }

        private void publ_typing(object sender, TextChangedEventArgs e)
        {
            if (newpubl.Text != "")
            {
                newpubl.BorderThickness = new Thickness(2);
                publborder.BorderThickness = new Thickness(0);
            }
            else
            {
                newpubl.BorderThickness = new Thickness(0);
                publborder.BorderThickness = new Thickness(2);
            }
        }

        private void year_typing(object sender, TextChangedEventArgs e)
        {

        }

        private void cancel(object sender, RoutedEventArgs e)
        {

        }

        private void add_reader(object sender, RoutedEventArgs e)
        {

        }

        private void publdrop(object sender, EventArgs e)
        {
            MessageBox.Show("дроп");
        }
    }
}
