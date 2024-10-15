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
    /// Логика взаимодействия для AddBookLend.xaml
    /// </summary>
    public partial class AddBookLend : Window
    {
        DataGrid ldg;
        //List<string> bookslist = new List<string>();
        List<BOOKS> addedbooks = new List<BOOKS>();
        DateTime LEND_DATE = DateTime.Now;
        DateTime RETURN_DATE = DateTime.Now.AddDays(14);
        READERS READER;
        public AddBookLend(DataGrid dg)
        {
            InitializeComponent();
            ldg = dg;
            //readers.ItemsSource = App.BOOKS.READERS.ToList();
            ReadersDG.ItemsSource = App.BOOKS.READERS.ToList();
            lenddate.Text = LEND_DATE.ToString("d");
            returndate.Text = RETURN_DATE.ToString("d");
            books.ItemsSource = App.BOOKS.BOOKS.Where(b => b.IsTaken == false).ToList();
        }

        private void reader_selected(object sender, SelectionChangedEventArgs e)
        {
            readererror.Visibility = Visibility.Collapsed;
        }

        private void add_book(object sender, RoutedEventArgs e)
        {
            BOOKS book = (BOOKS)books.SelectedItem;
            if (addedbooks.Count < 10 && !addedbooks.Contains(book))
            {
                addedbooks.Add(book);
                bookstogive.ItemsSource = null;
                bookstogive.ItemsSource = addedbooks;
                booklackerror.Visibility = Visibility.Collapsed;
            }
            
            //List <BOOKS> b = books.SelectedItems.Cast<BOOKS>().ToList();
            //if (b.Count != 0)
            //{
            //    if (bookstogive.Items.Count == 10)
            //    {
            //        bookovererror.Visibility = Visibility.Visible;
            //    }
            //    foreach(BOOKS ins in addedbooks)
            //    {
            //        foreach (BOOKS inn in b)
            //        {
            //            if (ins.BookID == inn.BookID)
            //            {
            //                b.Remove(ins);
            //                break;
            //            }
            //        }
            //    }
            //    addedbooks = addedbooks.Concat(b.Take(10 - bookstogive.Items.Count)).ToList();
            //    bookstogive.ItemsSource = addedbooks;
            //    books.SelectedItems.Clear();
            //    booklackerror.Visibility = Visibility.Collapsed;
            //}
            //else
            //{
            //    booklackerror.Visibility = Visibility.Visible;
            //}
        }

        private void remove_book(object sender, RoutedEventArgs e)
        {
            BOOKS b = bookstogive.SelectedItem as BOOKS;
            List<BOOKS> books = bookstogive.Items.Cast<BOOKS>().ToList();
            books.Remove(b);
            bookstogive.ItemsSource = books;
            //List<BOOKS> books = bookstogive.SelectedItems.Cast<BOOKS>().ToList();
            //if (books.Count != 0)
            //{
            //    addedbooks.RemoveAll(b => books.Contains(b));
            //    bookstogive.ItemsSource = null;
            //    bookstogive.ItemsSource = addedbooks;
            //    bookstogivelackerror.Visibility = Visibility.Collapsed;
            //}
            //else
            //{
            //    bookstogivelackerror.Visibility = Visibility.Visible;
            //}
        }

        //private void lend_date_typing(object sender, TextChangedEventArgs e)
        //{
        //    if (((TextBox)sender).Text != "")
        //    {
        //        lenddatelackerror.Visibility = Visibility.Collapsed;
        //    }
            
        //}
        private void space_check(object sender, KeyEventArgs e)
        {

        }

        //private void exp_return_date_typing(object sender, TextChangedEventArgs e)
        //{
        //    if (((TextBox)sender).Text != "")
        //    {
        //        lenddatelackerror.Visibility = Visibility.Collapsed;
        //    }
            
        //}

        private void add_booklend(object sender, RoutedEventArgs e)
        {
            int errors = 0;
            DateTime lend = DateTime.MinValue;
            DateTime ereturn = DateTime.MinValue;
            if (bookstogive.Items.Count == 0)
            {
                errors++;
                booklackerror.Visibility = Visibility.Visible;
            }
            if (ReadersDG.SelectedItem == null)
            {
                errors++;
                readererror.Visibility = Visibility.Visible;
            }
            //if (lenddate.Text != "")
            //{
            //    try
            //    {
            //        lend = DateTime.Parse(lenddate.Text);
            //    }
            //    catch
            //    {
            //        errors++;
            //        lenddateerror.Visibility = Visibility.Visible;
            //    }
            //}
            //else
            //{
            //    errors++;
            //    lenddatelackerror.Visibility = Visibility.Visible;
            //}
            //if (expreturndate.Text != "")
            //{
            //    try
            //    {
            //        ereturn = DateTime.Parse(lenddate.Text);
            //    }
            //    catch
            //    {
            //        errors++;
            //        expreturndateerror.Visibility = Visibility.Visible;
            //    }
            //}
            //else
            //{
            //    errors++;
            //    expreturndatelackerror.Visibility = Visibility.Visible;
            //}
            

            if (errors == 0)
            {
                App.BOOKS.BOOK_SETS.Add(new BOOK_SETS {BookSetName = "a"});
                App.BOOKS.SaveChanges();
                int bsetid = App.BOOKS.BOOK_SETS.ToList().Last().BookSetID;
                foreach (BOOKS b in bookstogive.Items)
                {
                    App.BOOKS.BOOK_SET_CONTENTS.Add(new BOOK_SET_CONTENTS
                    {
                        BookSetID = bsetid,
                        BookID = b.BookID
                    });
                }
                App.BOOKS.SaveChanges();
                App.BOOKS.BOOKLEND.Add(new BOOKLEND { ReaderID = READER.ReaderID, BookSetID = bsetid,
                LendDate = LEND_DATE, ExpReturnDate = RETURN_DATE});
                App.BOOKS.SaveChanges();
                ldg.ItemsSource = App.BOOKS.BOOKLEND.ToList();
                this.Close();
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void book_search(object sender, TextChangedEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            books.ItemsSource = App.BOOKS.BOOKS.Where(b => b.ISBN.Contains(s) || b.BookName.Contains(s)
            || b.AUTHORS.AuthorName.Contains(s) || b.PUBLISHERS.PublisherName.Contains(s) || b.PublDate.ToString().Contains(s)).ToList();
        }

        private void select_reader(object sender, RoutedEventArgs e)
        {
            READER = (READERS)ReadersDG.SelectedItem;
            reader.Text = $"{READER.ReaderName} {READER.BirthDate:d} 8{READER.PhoneNumber}";
            reader.Visibility = Visibility.Visible;
            readererror.Visibility = Visibility.Collapsed;
        }

        private void reader_search(object sender, TextChangedEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            ReadersDG.ItemsSource = App.BOOKS.READERS.Where(r => r.ReaderName.Contains(s) || r.BirthDate.ToString().Contains(s) || r.PhoneNumber.Contains(s)).ToList();
        }

        //private void date_check(object sender, TextCompositionEventArgs e)
        //{

        //}
    }
}