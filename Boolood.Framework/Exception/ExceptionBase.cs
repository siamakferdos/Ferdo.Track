using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Framework.Exception
{
    public abstract class ExceptionBase: ApplicationException
    {
        public abstract string GetMessage();
    }
}
