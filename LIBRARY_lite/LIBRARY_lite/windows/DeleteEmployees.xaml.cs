﻿using System;
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
    /// Логика взаимодействия для DeleteEmployees.xaml
    /// </summary>
    public partial class DeleteEmployees : Window
    {
        DataGrid edg;
        List<EMPLOYEES> emps;
        public DeleteEmployees(DataGrid dg, List<EMPLOYEES> e)
        {
            InitializeComponent();
            edg = dg;
            emps = e;
            string todelete = "";
            EMPLOYEES em = emps.Find(emp => emp.RoleID == 1);
            if (em != null)
            {
                emps.Remove(em);
            }
            foreach(EMPLOYEES emp in emps)
            {
                todelete += emp.EmployeeName + "\n";
            }
            empstodelete.Text = todelete.Substring(0, todelete.Length - 1);
        }

        private void delete_employee(object sender, RoutedEventArgs e)
        {
            foreach(EMPLOYEES emp in emps)
            {
                App.BOOKS.EMPLOYEES.Find(emp.EmployeeID).IsWorking = false;
            }
            App.BOOKS.SaveChanges();
            edg.ItemsSource = App.BOOKS.EMPLOYEES.Where(em => em.IsWorking == true).ToList();
            this.Close();
        }

        private void cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
