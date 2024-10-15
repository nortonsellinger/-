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
                App.BOOKS.EMPLOYEES.Add(new EMPLOYEES { EmployeeName = name, EmployeeRole = 2});
                App.BOOKS.SaveChanges();
                App.BOOKS.USERS.Add(new USERS { EmployeeID = App.BOOKS.EMPLOYEES.ToList().LastOrDefault().EmployeeID, ULogin = login, UPassword = password});
                App.BOOKS.SaveChanges();
                EmpDG.ItemsSource = null;
                EmpDG.ItemsSource = App.BOOKS.EMPLOYEES.Join(App.BOOKS.USERS, emp => emp.EmployeeID, user => user.EmployeeID, (emp, user) => new
                {
                    //EmpId = emp.EmployeeID,
                    EmployeeName = emp.EmployeeName,
                    ULogin = user.ULogin,
                    UPassword = user.UPassword,
                    EmployeeRole = emp.EmployeeRole
                }).Join(App.BOOKS.ROLES, emp => emp.EmployeeRole, role => role.RoleID,
                    (emp, role) => new
                    {
                        EmployeeName = emp.EmployeeName,
                        RoleName = role.RoleName,
                        ULogin = emp.ULogin,
                        UPassword = emp.UPassword,
                    }).ToList();
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
