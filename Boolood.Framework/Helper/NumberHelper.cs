using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Framework.Helper
{
    public static class NumberHelper
    {
        public static bool IsInteger(this string number)
        {
            return int.TryParse(number, out _);
        }

        public static int ToInt(this string number, int defaultValue = 0)
        {
            if (!number.IsInteger()) return defaultValue;
            return int.Parse(number);
        }
    }
}
