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
            ReadersDG.ItemsSource = App.BOOKS.READERS.ToList();
        }

        private void open_add_readers(object sender, RoutedEventArgs e)
        {
            AddReader ar = new AddReader(ReadersDG);
            ar.Owner = BOOKSwindow;
            ar.ShowDialog();
        }
    }
}
