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
    /// Логика взаимодействия для EditAuthor.xaml
    /// </summary>
    public partial class EditAuthor : Window
    {
        DataGrid adg;
        AUTHORS AUTHOR;
        public EditAuthor(DataGrid dg, AUTHORS a)
        {
            InitializeComponent();
            adg = dg;
            AUTHOR = a;
            newauthor.Text = AUTHOR.AuthorName;
        }

        private void edit_author(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(newauthor.Text))
            {
                App.BOOKS.AUTHORS.Find(AUTHOR.AuthorID).AuthorName = newauthor.Text;
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
            if (string.IsNullOrWhiteSpace(newauthor.Text))
            {
                authorlackerror.Visibility = Visibility.Collapsed;
            }
        }
    }
}
