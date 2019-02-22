﻿using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Framework.Core;

namespace Ferdo.Track.Framework.DI
{
    public class ServiceLocator
    {
        public ServiceLocator(IDiContainer container)
        {
            Current = container;
        }

        public static IDiContainer Current
        {
            get;
            private set;
        }
    }
}
