using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.Contacts.Model
{
    public class AvatarBackground
    {
        private readonly static Dictionary<char, string> colors = new Dictionary<char, string>()
        {
            { 'A', "#262262" },
            { 'C', "#3D3B30" },
            { 'D', "#629677" },
            { 'F', "#993955" },
            { 'J', "#243E36" },
            { 'K', "#DA3E52" },
            { 'M', "#A30000" },
        };

        public static string GetColor(char c)
        { 
            colors.TryGetValue(c, out string color);
            return color;
        }
    }
}
