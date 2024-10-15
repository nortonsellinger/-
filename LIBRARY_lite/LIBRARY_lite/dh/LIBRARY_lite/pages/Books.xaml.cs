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
			new AddBook().ShowDialog();
		}
	}
}
