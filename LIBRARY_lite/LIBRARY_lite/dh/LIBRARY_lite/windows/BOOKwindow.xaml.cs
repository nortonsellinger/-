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
using LIBRARY_lite.pages;

namespace LIBRARY_lite.windows
{
    /// <summary>
    /// Логика взаимодействия для BOOKwindow.xaml
    /// </summary>
    public partial class BOOKwindow : Window
    {
        public BOOKwindow(int EMP_ID)
        {
            InitializeComponent();
        }

        private void open_employees(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Employees))
            {
                frame.Content = new Employees(this, frame);
            }
            
        }
        private void open_readers(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Readers))
            {
                frame.Content = new Readers(this, frame);
            }
            
        }
        private void open_books(object sender, RoutedEventArgs e)
        {
            if (!(frame.Content is Books))
            {
                frame.Content = new Books(this, frame);
            }
        }
        private void open_booklend(object sender, RoutedEventArgs e)
        {

        }
        private void open_statistics(object sender, RoutedEventArgs e)
        {

        }
    }
}
