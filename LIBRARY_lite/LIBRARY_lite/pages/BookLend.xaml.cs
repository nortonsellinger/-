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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LIBRARY_lite.windows;

namespace LIBRARY_lite.pages
{
    /// <summary>
    /// Логика взаимодействия для BookLend.xaml
    /// </summary>
    public partial class BookLend : Page
    {
        Window BOOKSwindow;
        Frame frame;
        public BookLend(Window w, Frame fr)
        {
            InitializeComponent();
            BOOKSwindow = w;
            frame = fr;
            BooksLendDG.ItemsSource = App.BOOKS.BOOKLEND.ToList();
        }

        private void open_add_booklend(object sender, RoutedEventArgs e)
        {
            AddBookLend abl = new AddBookLend(BooksLendDG);
            abl.Owner = BOOKSwindow;
            abl.ShowDialog();
        }
    }
}
