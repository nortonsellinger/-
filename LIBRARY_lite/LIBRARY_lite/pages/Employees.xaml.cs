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
        TextBlock emp_name;
        public Employees(Window BW, Frame f, TextBlock n)
		{
			InitializeComponent();
			frame = f;
			BooksWindow = BW;
			emp_name = n;
			//var emps = App.BOOKS.EMPLOYEES.Join(App.BOOKS.USERS, emp => emp.EmployeeID, user => user.EmployeeID, (emp, user) => new
			//{
			//	EmployeeName = emp.EmployeeName,
			//	ULogin = user.ULogin,
			//	UPassword = user.UPassword,
			//	EmployeeRole = emp.EmployeeRole
			//}).Join(App.BOOKS.ROLES, emp => emp.EmployeeRole, role => role.RoleID,
			//		(emp, role) => new
			//		{
			//			EmployeeName = emp.EmployeeName,
			//			RoleName = role.RoleName,
			//			ULogin = emp.ULogin,
			//			UPassword = emp.UPassword,
			//		}).ToList();
			//EmployeesDG.ItemsSource = emps;
			EmployeesDG.ItemsSource = App.BOOKS.EMPLOYEES.Where(em => em.IsWorking == true).ToList();
        }

		private void open_add_employees(object sender, RoutedEventArgs e)
		{
			AddEmployee ae = new AddEmployee(EmployeesDG);
			ae.Owner = BooksWindow;
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
                //MessageBox.Show(e.AddedItems.ToString());
            }
        }

        private void open_edit_employees(object sender, RoutedEventArgs e)
        {
			var selemp = EmployeesDG.SelectedItems;
            if (selemp.Count != 0)
			{
				if (selemp.Count == 1)
				{
                    EditEmployees ee = new EditEmployees(EmployeesDG, (EMPLOYEES)EmployeesDG.SelectedItem, emp_name);
					ee.Owner = BooksWindow;
					ee.ShowDialog();
                }
				else
				{
                    employee_error.Text = "Выберите только одного сотрудника";
                    employee_error.Visibility = Visibility.Visible;
                }
			}
			else
			{
				employee_error.Text = "Выберите сотрудника для редактирования";
				employee_error.Visibility = Visibility.Visible;
			}
        }

        private void open_delete_employees(object sender, RoutedEventArgs e)
        {
            var selemp = EmployeesDG.SelectedItems;
            if (selemp.Count != 0)
            {
                DeleteEmployees de = new DeleteEmployees(EmployeesDG, EmployeesDG.SelectedItems.Cast<EMPLOYEES>().ToList());
                de.Owner = BooksWindow;
                de.ShowDialog();
            }
            else
            {
                employee_error.Text = "Выберите сотрудника для удаления";
                employee_error.Visibility = Visibility.Visible;
            }
        }
    }
}
