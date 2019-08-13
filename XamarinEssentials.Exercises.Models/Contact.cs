using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using SQLite;

namespace XamarinEssentials.Exercises.Models
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Quote { get; set; }
        public string Birthday { get; set; }
        public string AvatarUrl { get; set; }

        private readonly IDictionary<string, Color> AvatarColors = new Dictionary<string, Color>()
            {
                { "A", Color.AliceBlue },
                { "B", Color.Blue },
                { "C", Color.Chocolate },
                { "D", Color.DarkKhaki },
                { "E", Color.DarkMagenta },
                { "F", Color.Firebrick },
                { "G", Color.Green },
                { "H", Color.Honeydew },
                { "I", Color.Indigo },
                { "J", Color.IndianRed },
                { "K", Color.Khaki },
                { "L", Color.Lavender},
                { "M", Color.Maroon },
                { "N", Color.Navy },
                { "O", Color.Orange },
                { "P", Color.Pink },
                { "Q", Color.Purple },
                { "R", Color.Red },
                { "S", Color.Salmon },
                { "T", Color.Turquoise },
                { "U", Color.Teal },
                { "V", Color.Violet },
                { "W", Color.Wheat },
                { "X", Color.Azure },
                { "Y", Color.Yellow },
                { "Z", Color.YellowGreen }
            };

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
                return String.Format("{0}{1}", FirstName.ToUpper()[0], LastName.ToUpper()[0]);
            }
        }

        public Color AvatarColor
        {
            get
            {
                return AvatarColors.Where(c => c.Key == Initials[0].ToString()).FirstOrDefault().Value;
                //return AvatarColors[FirstName[0].ToString()];
            }
        }

        public Color InitialsColor
        {
            get
            {
                return Color.FromArgb(AvatarColor.ToArgb() ^ 0xffffff);
            }
        }
    }
}
