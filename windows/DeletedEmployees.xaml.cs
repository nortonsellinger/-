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
    /// Логика взаимодействия для DeletedEmployees.xaml
    /// </summary>
    public partial class DeletedEmployees : Window
    {
        DataGrid EDG;
        TextBlock quantity;
        public DeletedEmployees(DataGrid empsdg, TextBlock q)
        {
            InitializeComponent();
            EDG = empsdg;
            quantity = q;
            EmployeesDG.ItemsSource = App.BOOKS.EMPLOYEES.Where(e => e.IsWorking == false).ToList();
        }

        private void revive_employee(object sender, RoutedEventArgs e)
        {
            EMPLOYEES emp = App.BOOKS.EMPLOYEES.Find(((EMPLOYEES)EmployeesDG.SelectedItem).EmployeeID);
            emp.IsWorking = true;
            App.BOOKS.SaveChanges();
            EmployeesDG.ItemsSource = App.BOOKS.EMPLOYEES.Where(em => em.IsWorking == false).ToList();
            EDG.ItemsSource = App.BOOKS.EMPLOYEES.Where(em => em.IsWorking == true && em.RoleID != 1).ToList();
            quantity.Text = $"Сотрудники ({EDG.Items.Count})";
        }
    }
}
