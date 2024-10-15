using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace LIBRARY_lite
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static lib3Entities BOOKS = new lib3Entities();

        internal static EMPLOYEES EMP;
        internal static double? WIDTH = null;
        internal static double? HEIGHT = null;
        internal static double? LEFT = null;
        internal static double? TOP = null;
        public App()
        {
            InitializeComponent();
        }
    }
}