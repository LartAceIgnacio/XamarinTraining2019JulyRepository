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
                        return Color.Coral;
                    case "B":
                        return Color.Blue;
                    case "C":
                        return Color.Chocolate;
                    case "D":
                        return Color.DarkGreen;
                    case "E":
                        return Color.DeepSkyBlue;
                    case "F":
                        return Color.Firebrick;
                    case "G":
                        return Color.Gainsboro;
                    case "H":
                        return Color.Honeydew;
                    case "I":
                        return Color.Ivory;
                    case "J":
                        return Color.Indigo;
                    case "K":
                        return Color.Orange;
                    case "L":
                        return Color.Lavender;
                    case "M":
                        return Color.MediumPurple;
                    case "N":
                        return Color.Navy;
                    case "O":
                        return Color.OldLace;
                    case "P":
                        return Color.PaleTurquoise;
                    case "Q":
                        return Color.PaleGoldenrod;
                    case "R":
                        return Color.Azure;
                    case "S":
                        return Color.Salmon;
                    case "T":
                        return Color.Tan;
                    case "U":
                        return Color.Teal;
                    case "V":
                        return Color.Fuchsia;
                    case "W":
                        return Color.Wheat;
                    case "X":
                        return Color.Honeydew;
                    case "Y":
                        return Color.DarkOliveGreen;
                    case "Z":
                        return Color.BurlyWood;
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
