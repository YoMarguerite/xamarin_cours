using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;


namespace Pizzeria.Converter
{
    public class BoolToVeganImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isVegetarian = value as bool?;
            if (!isVegetarian.HasValue || !isVegetarian.Value)
            {
                return string.Empty;
            }

            return "vegan.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
