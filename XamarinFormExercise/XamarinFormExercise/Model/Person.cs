using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormExercise.Model
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get { return Firstname + " " + Lastname; } }
        public string ContactNumber { get; set; }
        public string ColorLogo { get; set; }
        public string FirstLetter {
            get
            { 
                return Firstname.Substring(0, 1) + Lastname.Substring(0, 1);
           }
        }
    }
}
