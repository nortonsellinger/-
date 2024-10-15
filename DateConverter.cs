using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace LIBRARY_lite
{
    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type type, object parameter, CultureInfo cult)
        {
            if (value == null)
            {
                return null;
            }
            string text = parameter != null ? parameter.ToString() : "";
            return text + ((DateTime)value).ToString("d");
        }
        public object ConvertBack(object value, Type type, object parameter, CultureInfo cult)
        {
            throw new NotImplementedException();
        }
    }
}
