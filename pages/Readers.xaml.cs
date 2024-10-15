using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LIBRARY_lite.windows;

namespace LIBRARY_lite.pages
{
    /// <summary>
    /// Логика взаимодействия для Readers.xaml
    /// </summary>
    public partial class Readers : Page
    {
        Window BOOKSwindow;
        Frame frame;
        public Readers(Window w, Frame f)
        {
            InitializeComponent();
            BOOKSwindow = w;
            frame = f;
            List<READERS> rdrs = App.BOOKS.READERS.Where(r => r.IsReading == true).ToList();
            ReadersDG.ItemsSource = rdrs;
            readers_header.Text = $"Читатели ({rdrs.Count})";
        }

        private void open_add_readers(object sender, RoutedEventArgs e)
        {
            AddReader ar = new AddReader(ReadersDG, readers_header);
            ar.Owner = BOOKSwindow;
            ar.ShowDialog();
        }

        private void open_edit_readers(object sender, RoutedEventArgs e)
        {
            EditReader er = new EditReader(ReadersDG, (READERS)ReadersDG.SelectedItem);
            er.Owner = BOOKSwindow;
            er.ShowDialog();
        }

        private void open_delete_readers(object sender, RoutedEventArgs e)
        {
            List<READERS> rdrs = ReadersDG.SelectedItems.Cast<READERS>().ToList();
            if (rdrs.Count != 0)
            {
                DeleteReaders er = new DeleteReaders(ReadersDG, rdrs, readers_header);
                er.Owner = BOOKSwindow;
                er.ShowDialog();
            }
            else
            {
                reader_error.Text = "Выберите читателя для удаления";
                reader_error.Visibility = Visibility.Visible;
            }
        }

        private void reader_select(object sender, SelectionChangedEventArgs e)
        {
            if (ReadersDG.SelectedItems.Count != 0)
            {
                reader_error.Visibility = Visibility.Collapsed;
            }
            
        }

        private void open_inforeader(object sender, RoutedEventArgs e)
        {
            try
            {

                InfoReader ir = new InfoReader((READERS)ReadersDG.SelectedItem);
                ir.Owner = Application.Current.MainWindow;
                ir.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reader_search(object sender, TextChangedEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            ReadersDG.ItemsSource = App.BOOKS.READERS.Where(r => r.IsReading == true && (r.ReaderName.Contains(s) || r.PhoneNumber.Contains(s))).ToList();
            readers_header.Text = $"Читатели ({ReadersDG.Items.Count})";
        }

        private void open_deleted_readers(object sender, RoutedEventArgs e)
        {
            DeletedReaders dr = new DeletedReaders(ReadersDG, readers_header)
            {
                Owner = BOOKSwindow
            };
            dr.ShowDialog();
        }
    }
}
