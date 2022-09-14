using System.Globalization;

namespace Vorlesung_11.Converter;

public sealed class ReverseConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var stringValue = (string) value;
        var reversedValue = stringValue?.Reverse().ToArray() ?? Array.Empty<char>();
        var reversedString = new string(reversedValue);

        return reversedString;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return Convert(value, targetType, parameter, culture);
    }
}