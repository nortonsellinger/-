using LIBRARY_lite.pages;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для DeleteReaders.xaml
    /// </summary>
    public partial class DeleteReaders : Window
    {
        DataGrid rdg;
        List<READERS> rdrs;
        TextBlock quantity;
        public DeleteReaders(DataGrid dg, List<READERS> r, TextBlock q)
        {
            InitializeComponent();
            rdg = dg;
            rdrs = r;
            quantity = q;
            string todelete = "";
            foreach (READERS rdr in rdrs)
            {
                todelete += $"{rdr.ReaderName}, {rdr.BirthDate:d}, {rdr.PhoneNumber}\n";
            }
            rdrstodelete.Text = todelete.Substring(0, todelete.Length - 1);
        }

        private void delete_reader(object sender, RoutedEventArgs e)
        {
            foreach (READERS rdr in rdrs)
            {
                App.BOOKS.READERS.Find(rdr.ReaderID).IsReading = false;
            }
            App.BOOKS.SaveChanges();
            rdg.ItemsSource = null;
            rdg.ItemsSource = App.BOOKS.READERS.Where(r => r.IsReading == true).ToList();
            quantity.Text = $"Читатели ({rdg.Items.Count})";
            this.Close();
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}