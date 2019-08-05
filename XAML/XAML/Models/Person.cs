using System;
using System.Collections.Generic;
using System.Text;

namespace XAML.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string FullDetails
        {
            get
            {
                return FirstName + " " + LastName + "\n" + ContactNumber;
            }
        }
        public string NameInitials
        {
            get
            {
                return FirstName[0].ToString() + LastName[0].ToString();
            }
        }
    }
}
