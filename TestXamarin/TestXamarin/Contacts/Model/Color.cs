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
            { 'B', "#262263" },
            { 'C', "#3D3B30" },
            { 'D', "#629677" },
            { 'E', "#629877" },
            { 'F', "#993955" },
            { 'G', "#993965" },
            { 'H', "#993975" },
            { 'I', "#993985" },
            { 'J', "#243E36" },
            { 'K', "#DA3E52" },
            { 'L', "#DA3E62" },
            { 'M', "#A30000" },
            { 'N', "#A30000" },
            { 'O', "#A30000" },
            { 'P', "#A30000" },
            { 'Q', "#A30000" },
            { 'R', "#A30000" },
            { 'S', "#A30000" },
            { 'T', "#A30000" },
            { 'U', "#A30000" },
            { 'V', "#A30000" },
            { 'W', "#A30000" },
            { 'X', "#A30000" },
            { 'Y', "#A30000" },
            { 'Z', "#A30000" },
        };

        public static string GetColor(char c)
        { 
            colors.TryGetValue(c, out string color);
            return color;
        }
    }
}
