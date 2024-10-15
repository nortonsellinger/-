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
    public partial class BookLoss : Page
    {
        Window BOOKSwindow;
        DateTime start = DateTime.Parse("01.01.1990");
        DateTime end = DateTime.Now;
        public BookLoss(Window w)
        {
            InitializeComponent();
            BOOKSwindow = w;
            List<LOST_BOOKS> l = App.BOOKS.LOST_BOOKS.OrderByDescending(lb => lb.LossDate).ToList();
            BookLossDG.ItemsSource = l;
            loss_header.Text = $"Утеря ({l.Count})";
        }

        private void loss_search(object sender, TextChangedEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            BookLossDG.ItemsSource = App.BOOKS.LOST_BOOKS.Where(l => l.BOOKS.BookName.Contains(s)
            || l.BOOKS.ISBN.Contains(s) || l.BOOKS.PublDate.ToString().Contains(s) || l.BOOKS.AUTHORS.AuthorName.Contains(s)
            || l.BOOKS.PUBLISHERS.PublisherName.Contains(s) || l.READERS.ReaderName.Contains(s) || l.EMPLOYEES.EmployeeName.Contains(s)).ToList();
            loss_header.Text = $"Утеря ({BookLossDG.Items.Count})";
        }
        public bool dates_check()
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
        private void date_search(object sender, RoutedEventArgs e)
        {
            if (dates_check())
            {
                BookLossDG.ItemsSource = App.BOOKS.LOST_BOOKS.Where(l => l.LossDate > start && l.LossDate < end).ToList();
                loss_header.Text = $"Утеря ({BookLossDG.Items.Count})";
            }
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

        private void alltime(object sender, RoutedEventArgs e)
        {
            BookLossDG.ItemsSource = App.BOOKS.LOST_BOOKS.ToList();
        }

        //private void show_booklend(object sender, RoutedEventArgs e)
        //{
        //    ShowLostBooklend slb = new ShowLostBooklend(((LOST_BOOKS)BookLossDG.SelectedItem).BOOKLEND)
        //    {
        //        Owner = BOOKSwindow
        //    };
        //    slb.ShowDialog();
        //}
    }
}