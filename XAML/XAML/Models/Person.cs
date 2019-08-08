using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace XAML.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string ImageUrl { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string NameInitials
        {
            get
            {
                return FirstName[0].ToString() + LastName[0].ToString();
            }
        }

        public string Email
        {
            get
            {
                return FirstName[0].ToString().ToLower() + LastName.ToString().ToLower().Replace(" ", "") + "@blastasia.com";
            }
        }
        public Dictionary<char, Color> Colors = new Dictionary<char, Color>()
        {
            {'A', Color.Red},
            {'B', Color.Bisque},
            {'C', Color.Orange},
            {'D', Color.Yellow},
            {'F', Color.Green},
            {'J', Color.Blue },
            {'K', Color.Indigo},
            {'L', Color.Lavender},
            {'M', Color.Violet},
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
