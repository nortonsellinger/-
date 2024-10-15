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
    /// Логика взаимодействия для EditReader.xaml
    /// </summary>
    public partial class EditReader : Window
    {
        DataGrid rdg;
        READERS READER;
        public EditReader(DataGrid dg, READERS rd)
        {
            InitializeComponent();
            rdg = dg;
            READER = rd;
            newname.Text = READER.ReaderName;
            newbirth.Text = ((DateTime)READER.BirthDate).ToString("d");
            newphone.Text = READER.PhoneNumber.Substring(1, READER.PhoneNumber.Length - 1);
        }

        private void name_typing(object sender, TextChangedEventArgs e)
        {
            if (newname.Text != "")
            {
                nameerror.Visibility = Visibility.Collapsed;
            }
        }

        private void name_check(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void birth_check(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                if (e.Text != ".")
                {
                    e.Handled = true;
                }
            }
        }

        private void birth_typing(object sender, TextChangedEventArgs e)
        {
            if (newbirth.Text != "")
            {
                birthlackerror.Visibility = Visibility.Collapsed;
            }
        }

        private void phone_typing_check(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0) || String.IsNullOrWhiteSpace(e.Text))
            {
                e.Handled = true;
            }
        }

        private void phone_typing(object sender, TextChangedEventArgs e)
        {
            if (newphone.Text != "")
            {
                phonelackerror.Visibility = Visibility.Collapsed;
                if (newphone.Text.Length == 10)
                {
                    phoneerror.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void save_reader(object sender, RoutedEventArgs e)
        {
            int errors = 0;
            string name = newname.Text;
            string birth = newbirth.Text;
            string phone = newphone.Text;
            DateTime birthdate = DateTime.MinValue;
            if (String.IsNullOrWhiteSpace(name))
            {
                errors++;
                nameerror.Visibility = Visibility.Visible;
            }
            if (String.IsNullOrWhiteSpace(birth))
            {
                errors++;
                birthlackerror.Visibility = Visibility.Visible;
            }
            else
            {
                try
                {
                    birthdate = DateTime.Parse(birth);
                    string year = birth.Split('.')[2];
                    int y = int.Parse(year);
                    if (y < 1900)
                    {
                        errors++;
                        birtherror.Visibility = Visibility.Visible;
                    }
                }
                catch
                {
                    errors++;
                    birtherror.Visibility = Visibility.Visible;
                }
                finally
                {
                    
                }
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                errors++;
                phonelackerror.Visibility = Visibility.Visible;
            }
            else if (phone.Length < 10)
            {
                errors++;
                phoneerror.Visibility = Visibility.Visible;
            }
            if (errors == 0)
            {
                READERS rdr = App.BOOKS.READERS.Find(READER.ReaderID);
                rdr.ReaderName = name;
                rdr.BirthDate = birthdate;
                rdr.PhoneNumber = "8" + phone;
                App.BOOKS.SaveChanges();
                rdg.ItemsSource = null;
                rdg.ItemsSource = App.BOOKS.READERS.Where(r => r.IsReading == true).ToList();
                this.Close();
            }
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void space_check(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}
