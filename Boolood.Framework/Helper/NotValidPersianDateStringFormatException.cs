using System;
using System.Runtime.Serialization;
using Ferdo.Track.Framework.Exception;

namespace Ferdo.Track.Framework.Helper
{
    internal class NotValidPersianDateStringFormatException : ExceptionBase
    {
        public override string GetMessage()
        {
            //todo NotValidPersianDateStringFormatException
            return "NotValidPersianDateStringFormatException";
        }
    }
}