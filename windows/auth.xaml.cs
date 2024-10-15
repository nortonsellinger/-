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
    public partial class auth : Window
    {
        private bool FIRST_LAUNCH = App.BOOKS.EMPLOYEES.Count() == 0;
        private bool PASSWORD_VISIBLE = false;
        public auth()
        {
            InitializeComponent();
            

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
            EMPLOYEES emp = null;
            if (FIRST_LAUNCH)
            {
                string login = LoginBox.Text;
                string password = PasswordBox.Text;
                
                if (login != "" & password != "")
                {
                    string name = "админ";
                    emp = new EMPLOYEES {RoleID = 1, EmployeeName = name, IsWorking = true, ELogin = LoginBox.Text, EPassword = PasswordBox.Text };
                    App.BOOKS.EMPLOYEES.Add(emp);
                    App.BOOKS.SaveChanges();
                }
            }
            else
            {
                emp = App.BOOKS.EMPLOYEES.ToList().Find(u => u.ELogin == LoginBox.Text & u.EPassword == PasswordBox.Text);
            }
            if (emp != null)
            {
                App.EMP = emp;
                BOOKwindow bw = Application.Current.Windows.OfType<BOOKwindow>().FirstOrDefault();
                bw?.Close();
                BOOKwindow cw = new BOOKwindow();
                if (App.WIDTH != null && App.HEIGHT != null && App.LEFT != null && App.TOP != null)
                {
                    cw.Width = (double)App.WIDTH;
                    cw.Height = (double)App.HEIGHT;
                    cw.Left = (double)App.LEFT;
                    cw.Top = (double)App.TOP;
                    cw.WindowStartupLocation = WindowStartupLocation.Manual;
                }
                cw.Show();
                Close();
            }
            else
            {
                MessageBox.Show("неверный логин или пароль");
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

    }
}
