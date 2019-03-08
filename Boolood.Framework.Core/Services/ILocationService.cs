using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Model.Dtos;

namespace Ferdo.Track.Framework.Core.Services
{
    public interface ILocationService
    {
        void AddLocations(List<LocationDto> locationDtos);
    }
}
