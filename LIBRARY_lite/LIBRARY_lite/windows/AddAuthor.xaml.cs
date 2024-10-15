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
    /// Логика взаимодействия для AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Window
    {
        DataGrid adg;
        public AddAuthor(DataGrid dg)
        {
            InitializeComponent();
            adg = dg;
        }
        private void add_author(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(newauthor.Text))
            {
                App.BOOKS.AUTHORS.Add(new AUTHORS { AuthorName = newauthor.Text});
                App.BOOKS.SaveChanges();
                adg.ItemsSource = App.BOOKS.AUTHORS.ToList();
                this.Close();
            }
            else
            {
                authorlackerror.Visibility = Visibility.Visible;
            }
        }
        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void author_typing(object sender, TextChangedEventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(newauthor.Text)))
            {
                authorlackerror.Visibility = Visibility.Collapsed;
            }
        }
    }
}
