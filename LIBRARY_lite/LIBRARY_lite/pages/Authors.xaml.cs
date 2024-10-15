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
    /// Логика взаимодействия для Authors.xaml
    /// </summary>
    public partial class Authors : Page
    {
        Window BOOKSwindow;
        Frame frame;
        public Authors(Window w, Frame f)
        {
            InitializeComponent();
            BOOKSwindow = w;
            frame = f;
            AuthorsDG.ItemsSource = App.BOOKS.AUTHORS.ToList();
        }

        private void open_add_authors(object sender, RoutedEventArgs e)
        {
            AddAuthor aa = new AddAuthor(AuthorsDG);
            aa.Owner = BOOKSwindow;
            aa.ShowDialog();
        }

        private void edit_author(object sender, RoutedEventArgs e)
        {
            EditAuthor ea = new EditAuthor(AuthorsDG, (AUTHORS)AuthorsDG.SelectedItem);
            ea.Owner = BOOKSwindow;
            ea.ShowDialog();
            //var selaut = AuthorsDG.SelectedItems;
            //if (selaut.Count != 0)
            //{
            //    if (selaut.Count == 1)
            //    {
            //        EditAuthor ea = new EditAuthor(AuthorsDG, (AUTHORS)AuthorsDG.SelectedItem);
            //        ea.Owner = BOOKSwindow;
            //        ea.ShowDialog();
            //    }
            //    else
            //    {
            //        authorerror.Visibility = Visibility.Visible;
            //    }
            //}
            //else
            //{
            //    authorlackerror.Visibility = Visibility.Visible;
            //}
        }

        private void auth_select(object sender, SelectionChangedEventArgs e)
        {
            authorlackerror.Visibility = Visibility.Collapsed;
        }

        //private void delete_authors(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
