using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Framework.Core
{
    public interface IDiContainer
    {
        T Resolve<T>();

        IEnumerable<T> ResolveAll<T>();
    }
}
