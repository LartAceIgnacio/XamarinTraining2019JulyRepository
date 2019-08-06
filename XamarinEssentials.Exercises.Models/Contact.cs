using System;
using System.Collections.Generic;
using System.Drawing;

namespace XamarinEssentials.Exercises.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }

        public readonly IDictionary<string, Color> AvatarColors = new Dictionary<string, Color>()
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

        public string GetInitials
        {
            get
            {
                return String.Format("{0}{1}", FirstName[0], LastName[0]);
            }
        }

        public Color GetAvatarColor
        {
            get
            {
                return AvatarColors[FirstName[0].ToString()];
            }
        }
    }
}
