using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Ferdo.Track.Framework.Core
{
    public interface IServiceRegistrar
    {
        void Register(IServiceCollection container);
    }
}
