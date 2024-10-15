using LIBRARY_lite.windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIBRARY_lite.pages
{
	/// <summary>
	/// Логика взаимодействия для Employees.xaml
	/// </summary>
	public partial class Employees : Page
	{
		Frame frame;
		Window BooksWindow;
        public Employees(Window BW, Frame f)
		{
			InitializeComponent();
			frame = f;
			BooksWindow = BW;
            List<EMPLOYEES> emps = App.BOOKS.EMPLOYEES.Where(em => em.IsWorking == true && em.RoleID != 1 && em.EmployeeID != App.EMP.EmployeeID).ToList();
            EmployeesDG.ItemsSource = emps;
            emps_header.Text = $"Сотрудники ({emps.Count})";

            if (App.EMP.RoleID == 2)
            {
                add_button.Visibility = delete_button.Visibility = Visibility.Collapsed;
                EmployeesDG.Columns[1].Visibility =  EmployeesDG.Columns[2].Visibility = Visibility.Collapsed;
            }
        }

		private void open_add_employees(object sender, RoutedEventArgs e)
		{
            AddEmployee ae = new AddEmployee(EmployeesDG, emps_header)
            {
                Owner = BooksWindow
            };
            ae.ShowDialog();
		}

		private void ShowPassword(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(((EMPLOYEES)EmployeesDG.SelectedItem).EPassword);
		}

        private void employees_select(object sender, SelectionChangedEventArgs e)
        {
			if (EmployeesDG.SelectedItems.Count != 0)
			{
                employee_error.Visibility = Visibility.Collapsed;
            }
        }

        private void open_delete_employees(object sender, RoutedEventArgs e)
        {
            var selemp = EmployeesDG.SelectedItems;
            if (selemp.Count > 0)
            {
				List<EMPLOYEES> emps = EmployeesDG.SelectedItems.Cast<EMPLOYEES>().ToList();
                EMPLOYEES em = emps.Find(emp => emp.RoleID == 1);
                if (em != null)
                {
                    emps.Remove(em);
                }
				if (emps.Count > 0)
				{
                    DeleteEmployees de = new DeleteEmployees(EmployeesDG, emps, emps_header)
                    {
                        Owner = BooksWindow
                    };
                    de.ShowDialog();
                }
                
            }
            else
            {
                employee_error.Text = "Выберите сотрудника для удаления";
                employee_error.Visibility = Visibility.Visible;
            }
        }

        private void emp_search(object sender, TextChangedEventArgs e)
        {
            string s = ((TextBox)sender).Text;
            EmployeesDG.ItemsSource = App.BOOKS.EMPLOYEES.Where(em => em.EmployeeName.Contains(s) && em.RoleID != 1).ToList();
            emps_header.Text = $"Сотрудники ({EmployeesDG.Items.Count})";
        }

        private void open_deleted_employees(object sender, RoutedEventArgs e)
        {
            DeletedEmployees de = new DeletedEmployees(EmployeesDG, emps_header)
            {
                Owner = BooksWindow
            };
            de.ShowDialog();
        }
    }
}