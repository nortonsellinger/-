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
		public Books(Window w, Frame f)
		{
			InitializeComponent();
			BOOKSwindow = w;
			frame = f;
			BooksDG.ItemsSource = App.BOOKS.BOOKS.ToList();
        }

		private void open_add_books(object sender, RoutedEventArgs e)
		{
			new AddBook(BooksDG).ShowDialog();
		}

        private void edit_book(object sender, RoutedEventArgs e)
        {
            EditBook eb = new EditBook(BooksDG, (BOOKS)BooksDG.SelectedItem);
            eb.Owner = BOOKSwindow;
            eb.ShowDialog();
            //var selbook = BooksDG.SelectedItems;
            //if (selbook.Count != 0)
            //{
            //    if (selbook.Count == 1)
            //    {
            //        EditBook eb = new EditBook(BooksDG, (BOOKS)BooksDG.SelectedItem);
            //        eb.Owner = BOOKSwindow;
            //        eb.ShowDialog();
            //    }
            //    else
            //    {
            //        bookerror.Text = "Выберите только одну книгу";
            //        bookerror.Visibility = Visibility.Visible;
            //    }
            //}
            //else
            //{
            //    bookerror.Text = "Выберите книгу для редактирования";
            //    bookerror.Visibility = Visibility.Visible;
            //}
        }
        private void book_select(object sender, SelectionChangedEventArgs e)
        {
			bookerror.Visibility = Visibility.Collapsed;
        }

        //private void edit_instance(object sender, RoutedEventArgs e)
        //{

        //}
        //private void open_add_instances(object sender, RoutedEventArgs e)
        //{

        //}
        //private void instance_select(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}
