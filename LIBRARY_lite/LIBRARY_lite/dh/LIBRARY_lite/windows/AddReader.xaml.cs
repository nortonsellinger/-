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
    /// Логика взаимодействия для AddReader.xaml
    /// </summary>
    public partial class AddReader : Window
    {
        DataGrid rdg;
        public AddReader(DataGrid dg)
        {
            InitializeComponent();
            rdg = dg;
        }

        private void add_reader(object sender, RoutedEventArgs e)
        {
            int errors = 0;
            string name = newname.Text;
            string birth = newbirth.Text;
            string phone = newphone.Text;
            DateTime birthdate = DateTime.MinValue;
            if (name == "")
            {
                errors++;
                nameerror.Visibility = Visibility.Visible;
            }
            if (birth == "")
            {
                errors++;
                birtherror.Visibility = Visibility.Visible;
            }
            else
            {
                try
                {
                    birthdate = DateTime.Parse(newbirth.Text);
                }
                catch
                {
                    errors++;
                }
            }
            if (phone == "")
            {
                errors++;
                phoneerror.Visibility = Visibility.Visible;
            }
            else if (phone.Length > 11)
            {
                newphone.Text = newphone.Text.Trim();
            }
            if (errors == 0)
            {
                App.BOOKS.READERS.Add(new READERS { ReaderName = name, BirthDate = birthdate, PhoneNumber = phone});
                App.BOOKS.SaveChanges();
                rdg.ItemsSource = null;
                rdg.ItemsSource = App.BOOKS.READERS.ToList();
                this.Close();
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void phone_typing(object sender, TextChangedEventArgs e)
        {
            if (newphone.Text != "")
            {
                phoneerror.Visibility = Visibility.Collapsed;
            }
        }

        private void birth_typing(object sender, TextChangedEventArgs e)
        {
            if (newbirth.Text != "")
            {
                birtherror.Visibility = Visibility.Collapsed;
            }
        }

        private void name_typing(object sender, TextChangedEventArgs e)
        {
            if (newname.Text != "")
            {
                nameerror.Visibility = Visibility.Collapsed;
            }
        }

        private void phone_typing_check(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) || newphone.Text.Length >= 11)
            {
                e.Handled = true;
            }
        }

        private void whitespace_check(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}