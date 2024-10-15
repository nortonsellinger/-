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
    public partial class Authors : Page
    {
        Window BOOKSwindow;
        Frame frame;
        public Authors(Window w, Frame f)
        {
            InitializeComponent();
            BOOKSwindow = w;
            frame = f;
            List<AUTHORS> a = App.BOOKS.AUTHORS.ToList();
            AuthorsDG.ItemsSource = a;
            authors_header.Text = $"Авторы ({a.Count})";
        }

        private void open_add_authors(object sender, RoutedEventArgs e)
        {
            AddAuthor aa = new AddAuthor(AuthorsDG, authors_header);
            aa.Owner = BOOKSwindow;
            aa.ShowDialog();
        }

        private void edit_author(object sender, RoutedEventArgs e)
        {
            EditAuthor ea = new EditAuthor(AuthorsDG, (AUTHORS)AuthorsDG.SelectedItem)
            {
                Owner = BOOKSwindow
            };
            ea.ShowDialog();
        }


        private void author_search(object sender, TextChangedEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            AuthorsDG.ItemsSource = App.BOOKS.AUTHORS.Where(em => em.AuthorName.Contains(s)).ToList();
            authors_header.Text = $"Авторы ({AuthorsDG.Items.Count})";
        }

    }
}
