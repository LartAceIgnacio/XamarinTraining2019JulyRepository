using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Exercise1.Models
{
    public class Person
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }


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
            {'C', Color.LightCyan },
            {'D', Color.BlanchedAlmond },
            {'F', Color.OrangeRed },
            {'J', Color.Honeydew },
            {'K', Color.PaleTurquoise },
            {'M', Color.Yellow },
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
