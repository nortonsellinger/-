﻿using System;
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
    /// Логика взаимодействия для EditEmployees.xaml
    /// </summary>
    public partial class EditEmployees : Window
    {
        DataGrid edg;
        EMPLOYEES emp;
        TextBlock emp_name;
        public EditEmployees(DataGrid dg, EMPLOYEES e, TextBlock emp_name)
        {
            InitializeComponent();
            edg = dg;
            emp = e;
            newname.Text = emp.EmployeeName;
            newlogin.Text = emp.ELogin;
            newpass.Text = emp.EPassword;
            this.emp_name = emp_name;
        }

        private void save_employee(object sender, RoutedEventArgs e)
        {
            int errors = 0;
            string name = newname.Text;
            string login = newlogin.Text;
            string pass = newpass.Text;
            if (name == "")
            {
                errors++;
                namelackerror.Visibility = Visibility.Visible;
            }
            else if (String.IsNullOrWhiteSpace(name))
            {
                errors++;
                nameerror.Visibility = Visibility.Visible;
            }
            if (login == "")
            {
                errors++;
                loginlackerror.Visibility = Visibility.Visible;
            }
            if (pass == "")
            {
                errors++;
                passwordlackerror.Visibility = Visibility.Visible;
            }
            if (errors == 0)
            {
                EMPLOYEES empl = App.BOOKS.EMPLOYEES.Find(emp.EmployeeID);
                empl.EmployeeName = name;
                empl.ELogin = login;
                empl.EPassword = pass;
                App.BOOKS.SaveChanges();
                edg.ItemsSource = App.BOOKS.EMPLOYEES.ToList();
                emp_name.Text = name;
                this.Close();
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pass_login_check(object sender, TextCompositionEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Text))
            {
                e.Handled = true;
            }
        }

        private void pass_typing(object sender, TextChangedEventArgs e)
        {
            if (newpass.Text != "")
            {
                passwordlackerror.Visibility = Visibility.Collapsed;
            }
        }

        private void login_typing(object sender, TextChangedEventArgs e)
        {
            if (newlogin.Text != "")
            {
                loginlackerror.Visibility = Visibility.Collapsed;
            }
        }

        private void name_typing(object sender, TextChangedEventArgs e)
        {
            if (newname.Text != "")
            {
                namelackerror.Visibility = Visibility.Collapsed;
            }
        }

        private void name_check(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}