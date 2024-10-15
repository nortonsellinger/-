using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using LIBRARY_lite.pages;

namespace LIBRARY_lite.windows
{
    public partial class BOOKwindow : Window
    {
        public BOOKwindow()
        {
            InitializeComponent();

            emp_name.Text = App.EMP.EmployeeName;
            emp_role.Text = App.BOOKS.ROLES.Find(App.EMP.RoleID).RoleName;


            if (App.EMP.RoleID == 1)
            {
                //emp_name.Visibility = Visibility.Collapsed;
                bl_term_box.Visibility = Visibility.Visible;
                bl_term_block.Visibility = Visibility.Collapsed;
            }
            bl_term_box.Text = bl_term_block.Text = App.BOOKS.info.Single(b => b.InfoKey == "booklend_term").Info1;
        }

        private void open_employees(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Employees))
            {
                frame.Content = new Employees(this, frame);
            }
        }
        private void open_readers(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Readers))
            {
                frame.Content = new Readers(this, frame);
            }
            
        }
        private void open_books(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Books))
            {
                frame.Content = new Books(this, frame);
            }
        }
        private void open_booklend(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is BookLend))
            {
                frame.Content = new BookLend(this, frame);
            }
        }
        private void open_statistics(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Statistics))
            {
                frame.Content = new Statistics(this);
            }
        }

        private void open_authors(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Authors))
            {
                frame.Content = new Authors(this, frame);
            }
        }

        private void open_publishers(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Publishers))
            {
                frame.Content = new Publishers(this, frame);
            }
        }

        private void change_user(object sender, RoutedEventArgs e)
        {
            App.WIDTH = Width;
            App.HEIGHT = Height;
            App.LEFT = Left;
            App.TOP = Top;
            auth a = new auth();
            a.ShowDialog();
        }

        private void open_bookloss(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is BookLoss))
            {
                frame.Content = new BookLoss(this);
            }
        }

        private void open_edit_employee(object sender, RoutedEventArgs e)
        {
            EditEmployees ee = new EditEmployees
            {
                Owner = this
            };
            ee.ShowDialog();
        }

        private void booklend_term_changed(object sender, TextChangedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string text = t.Text;
            try
            {
                int term = int.Parse(text);
                App.BOOKS.info.Single(b => b.InfoKey == "booklend_term").Info1 = term.ToString();
                App.BOOKS.SaveChanges();
            }
            catch
            {

            }
        }

        private void space_check(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void num_check(object sender, TextCompositionEventArgs e)
        {
            TextBox t =  (TextBox)sender;

            if (!char.IsDigit(e.Text, 0) || (t.Text == "" && e.Text == "0"))
            {
                e.Handled = true;
            }
            t.Text = t.Text.Trim('-', ' ');
        }
    }
}
