using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace WPF.Basics.Converters
{
    /// <summary>
    /// https://stackoverflow.com/questions/534575/how-do-i-invert-booleantovisibilityconverter
    /// Derive from this Class to get a configurable Converter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConfigurableBooleanToGenericConverter<T> : IValueConverter
    {
        public ConfigurableBooleanToGenericConverter(T trueValue, T falseValue)
        {
            True = trueValue;
            False = falseValue;
        }

        public T True { get; set; }
        public T False { get; set; }

        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var returnvalue = value is bool && ((bool)value) ? True : False;
            return returnvalue;
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is T && EqualityComparer<T>.Default.Equals((T)value, True);
        }
    }
}
