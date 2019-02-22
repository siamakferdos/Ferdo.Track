using System;
using System.Collections.Generic;
using Ferdo.Track.Framework.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Ferdo.Track.Framework.DI
{
    public class DiContainer: IDiContainer
    {
        private static IServiceProvider _container;

        public DiContainer(IServiceProvider container)
        {
            _container = container;
        }

        public T Resolve<T>()
        {
            return _container.GetService<T>();
        }

        public IEnumerable<T> ResolveAll<T>()
        {
            return _container.GetServices<T>();
        }
    }
}
