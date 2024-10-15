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
using LIBRARY_lite.windows;

namespace LIBRARY_lite.pages
{
	public partial class BookLend : Page
	{
		Window BOOKSwindow;
		Frame frame;
		int scroll;
		DateTime START = DateTime.Parse("01.01.1990");
		DateTime END = DateTime.Now;
		string s = "";
		bool count_lost = false;
		List<BOOKLEND> booklend = new List<BOOKLEND>();
		int filter = 0;
		public BookLend(Window w, Frame fr)
		{
			InitializeComponent();
			BOOKSwindow = w;
			frame = fr;
			booklend = App.BOOKS.BOOKLEND.OrderByDescending(bl => bl.LendDate).ToList();
			BooksLendDG.ItemsSource = booklend;
			lend_header.Text = $"Выдача ({booklend.Count})";

			if (App.EMP.RoleID == 1)
			{
				add_button.Visibility = Visibility.Collapsed;
				BooksLendDG.Columns[BooksLendDG.Columns.Count - 1].Visibility = Visibility.Collapsed;
			}
		}

		private void open_add_booklend(object sender, RoutedEventArgs e)
		{
			AddBookLend abl = new AddBookLend(BooksLendDG, lend_header);
			abl.Owner = BOOKSwindow;
			abl.ShowDialog();
		}

		private void edit_booklend(object sender, RoutedEventArgs e)
		{
			EditBookLend abl = new EditBookLend(BooksLendDG, (BOOKLEND)BooksLendDG.SelectedItem);
			abl.Owner = BOOKSwindow;
			abl.ShowDialog();
		}

		private void open_lost_book(object sender, RoutedEventArgs e)
		{
			AddBookLoss abl = new AddBookLoss(BooksLendDG, (BOOKLEND)BooksLendDG.SelectedItem);
			abl.Owner = BOOKSwindow;
			abl.ShowDialog();
		}

		private void display_booklists(object sender, RoutedEventArgs e)
		{
			Button b = (Button)sender;
			if (BooksLendDG.Columns[4].Visibility == Visibility.Visible)
			{
				BooksLendDG.Columns[4].Visibility = Visibility.Collapsed;
				scroll_datagrid();
				b.Content = "Показать список книг";
			}
			else
			{
				BooksLendDG.Columns[4].Visibility = Visibility.Visible;
				scroll_datagrid();
				b.Content = "Скрыть список книг";
			}
		}
		private void date_search(object sender, TextChangedEventArgs e)
		{
			if (date_start.Text != "")
			{
				try
				{
					DateTime d = DateTime.Parse(date_start.Text);
					if (d.Year >= 1753)
					{
						START = d;
					}
				}
				catch { }
			}
			else
			{
				START = DateTime.Parse("01.01.1990");
			}
			if (date_end.Text != "")
			{
				try
				{
					DateTime d = DateTime.Parse(date_end.Text);
					if (d >= START)
					{
						END = d;
					}
				}
				catch { }
			}
			else
			{
				END = DateTime.Now;
			}
			booklend = App.BOOKS.BOOKLEND.Where(b => b.LendDate >= START && b.LendDate <= END).ToList();
			BooksLendDG.ItemsSource = booklend;
			lend_header.Text = $"Выдача ({BooksLendDG.Items.Count})";
		}

		private void loading_row(object sender, DataGridRowEventArgs e)
		{
			scroll = e.Row.GetIndex();
		}
		public void scroll_datagrid()
		{
			if (scroll >= 0 && scroll < BooksLendDG.Items.Count)
			{
				BooksLendDG.ScrollIntoView(BooksLendDG.Items[scroll]);
			}
		}
		private void booklend_select(object sender, SelectionChangedEventArgs e)
		{
			scroll = ((DataGrid)sender).SelectedIndex;
		}
		private void search(object sender, TextChangedEventArgs e)
		{
			s = search_s.Text;
			switch (filter)
			{
				case 0:
					{
						if (!string.IsNullOrWhiteSpace(s))
						{
							booklend = App.BOOKS.BOOKLEND.Where(l => (l.READERS.ReaderName.Contains(s)
							|| l.EMPLOYEES.EmployeeName.Contains(s)) && l.LendDate >= START && l.LendDate <= END).ToList();
						}
						else
						{
							booklend = App.BOOKS.BOOKLEND.Where(b => b.LendDate >= START && b.LendDate <= END).ToList();
						}
						break;
					}
				case 1:
					{
						if (!string.IsNullOrWhiteSpace(s))
						{
							booklend = App.BOOKS.BOOKLEND.Where(l => (l.READERS.ReaderName.Contains(s)
							|| l.EMPLOYEES.EmployeeName.Contains(s)) && l.LendDate >= START && l.LendDate <= END
							&& l.ActualReturnDate == null).ToList();
						}
						else
						{
							booklend = App.BOOKS.BOOKLEND.Where(b => b.LendDate >= START && b.LendDate <= END
							&& b.ActualReturnDate == null).ToList();
						}
						break;
					}
				case 2:
					{
						if (!string.IsNullOrWhiteSpace(s))
						{
							booklend = App.BOOKS.BOOKLEND.Where(l => (l.READERS.ReaderName.Contains(s)
							|| l.EMPLOYEES.EmployeeName.Contains(s)) && l.LendDate >= START && l.LendDate <= END
							&& l.ActualReturnDate != null).ToList();
						}
						else
						{
							booklend = App.BOOKS.BOOKLEND.Where(b => b.LendDate >= START && b.LendDate <= END
							&& b.ActualReturnDate != null).ToList();
						}
						break;
					}
			}
			
			BooksLendDG.ItemsSource = null;
			BooksLendDG.ItemsSource = booklend;
			lend_header.Text = $"Выдача ({BooksLendDG.Items.Count})";
		}
		private void date_check(object sender, TextCompositionEventArgs e)
		{
			if (!char.IsDigit(e.Text, 0) && e.Text != ".")
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

		private void display_all(object sender, RoutedEventArgs e)
		{
			if (filter != 0)
			{
                filter = 0;
                all_button.BorderBrush = Brushes.Black;
                taken_button.BorderBrush = Brushes.Transparent;
                returned_button.BorderBrush = Brushes.Transparent;
                booklend = App.BOOKS.BOOKLEND.Where(l => (l.READERS.ReaderName.Contains(s) || l.EMPLOYEES.EmployeeName.Contains(s)) && l.LendDate >= START
                && l.LendDate <= END).ToList();
                BooksLendDG.ItemsSource = null;
                BooksLendDG.ItemsSource = booklend;
                lend_header.Text = $"Выдача ({BooksLendDG.Items.Count})";
            }
		}

		private void display_taken(object sender, RoutedEventArgs e)
		{
			if (filter != 1)
			{
                filter = 1;
                taken_button.BorderBrush = Brushes.Red;
                all_button.BorderBrush = Brushes.Transparent;
                returned_button.BorderBrush = Brushes.Transparent;
                booklend = App.BOOKS.BOOKLEND.Where(l => (l.READERS.ReaderName.Contains(s) || l.EMPLOYEES.EmployeeName.Contains(s)) && l.ActualReturnDate == null
                && l.LendDate >= START && l.LendDate <= END).ToList();
                BooksLendDG.ItemsSource = null;
                BooksLendDG.ItemsSource = booklend;
                lend_header.Text = $"Выдача ({BooksLendDG.Items.Count})";
            }
		}

		private void display_returned(object sender, RoutedEventArgs e)
		{
			if (filter != 2)
			{
                filter = 2;
                returned_button.BorderBrush = Brushes.Green;
                taken_button.BorderBrush = Brushes.Transparent;
                all_button.BorderBrush = Brushes.Transparent;
                booklend = App.BOOKS.BOOKLEND.Where(l => (l.READERS.ReaderName.Contains(s) || l.EMPLOYEES.EmployeeName.Contains(s))
                && l.ActualReturnDate != null && l.LendDate >= START && l.LendDate <= END).ToList();
                BooksLendDG.ItemsSource = null;
                BooksLendDG.ItemsSource = booklend;
                lend_header.Text = $"Выдача ({BooksLendDG.Items.Count})";
            }
		}

		private void alltime(object sender, RoutedEventArgs e)
		{
			booklend = App.BOOKS.BOOKLEND.Where(bl => (bl.READERS.ReaderName.Contains(s) || bl.EMPLOYEES.EmployeeName.Contains(s))
			&& bl.ActualReturnDate != null && bl.LendDate >= START && bl.LendDate <= END).ToList();
			BooksLendDG.ItemsSource = null;
			BooksLendDG.ItemsSource = booklend;
			lend_header.Text = $"Выдача ({BooksLendDG.Items.Count})";
		}
	}
}