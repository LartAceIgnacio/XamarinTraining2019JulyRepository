using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinExercise.Models
{
    public class Contacts
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Birthday { get; set; }
        

        private readonly IDictionary<string, Color> alphabetofColor = new Dictionary<string, Color>()
        {
           {"A",Color.DarkSlateBlue},{"B",Color.BurlyWood},{"C",Color.IndianRed},{"D",Color.DarkSlateGray},{"E",Color.DarkSalmon},
           {"F",Color.ForestGreen},{"G",Color.Black },{"H",Color.HotPink},{"I",Color.Ivory},{"J",Color.Orange},
           {"K",Color.Brown},{"L",Color.LimeGreen},{"M",Color.FromRgb(27, 155, 194)},{"N",Color.Navy},{"O",Color.OrangeRed},
           {"P",Color.PeachPuff},{"Q",Color.Gainsboro},{"R",Color.RosyBrown},{"S",Color.Sienna},{"T",Color.Tomato},
           {"U",Color.SteelBlue},{"V",Color.Gray},{"W",Color.White},{"X",Color.Aqua},{"Y",Color.YellowGreen},
           {"Z",Color.Khaki}
        };
        public string FullName
        {
            get
            {
                return (FirstName + " " + LastName);
            }
        }
        public string Initials
        {
            get
            {
                return (FirstName[0].ToString() + LastName[0].ToString());
            }
        }
        public Color BoxColor
        {
            get
            {
                return alphabetofColor[FirstName[0].ToString().ToUpper()];
            }
        }
    }
}
