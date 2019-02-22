using System.Collections.Generic;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Framework.Repository;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Services.LocationContext
{
    public class LocationService: ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository articleRepository)
        {
            _locationRepository = articleRepository;
        }

        public void AddLocationPoints(List<LocationPoint> locationPoints) =>
            _locationRepository.AddLocationPoints(locationPoints);
    }
}
