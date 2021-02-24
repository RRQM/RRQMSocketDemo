using System;
using System.Globalization;
using System.Windows.Data;

namespace FileSocketServiceDemo
{
    public class SpeedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value / (1024 * 1024.0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double num = (double)value;
            return (int)(num * (1024 * 1024));
        }
    }
}