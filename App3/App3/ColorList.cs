using System;
using System.Collections.Generic;
using System.Text;

namespace App3
{
    public static class ColorList
    {
        public static SortedList<char, string> ColorsList = new SortedList<char, string>()
        {
            {'A', "Red" },
            {'J', "Blue" },
            {'L', "Violet" },
            {'K', "Orange" },
            {'M', "Black" },
            {'C', "Green" },
            {'D', "Purple" },
            {'H', "Pink" }
        };
    }
}
