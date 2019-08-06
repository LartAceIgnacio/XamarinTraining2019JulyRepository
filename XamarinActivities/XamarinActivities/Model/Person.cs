using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinActivities.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string InitialKey { get { return FirstName.Substring(0, 1) + LastName.Substring(0, 1); } }
        public string InitialKeyColor { get; set; }
        public string ImgURL { get; set; }

        public string GetInitialKey(string firstName, string lastName)
        {
            return firstName.Substring(0,1) + lastName.Substring(0,1);
        }
    }
}
