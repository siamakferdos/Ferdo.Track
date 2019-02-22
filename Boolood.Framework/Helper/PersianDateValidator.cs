using System.Linq;

namespace Ferdo.Track.Framework.Helper
{
    internal class PersianDateValidator
    {
        public static bool IsValid(string persianDate)
        {
            return HasValidLenght(persianDate) &&
                   HasValidSepetations(persianDate);
        }

        private static bool HasValidLenght(string date) => date.Length == 10;

        private static bool HasValidSepetations(string date)
        {
            var dateParts = date.Split("/");
            if (dateParts.Length != 3) return false;

            if (dateParts[0].Length != 4
                || dateParts[1].Length != 2
                || dateParts[2].Length != 2) return false;

            return dateParts.All(p => p.IsInteger());
        }
    }
}