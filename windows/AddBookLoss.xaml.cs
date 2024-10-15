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
	/// Логика взаимодействия для AddBookLoss.xaml
	/// </summary>
	public partial class AddBookLoss : Window
	{
		DataGrid ldg;
		//List<string> bookslist = new List<string>();
		//List<BOOKS> returnedbooks = new List<BOOKS>();
		List<BOOK_SET_CONTENTS> GIVEN = new List<BOOK_SET_CONTENTS>();
		List<BOOK_SET_CONTENTS> LOST = new List<BOOK_SET_CONTENTS>();
		DateTime LEND_DATE;
		DateTime EXP_RETURN;
		READERS READER;
		BOOKLEND booklend;
		public AddBookLoss(DataGrid dg, BOOKLEND bl)
		{
			InitializeComponent();
			ldg = dg;
			booklend = bl;
			LEND_DATE = booklend.LendDate;
			EXP_RETURN = booklend.ExpReturnDate;
			lenddate.Text = LEND_DATE.ToString("d");
			READER = bl.READERS;
			reader.Text = READER.ReaderName;
			GIVEN = booklend.BOOK_SETS.BOOK_SET_CONTENTS.Where(bsc => bsc.ReturnDate == null & bsc.IsLost == false).ToList();
			givenbooks.ItemsSource = GIVEN;
		}
		private void cancel(object sender, RoutedEventArgs e)
		{
			Close();
		}
		private void lose_book(object sender, RoutedEventArgs e)
		{
			BOOK_SET_CONTENTS bsc = (BOOK_SET_CONTENTS)givenbooks.SelectedItem;
			LOST.Add(bsc);
			GIVEN.Remove(bsc);
			lostbooks.ItemsSource = null;
			lostbooks.ItemsSource = LOST;
			givenbooks.ItemsSource = null;
			givenbooks.ItemsSource = GIVEN;
		}

		private void cancel_lose_book(object sender, RoutedEventArgs e)
		{
			BOOK_SET_CONTENTS bsc = (BOOK_SET_CONTENTS)lostbooks.SelectedItem;
			GIVEN.Add(bsc);
			LOST.Remove(bsc);
			lostbooks.ItemsSource = null;
			lostbooks.ItemsSource = LOST;
			givenbooks.ItemsSource = null;
			givenbooks.ItemsSource = GIVEN;
		}

		private void save_bookloss(object sender, RoutedEventArgs e)
		{
            BOOKLEND bkl = App.BOOKS.BOOKLEND.Find(booklend.BookLendID);
            List<BOOK_SET_CONTENTS> bscontents = App.BOOKS.BOOK_SET_CONTENTS.Where(bsc => bsc.BookSetID == booklend.BookSetID).ToList();

            foreach (BOOK_SET_CONTENTS bsc in LOST)
            {
                BOOK_SET_CONTENTS booksc = bscontents.Find(b => b.BookSetContentID == bsc.BookSetContentID);
                booksc.IsLost = true;
				booksc.ReturnDate = DateTime.Now;
                booksc.EmployeeID = App.EMP.EmployeeID;
                App.BOOKS.BOOKS.Find(booksc.BOOKS.BookID).Quantity--;
                App.BOOKS.LOST_BOOKS.Add(new LOST_BOOKS
                {
                    BookID = booksc.BookID,
                    ReaderID = booklend.ReaderID,
                    LossDate = DateTime.Now,
                    EmployeeID = App.EMP.EmployeeID,
					//BookLendID = bkl.BookLendID
                });
            }
			if (GIVEN.Count == 0)
			{
				bkl.ActualReturnDate = DateTime.Now;
			}
            App.BOOKS.SaveChanges();
            ldg.ItemsSource = null;
            ldg.ItemsSource = App.BOOKS.BOOKLEND.ToList();
            this.Close();
        }
	}
}
