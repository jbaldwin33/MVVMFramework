using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MVVMFrameworkNet472.Utilities
{
    public class BooleanToHiddenVisibility : IValueConverter
    {
        private object GetVisibility(object value)
        {
            if (!(value is bool objValue))
                return Visibility.Visible;
            return objValue ? Visibility.Visible : Visibility.Hidden;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => GetVisibility(value);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
        //return value != null && (Visibility)value == Visibility.Collapsed;
    }

    public class InverseBooleanToVisibilityConverter : IValueConverter
    {
        private object GetVisibility(object value)
        {
            if (!(value is bool objValue))
                return Visibility.Collapsed;
            return objValue ? Visibility.Collapsed : Visibility.Visible;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => GetVisibility(value);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
        //return value != null && (Visibility)value == Visibility.Collapsed;
    }

    [ValueConversion(typeof(bool), typeof(bool))]
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(bool) && targetType != typeof(bool?))
                throw new InvalidOperationException("The target must be a boolean");

            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(bool) && targetType != typeof(bool?))
                throw new InvalidOperationException("The target must be a boolean");

            return !(bool)value;
        }
    }
}
