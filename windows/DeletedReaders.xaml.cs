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
    /// Логика взаимодействия для DeletedReaders.xaml
    /// </summary>
    public partial class DeletedReaders : Window
    {
        DataGrid READERSDG;
        TextBlock quantity;
        public DeletedReaders(DataGrid dg, TextBlock q)
        {
            InitializeComponent();
            READERSDG = dg;
            quantity = q;
            ReadersDG.ItemsSource = App.BOOKS.READERS.Where(r => r.IsReading == false).ToList();
        }

        private void revive_readers(object sender, RoutedEventArgs e)
        {
            READERS reader = App.BOOKS.READERS.Find(((READERS)ReadersDG.SelectedItem).ReaderID);
            reader.IsReading = true;
            App.BOOKS.SaveChanges();
            READERSDG.ItemsSource = App.BOOKS.READERS.Where(r => r.IsReading == true).ToList();
            quantity.Text = $"Читатели ({READERSDG.Items.Count})";
            ReadersDG.ItemsSource = App.BOOKS.READERS.Where(r => r.IsReading == false).ToList();
        }
    }
}