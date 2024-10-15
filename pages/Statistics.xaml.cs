using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
	/// Логика взаимодействия для Statistics.xaml
	/// </summary>
	public partial class Statistics : Page
	{
		Window BOOKSwindow;
		int book_q = 10;
        int reader_q = 10;
        int emp_q = 10;
        DateTime start = DateTime.Parse("01.01.1990");
		DateTime end = DateTime.Now;
		public Statistics(Window w)
		{
            InitializeComponent();
			BOOKSwindow = w;
			set_books_source();
			set_readers_source();
			set_emps_source();
		}
		public bool dates_check ()
		{
			try
			{
				DateTime start = DateTime.Parse(date_start.Text);
				DateTime end = DateTime.Parse(date_end.Text);
				if (start.Year >= 1753 & end.Year >= 1753)
				{
					if (start < end)
					{
                        this.start = start;
                        this.end = end;
                    }
					else
					{
                        this.start = end;
                        this.end = start;
                    }
					return true;
				}
				else
				{
					return false;
				}
			}
			catch
			{
				return false;
			}
		}
		public void set_books_source ()
		{
			BooksDG.ItemsSource = App.BOOKS.BOOK_SET_CONTENTS.Where(b => b.BOOK_SETS.BOOKLEND.ToList().FirstOrDefault().LendDate > start && b.BOOK_SETS.BOOKLEND.ToList().FirstOrDefault().LendDate < end).GroupBy(em => em.BOOKS).OrderByDescending(g => g.Count()).Take(book_q).Select(g => g.Key).ToList();
		}
		public void set_readers_source()
		{
            ReadersDG.ItemsSource = App.BOOKS.BOOKLEND.Where(b => b.LendDate > start && b.LendDate < end).GroupBy(em => em.READERS).OrderByDescending(g => g.Count()).Take(reader_q).Select(g => g.Key).ToList();
        }
		public void set_emps_source()
		{
            EmployeesDG.ItemsSource = App.BOOKS.BOOKLEND.Where(b => b.LendDate > start && b.LendDate < end).GroupBy(em => em.EMPLOYEES).OrderByDescending(g => g.Count()).Take(emp_q).Select(g => g.Key).ToList();
        }
		private void week(object sender, RoutedEventArgs e)
		{
			start = DateTime.Now.AddDays(-7);
			end = DateTime.Now;
            set_books_source();
            set_readers_source();
            set_emps_source();
        }

		private void month(object sender, RoutedEventArgs e)
		{
            start = DateTime.Now.AddMonths(-1);
            end = DateTime.Now;
            set_books_source();
            set_readers_source();
            set_emps_source();
        }

		private void year(object sender, RoutedEventArgs e)
		{
            start = DateTime.Now.AddYears(-1);
            end = DateTime.Now;
            set_books_source();
            set_readers_source();
            set_emps_source();
        }

		private void alltime(object sender, RoutedEventArgs e)
		{
            start = DateTime.Parse("01.01.1900");
            end = DateTime.Now;
            set_books_source();
            set_readers_source();
            set_emps_source();
        }
        private void custom_period(object sender, RoutedEventArgs e)
        {
			if (dates_check())
			{
                set_books_source();
                set_readers_source();
                set_emps_source();
            }
        }
        private void quantity_check(object sender, TextCompositionEventArgs e)
		{
			if (!char.IsDigit(e.Text, 0))
			{
				e.Handled = true;
			}
		}

		private void book_quantity_changed(object sender, TextChangedEventArgs e)
		{
			string q = ((TextBox)sender).Text;
            if (q != "")
			{
                book_q = int.Parse(q);
            }
			else
			{
				book_q = 10;
			}
            set_books_source();
            set_readers_source();
            set_emps_source();
        }

		private void reader_quantity_changed(object sender, TextChangedEventArgs e)
		{
            string q = ((TextBox)sender).Text;
            if (q != "")
            {
                reader_q = int.Parse(q);
            }
            else
            {
                reader_q = 10;
            }
            set_books_source();
            set_readers_source();
            set_emps_source();
        }

		private void emp_quantity_changed(object sender, TextChangedEventArgs e)
		{
            string q = ((TextBox)sender).Text;
            if (q != "")
            {
                emp_q = int.Parse(q);
            }
            else
            {
                emp_q = 10;
            }
            set_books_source();
            set_readers_source();
            set_emps_source();
        }

		private void space_check(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Space)
			{
				e.Handled = true;
			}
		}

        private void date_check(object sender, TextCompositionEventArgs e)
        {
			if (!char.IsDigit(e.Text, 0) && e.Text != ".")
			{
				e.Handled = true;
			}
        }
    }
}
