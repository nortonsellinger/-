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
            ReadersDG.ItemsSource = App.BOOKS.READERS.Where(r => r.IsReading == true).ToList();
        }

        private void open_add_readers(object sender, RoutedEventArgs e)
        {
            AddReader ar = new AddReader(ReadersDG);
            ar.Owner = BOOKSwindow;
            ar.ShowDialog();
        }

        private void open_edit_readers(object sender, RoutedEventArgs e)
        {
            EditReader er = new EditReader(ReadersDG, (READERS)ReadersDG.SelectedItem);
            er.Owner = BOOKSwindow;
            er.ShowDialog();
            //var selred = ReadersDG.SelectedItems;
            //if (selred.Count != 0)
            //{
            //    if (selred.Count == 1)
            //    {
            //        EditReader er = new EditReader(ReadersDG, (READERS)ReadersDG.SelectedItem);
            //        er.Owner = BOOKSwindow;
            //        er.ShowDialog();
            //    }
            //    else
            //    {
            //        reader_error.Text = "Выберите только одного читателя";
            //        reader_error.Visibility = Visibility.Visible;
            //    }
            //}
            //else
            //{
            //    reader_error.Text = "Выберите читателя для редактирования";
            //    reader_error.Visibility = Visibility.Visible;
            //}
        }

        private void open_delete_readers(object sender, RoutedEventArgs e)
        {
            List<READERS> rdrs = ReadersDG.SelectedItems.Cast<READERS>().ToList();
            if (rdrs.Count != 0)
            {
                DeleteReaders er = new DeleteReaders(ReadersDG, rdrs);
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
    }
}
