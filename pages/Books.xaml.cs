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
	/// Логика взаимодействия для Books.xaml
	/// </summary>
	public partial class Books : Page
	{
		Window BOOKSwindow;
		Frame frame;
        int START = 1753;
        int END = DateTime.Now.Year;
		public Books(Window w, Frame f)
		{
			InitializeComponent();
			BOOKSwindow = w;
			frame = f;
            List<BOOKS> b = App.BOOKS.BOOKS.ToList();
            BooksDG.ItemsSource = b;
            book_header.Text = $"Книги ({b.Count})";
        }

		private void open_add_books(object sender, RoutedEventArgs e)
		{
            AddBook ab = new AddBook(BooksDG, book_header)
            {
                Owner = BOOKSwindow
            };
            ab.ShowDialog();
		}

        private void edit_book(object sender, RoutedEventArgs e)
        {
            EditBook eb = new EditBook(BooksDG, (BOOKS)BooksDG.SelectedItem);
            eb.Owner = BOOKSwindow;
            eb.ShowDialog();
        }

        private void year_search(object sender, TextChangedEventArgs e)
        {
            if (year_start.Text != "")
            {
                try
                {
                    int s = int.Parse(year_start.Text);
                    if (s >= 1753)
                    {
                        START = s;
                    }
                }
                catch { }
            }
            else
            {
                START = 1753;
            }
            if (year_end.Text != "")
            {
                try
                {
                    int end = int.Parse(year_end.Text);
                    if (end >= START)
                    {
                        END = end;
                    }
                }
                catch { }
            }
            else
            {
                END = DateTime.Now.Year;
            }
            BooksDG.ItemsSource = App.BOOKS.BOOKS.Where(b => b.PublDate >= START && b.PublDate <= END).ToList();
            book_header.Text = $"Книги ({BooksDG.Items.Count})";
        }

        private void year_check(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
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

        private void search(object sender, TextChangedEventArgs e)
        {
            string i = search_s.Text;
            BooksDG.ItemsSource = App.BOOKS.BOOKS.Where(b => b.ISBN.Contains(i) || b.BookName.Contains(i) || b.AUTHORS.AuthorName.Contains(i)
            || b.PUBLISHERS.PublisherName.Contains(i)).ToList();
            book_header.Text = $"Книги ({BooksDG.Items.Count})";
        }
    }
}
