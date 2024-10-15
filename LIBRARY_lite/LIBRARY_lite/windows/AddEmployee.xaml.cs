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
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        DataGrid EmpDG;
        public AddEmployee(DataGrid dg)
        {
            InitializeComponent();
            EmpDG = dg;
        }

        private void add_employee(object sender, RoutedEventArgs e)
        {
            int errors = 0;
            string name = newname.Text;
            string login = newlogin.Text;
            string password = newpassword.Text;
            if (name == "")
            {
                errors++;
                nameerror.Visibility = Visibility.Visible;
            }
            if (login == "")
            {
                errors++;
                loginerror.Visibility = Visibility.Visible;
            }
            if (password == "")
            {
                errors++;
                passworderror.Visibility = Visibility.Visible;
            }
            if (errors == 0)
            {
                App.BOOKS.EMPLOYEES.Add(new EMPLOYEES { EmployeeName = name, RoleID = 2, ELogin = login, EPassword = password, IsWorking = true});
                App.BOOKS.SaveChanges();
                //EmpDG.ItemsSource = null;
                EmpDG.ItemsSource = App.BOOKS.EMPLOYEES.Where(em => em.IsWorking == true).ToList();
                this.Close();
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void name_typing(object sender, TextChangedEventArgs e)
        {
            nameerror.Visibility = Visibility.Collapsed;
        }

        private void password_typing(object sender, TextChangedEventArgs e)
        {
            passworderror.Visibility = Visibility.Collapsed;
        }

        private void login_typing(object sender, TextChangedEventArgs e)
        {
            loginerror.Visibility = Visibility.Collapsed;
        }
    }
}
