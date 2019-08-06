using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinExcercise
{
    public class Person
    {
        public Dictionary<char, Color> ColorName = new Dictionary<char, Color>()
        {
            {'A',Color.Blue },
            {'B',Color.Red },
            {'C',Color.Olive },
            {'D',Color.Aqua },
            {'E',Color.Bisque },
            {'F',Color.Brown },
            {'G',Color.Chocolate },
            {'H',Color.Cyan },
            {'I',Color.DarkRed },
            {'J',Color.BurlyWood },
            {'K',Color.Orange },
            {'L',Color.BlueViolet },
            {'M',Color.Chartreuse },
            {'N',Color.Coral },
            {'O',Color.CornflowerBlue },
            {'P',Color.DarkKhaki },
            {'Q',Color.DarkSalmon },
            {'R',Color.ForestGreen },
            {'S',Color.FromRgb(42,111,55) },
            {'T',Color.FromRgb(111,233,121) },
            {'U',Color.FromRgb(66,123,42) },
            {'V',Color.FromRgb(44,11,33) },
            {'W',Color.FromRgb(222,44,111) },
            {'X',Color.FromRgb(64,232,1) },
            {'Y',Color.FromRgb(93,11,141) },
            {'Z',Color.FromRgb(63,54,15) }
        };
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ContactNumber { get; set; }
        public string FullName
        {

            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }
        }
        public Color NameColor
        {
            get
            {
                return ColorName.Where(c => c.Key == Initial[0]).FirstOrDefault().Value;
            }
        }
        public string Initial
        {

            get
            {
                return string.Format("{0}{1}", FirstName[0], LastName[0]);
            }
        }


    }
}