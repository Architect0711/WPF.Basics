using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WPF.Basics.Converters
{
    /// <summary>
    /// https://stackoverflow.com/questions/147908/how-do-i-databind-a-columndefinitions-width-or-rowdefinitions-height
    /// TODO: Add Comment
    /// </summary>
    public class GridLengthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = 0;
            if (!double.TryParse(value.ToString(), out val))
            {
                val = 50;
            }

            GridLength gridLength = new GridLength(val);

            return gridLength;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            GridLength val = (GridLength)value;

            return val.Value;
        }
    }
}
