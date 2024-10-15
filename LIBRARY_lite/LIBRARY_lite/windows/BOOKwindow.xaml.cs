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
using LIBRARY_lite.pages;

namespace LIBRARY_lite.windows
{
    /// <summary>
    /// Логика взаимодействия для BOOKwindow.xaml
    /// </summary>
    public partial class BOOKwindow : Window
    {
        EMPLOYEES EMPLOYEE;
        public BOOKwindow(EMPLOYEES e)
        {
            InitializeComponent();
            EMPLOYEE = e;
            emp_name.Text = EMPLOYEE.EmployeeName;
            emp_role.Text = EMPLOYEE.ROLES.RoleName;
        }

        private void open_employees(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Employees))
            {
                frame.Content = new Employees(this, frame, emp_name);
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
            auth a = new auth();
            //a.Owner = this;
            a.ShowDialog();
        }

        private void open_bookloss(object sender, RoutedEventArgs e)
        {

        }
    }
}
