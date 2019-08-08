using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace XamarinFormExercise.Model
{
    public class Person 
    {
        private Dictionary<string, string> ColorDictionary = new Dictionary<string, string>()
        {
                { "A", "#ff0000"},
                { "B", "#ff4000"},
                { "C", "#ff8000"},
                { "D", "#ffbf00"},
                { "E", "#bfff00"},
                { "F", "#80ff00"},
                { "G", "#00ff00"},
                { "H", "#00ffbf"},
                { "I", "#0040ff"},
                { "J", "#0000ff"},
                { "K", "#8000ff"},
                { "L", "#ff00ff"},
                { "M", "#f0327e"},
                { "N", "#856364"},
                { "O", "#74807c"},
                { "P", "#295730"},
                { "Q", "#3c0e3d"},
                { "R", "#85780b"},
                { "S", "#662308"},
                { "T", "#ff9eca"},
                { "U", "#9ee8ff"},
                { "V", "#c5ff9e"},
                { "W", "#f2ff9e"},
                { "X", "#822222"},
                { "Y", "#4a638c"},
                { "Z", "#e89c23"}
        };
   
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get { return Firstname + " " + Lastname; } }
        public string ContactNumber { get; set; }
        public string ColorLogo { get
            {
                string first = Firstname.Substring(0, 1);
                if (ColorDictionary.ContainsKey(first))
                {
                    return ColorDictionary[first];
                }
                 return "#000000";
            }
        }
        public string FirstLetter
        {
            get
            { 
                return Firstname.Substring(0, 1) + Lastname.Substring(0, 1);
           }
        }
        public string Image { get; set; }
        public string Quote { get; set; }
        
        
    }
}
