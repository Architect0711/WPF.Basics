using System;
using System.Globalization;
using System.Windows.Data;
using WPF.Basics.Extensions.Color;

namespace WPF.Basics.Converters
{
    public class SystemDrawingColorToSolidColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is System.Drawing.Color color)
            {
                return color.ToSolidColorBrush();
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
