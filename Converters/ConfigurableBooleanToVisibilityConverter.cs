using System.Windows;

namespace WPF.Basics.Converters
{
    /// <summary>
    /// https://stackoverflow.com/questions/534575/how-do-i-invert-booleantovisibilityconverter
    /// </summary>
    public class ConfigurableBooleanToVisibilityConverter : ConfigurableBooleanToGenericConverter<Visibility>
    {
        public ConfigurableBooleanToVisibilityConverter() :
        base(Visibility.Visible, Visibility.Collapsed)
        { }
    }
}
