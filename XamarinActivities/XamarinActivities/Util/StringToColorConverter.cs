using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using Xamarin.Forms;

using XamarinActivities.Models;

namespace XamarinActivities.Util
{
    public class StringToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                Contact contact = value as Contact;
                var FirstLetter = contact.Initials[0].ToString();
                switch (FirstLetter)
                {
                    case "A":
                        return Color.Red;
                    case "C":
                        return Color.Chocolate;
                    case "D":
                        return Color.DarkGreen;
                    case "F":
                        return Color.Firebrick;
                    case "J":
                        return Color.Indigo;
                    case "K":
                        return Color.Orange;
                    case "M":
                        return Color.Magenta;
                    default:
                        return Color.Black;
                };

            }
            return Color.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
