using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfExercise.Converters
{
    [ValueConversion(typeof(Colors), typeof(string))]
    public class ColorsNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var test = value as Colors;


            //string val = value.ToString();
            string val = string.Concat(value.ToString().Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');

            return val;
            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
