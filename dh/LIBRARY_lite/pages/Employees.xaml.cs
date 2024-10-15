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
using System.Windows.Forms;
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

        public Employees(Window BW, Frame frame)
		{
			InitializeComponent();
			this.frame = frame;
			BooksWindow = BW;
			var emps = App.BOOKS.EMPLOYEES.Join(App.BOOKS.USERS, emp => emp.EmployeeID, user => user.EmployeeID, (emp, user) => new
			{
				//EmpId = emp.EmployeeID,
				EmployeeName = emp.EmployeeName,
				ULogin = user.ULogin,
				UPassword = user.UPassword,
				EmployeeRole = emp.EmployeeRole
			}).Join(App.BOOKS.ROLES, emp => emp.EmployeeRole, role => role.RoleID,
					(emp, role) => new
					{
						EmployeeName = emp.EmployeeName,
						RoleName = role.RoleName,
						ULogin = emp.ULogin,
						UPassword = emp.UPassword,
					}).ToList();
			EmployeesDG.ItemsSource = emps;
		}

		private void open_add_employees(object sender, RoutedEventArgs e)
		{
			AddEmployee ae = new AddEmployee(EmployeesDG);
			ae.Owner = BooksWindow;
            ae.ShowDialog();
		}

		private void ShowPassword(object sender, RoutedEventArgs e)
		{
			
		}
	}
}
