using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LIBRARY_lite
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static LIBRARYCP309updatedEntities BOOKS = new LIBRARYCP309updatedEntities();
    }
}
