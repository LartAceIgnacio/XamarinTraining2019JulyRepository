using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Contact.Model
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Initials
        {
            get
            {
                return FirstName[0].ToString() + LastName[0].ToString();
            }
        }

        public class ContactList : List<Person>
        {
            public string LongName { get; set; }
            public string ShortName { get; set; }
        }
        public Dictionary<char, Color> ColorList = new Dictionary<char, Color>()
        {
            {'A', Color.AliceBlue },
            {'B', Color.Red },
            {'C', Color.LightCyan },
            {'D', Color.BlanchedAlmond },
            {'E', Color.Lavender },
            {'F', Color.OrangeRed },
            {'G', Color.PaleGoldenrod },
            {'H', Color.Aquamarine },
            {'I', Color.Gold },
            {'J', Color.Honeydew },
            {'K', Color.PaleTurquoise },
            {'L', Color.Firebrick },
            {'M', Color.Yellow },
            {'N', Color.Beige },
            {'O', Color.Purple },
            {'P', Color.WhiteSmoke },
            {'Q', Color.RosyBrown },
            {'R', Color.DarkBlue },
            {'S', Color.DarkCyan },
            {'T', Color.DarkGreen },
            {'U', Color.ForestGreen },
            {'V', Color.Fuchsia },
            {'W', Color.RoyalBlue },
            {'X', Color.Bisque },
            {'Y', Color.SaddleBrown },
            {'Z', Color.Salmon },
            {'a', Color.DarkKhaki },
            {'b', Color.HotPink},
            {'c', Color.Indigo },
            {'d', Color.CadetBlue },
            {'e', Color.Chocolate },
            {'f', Color.Gold },
            {'g', Color.Ivory },
            {'h', Color.DarkMagenta },
            {'i', Color.DarkOrchid },
            {'j', Color.Cornsilk },
            {'k', Color.Crimson },
            {'l', Color.LawnGreen },
            {'m', Color.LemonChiffon },
            {'n', Color.Navy},
            {'o', Color.Orange },
            {'p', Color.PapayaWhip },
            {'q', Color.PeachPuff },
            {'r', Color.PowderBlue },
            {'s', Color.Silver },
            {'t', Color.Teal },
            {'u', Color.Gainsboro },
            {'v', Color.Violet },
            {'w', Color.White },
            {'y', Color.NavajoWhite },
            {'x', Color.Khaki },
            {'z', Color.Pink },
        };
        public Color BoxColor
        {
            get
            {
                return ColorList.Where(c => c.Key == Initials[0]).FirstOrDefault().Value;
            }
        }

    }
}
