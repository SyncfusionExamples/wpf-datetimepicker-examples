using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace DateTimeFormatting
{
    public class PatternConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTimePattern)
                return (DateTimePattern)value;
            else
                return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ComboBoxItem)
            {
               return (DateTimePattern)Enum.Parse(typeof(DateTimePattern), (value as ComboBoxItem).Content.ToString());
            }
            return value;
        }
    }
}
