using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ferdo.Track.Framework.Helper
{
    public class DateHelper
    {
        public static string GetPersianDate(long timeInMiliSeconds)
        {
            PersianCalendar pc = new PersianCalendar();
            var time = new System.DateTime(timeInMiliSeconds);
            return $"{pc.GetYear(time)}/{pc.GetMonth(time):00}/{pc.GetDayOfMonth(time):00}";
        }

        public static DateTime ConvertPersianDateToDateTimeOfDayStart(string persianDatetime)
        {
            if (!PersianDateValidator.IsValid(persianDatetime))
            {
                throw new NotValidPersianDateStringFormatException();
            }

            var dateParts = persianDatetime.Split("/");

            var pc = new PersianCalendar();
            return pc.ToDateTime(dateParts[0].ToInt(), dateParts[1].ToInt(), dateParts[2].ToInt(), 0, 0, 0, 0);

        }

        public static DateTime ConvertPersianDateToDateTimeOfDayEnd(string persianDatetime)
        {
            if (!PersianDateValidator.IsValid(persianDatetime))
            {
                throw new NotValidPersianDateStringFormatException();
            }

            var dateParts = persianDatetime.Split("/");

            var pc = new PersianCalendar();
            return pc.ToDateTime(dateParts[0].ToInt()
                , dateParts[1].ToInt()
                , dateParts[2].ToInt()
                , 23
                , 59
                , 59
                , 999);

        }

        public static DateTime GetDateTimeOfDayStart(DateTime fromDate)
        {
            return new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 0, 0);
        }

        public static DateTime GetDateTimeOfDayEnd(DateTime fromDate)
        {
            return new DateTime(fromDate.Year
                , fromDate.Month
                , fromDate.Day
                , 23
                , 59
                , 59
                , 999);
        }
    }
}
