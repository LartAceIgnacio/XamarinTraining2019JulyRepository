using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace XAML.Models
{
    public class SideColor:Person
    {
        public Dictionary<char, Color> Colors = new Dictionary<char, Color>()
        {
            {'A', Color.Red},
            {'C', Color.Orange},
            {'D', Color.Yellow},
            {'F', Color.Green},
            {'J', Color.Blue },
            {'K', Color.Indigo},
            {'M', Color.Violet}
        };
        public Color BoxBgColor
        {
            get
            {
                return Colors.Where(c => c.Key == NameInitials[0]).FirstOrDefault().Value;
            }
        }

    }
}
