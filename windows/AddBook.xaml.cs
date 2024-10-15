using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        DataGrid bdg;
        AUTHORS AUTHOR;
        PUBLISHERS PUBL;
        TextBlock b;
        public AddBook(DataGrid dg, TextBlock book)
        {
            InitializeComponent();
            bdg = dg;
            AuthorsDG.ItemsSource = App.BOOKS.AUTHORS.ToList();
            PublishersDG.ItemsSource = App.BOOKS.PUBLISHERS.ToList();
            b = book;
        }

        private void isbn_typing(object sender, TextChangedEventArgs e)
        {
            if (newisbn.Text != "")
            {
                //update 06.05 15:41
                newisbn.Text = new Regex(@"[^\d]").Replace(newisbn.Text, "");
                isbnerror.Visibility = Visibility.Collapsed;
            }
        }

        private void name_typing(object sender, TextChangedEventArgs e)
        {
            if (newname.Text != "")
            {
                nameerror.Visibility = Visibility.Collapsed;
            }
        }

        private void year_typing(object sender, TextChangedEventArgs e)
        {
            if (newyear.Text != "")
            {
                //update 06.05 15:41
                newyear.Text = new Regex(@"[^\d]").Replace(newyear.Text, "");
                yearerror.Visibility = Visibility.Collapsed;
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void isbn_validation(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) || newisbn.Text.Length >= 13)
            {
                e.Handled = true;
            }
        }

        private void space_check(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void year_check(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) || newyear.Text.Length >= 4)
            {
                e.Handled = true;
            }
        }
        private void author_search(object sender, TextChangedEventArgs e)
        {
            AuthorsDG.ItemsSource = App.BOOKS.AUTHORS.Where(p => p.AuthorName.Contains(((TextBox)sender).Text)).ToList();
        }

        private void publisher_search(object sender, TextChangedEventArgs e)
        {
            PublishersDG.ItemsSource = App.BOOKS.PUBLISHERS.Where(p => p.PublisherName.Contains(((TextBox)sender).Text)).ToList();
        }

        private void select_author(object sender, RoutedEventArgs e)
        {
            AUTHOR = (AUTHORS)AuthorsDG.SelectedItem;
            author.Text = AUTHOR.AuthorName;
            author.Visibility = Visibility.Visible;
            authorerror.Visibility = Visibility.Collapsed;
        }

        private void select_publisher(object sender, RoutedEventArgs e)
        {
            PUBL = (PUBLISHERS)PublishersDG.SelectedItem;
            publisher.Text = PUBL.PublisherName;
            publisher.Visibility = Visibility.Visible;
            publerror.Visibility = Visibility.Collapsed;
        }

        private void add_book(object sender, RoutedEventArgs e)
        {
            int errors = 0;
            string name = newname.Text;
            string isbn = newisbn.Text;
            string year = newyear.Text;
            int quantity = 0;
            
            if (string.IsNullOrWhiteSpace(name))
            {
                errors++;
                nameerror.Visibility = Visibility.Visible;
            }
            if (isbn == "")
            {
                errors++;
                isbnerror.Text = "Введите ISBN";
                isbnerror.Visibility = Visibility.Visible;
            }
            else
            {
                //update у лакеевой
                if (App.BOOKS.BOOKS.Any(b => b.ISBN == isbn))
                {
                    errors++;
                    isbnerror.Text = "Книга с таким ISBN уже есть в базе";
                    isbnerror.Visibility = Visibility.Visible;
                }
            }
            if (year == "")
            {
                errors++;
                yearerror.Text = "Введите год";
                yearerror.Visibility = Visibility.Visible;
            }
            else if (int.Parse(year) > DateTime.Now.Year)
            {
                errors++;
                yearerror.Text = "Неправильный год";
                yearerror.Visibility = Visibility.Visible;
            }
            if (AUTHOR == null)
            {
                errors++;
                authorerror.Visibility = Visibility.Visible;
            }
            if (PUBL == null)
            {
                errors++;
                publerror.Visibility = Visibility.Visible;
            }
            try
            {
                quantity = int.Parse(newquantity.Text);
            }
            catch
            {
                errors++;
                quantityerror.Visibility = Visibility.Visible;
            }
            if (errors == 0)
            {
                App.BOOKS.BOOKS.Add(new BOOKS { ISBN = isbn, BookName = name, PublDate = int.Parse(year), AuthorID = AUTHOR.AuthorID, PublisherID = PUBL.PublisherID, Quantity = quantity, IsTaken = false });
                App.BOOKS.SaveChanges();
                bdg.ItemsSource = App.BOOKS.BOOKS.ToList();
                b.Text = $"Книги ({bdg.Items.Count})";
                this.Close();
            }
        }

        private void quantity_typing(object sender, TextChangedEventArgs e)
        {
            if (newquantity.Text != "")
            {
                //update 06.05 15:41
                newquantity.Text = new Regex(@"[^\d]").Replace(newquantity.Text, "");
                quantityerror.Visibility = Visibility.Collapsed;
            }
        }

        private void quantity_check(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
