using System.Collections.Generic;
using System.Linq;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Framework.Repository;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Model.Dtos;
using Ferdo.Track.Model.Mapper;

namespace Ferdo.Track.Services.LocationContext
{
    public class LocationService: ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        private readonly IUnderTrackRepository _underTrackRepository;

        public LocationService(ILocationRepository articleRepository,
            IUnderTrackRepository underTrackRepository)
        {
            _locationRepository = articleRepository;
            _underTrackRepository = underTrackRepository;
        }

        public void AddLocations(List<LocationDto> locationDtos)
        {
            if (locationDtos.Any() && locationDtos[0].UnderTrackId == null)
            {
                var underTrackId = _underTrackRepository.GetGuid(locationDtos[0].Imei);
                locationDtos.ForEach(l => l.UnderTrackId = underTrackId);
            }
            _locationRepository.AddLocationPoints(
                locationDtos.ConvertAll(l => l.MapToDbModel())
            );
        }
    }
}
