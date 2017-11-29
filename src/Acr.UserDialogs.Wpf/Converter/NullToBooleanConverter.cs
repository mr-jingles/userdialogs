using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Acr.UserDialogs.Converter
{
    public class NullToBooleanConverter : IValueConverter

    {

        /// <summary>

        /// Converts a null to a Boolean.

        /// </summary>



        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var invert = (parameter != null) && System.Convert.ToBoolean(parameter);
            var result = value != null;
            if (invert)
            {
                result = !result;
            }

            return result;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
