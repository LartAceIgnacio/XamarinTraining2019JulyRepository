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
        private Dictionary<String, String> _colorList = new Dictionary<String, String>()
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
        public string InitialKeyColor {
            get {
                foreach (var color in _colorList)
                {
                    var firstLetter = InitialKey.Substring(0, 1);
                    if (color.Key == firstLetter.ToUpper())
                    {
                        return color.Value;
                    }
                }
                return "#000";
            }
        }
        public string ImgURL { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }

        public string GetInitialKey(string firstName, string lastName)
        {
            var initialKey = firstName.Substring(0, 1) + lastName.Substring(0, 1);
            return initialKey.ToUpper;
        }
    }
}
