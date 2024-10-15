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
    /// Логика взаимодействия для InfoReader.xaml
    /// </summary>
    public partial class InfoReader : Window
    {
        READERS READER;
        public InfoReader(READERS r)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            READER = r;
            reader.Text = $"{r.ReaderName} | {r.BirthDate:d} | 8{r.PhoneNumber}";
            BookLendDG.ItemsSource = App.BOOKS.BOOKLEND.Where(bl => bl.ReaderID == READER.ReaderID).ToList();
        }
    }
}
