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
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Window
    {
        private bool FIRST_LAUNCH = App.BOOKS.EMPLOYEES.Count() == 0;
        private bool PASSWORD_VISIBLE = false;
        string PASS_TEXT = "";
        public auth()
        {
            InitializeComponent();
            //MessageBox.Show(App.CROW.EMPLOYEES.ToList()[0].ELogin + " " + App.CROW.EMPLOYEES.ToList()[0].EPassword);
            if (FIRST_LAUNCH)
            {
                FirstLaunchMessage.Visibility = Visibility.Visible;
            }
            else
            {
                FirstLaunchMessage.Visibility = Visibility.Collapsed;
            }
        }

        private void enter(object sender, RoutedEventArgs e)
        {
            if (FIRST_LAUNCH)
            {
                //MessageBox.Show("админ пришел на базу");
                string login = LoginBox.Text;
                string password = PasswordBox.Text;

                if (login != "" & password != "")
                {
                    string name = "админ";
                    App.BOOKS.EMPLOYEES.Add(new EMPLOYEES { EmployeeRole = 1, EmployeeName = name, IsWorking = true });
                    App.BOOKS.SaveChanges();
                    int emp_id = App.BOOKS.EMPLOYEES.Where(em => em.EmployeeName == name).ToList()[0].EmployeeID;
                    App.BOOKS.USERS.Add(new USERS { EmployeeID = emp_id, ULogin = LoginBox.Text, UPassword = PasswordBox.Text });
                    App.BOOKS.SaveChanges();
                    BOOKwindow cw = new BOOKwindow(emp_id);
                    cw.Show();
                    this.Close();
                }
            }
            else
            {
                //MessageBox.Show("админ вернулся на базу");
                USERS user = App.BOOKS.USERS.ToList().Find(u => u.ULogin == LoginBox.Text & u.UPassword == PasswordBox.Text);
                if (user != null)
                {
                    EMPLOYEES emp = App.BOOKS.EMPLOYEES.Where(em => em.EmployeeID == user.EmployeeID).ToList()[0];
                    BOOKwindow cw = new BOOKwindow(emp.EmployeeID);
                    cw.Show();
                    this.Close();
                }
            }
        }

        private void password_visibility(object sender, RoutedEventArgs e)
        {
            if (PASSWORD_VISIBLE)
            {
                HiddenPasswordBox.Foreground = Brushes.Black;
                PasswordBox.Foreground = Brushes.Transparent;
                PassVisible.Content = "Показать";
                PASSWORD_VISIBLE = false;
            }
            else
            {
                HiddenPasswordBox.Foreground = Brushes.Transparent;
                PasswordBox.Foreground = Brushes.Black;
                PassVisible.Content = "Скрыть";
                PASSWORD_VISIBLE = true;
            }
            //if (PASSWORD_VISIBLE)
            //{
            //    PasswordBox.Text = new string('#', PASS_TEXT.Length);
            //}
            //else
            //{
            //    PasswordBox.Text = PASS_TEXT;
            //}

            PasswordBox.Focus();
        }

        private void password_typing(object sender, TextChangedEventArgs e)
        {

            string hidden_pass = "";
            for (int i = 1; i <= PasswordBox.Text.Length; i++)
            {
                hidden_pass += "#";
            }
            HiddenPasswordBox.Text = hidden_pass;
        }

        private void password_preview(object sender, TextCompositionEventArgs e)
        {
            //PASS_TEXT += e.Text;
            if (PasswordBox.Text.Length >= 70)
            { e.Handled = true; }

        }
    }
}
