using System;
using System.Collections.Generic;
using System.Linq;
using Ferdo.Track.Framework.Core.Query;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Model.Dtos;
using Ferdo.Track.Persistence.DbContext;

namespace Ferdo.Track.Read
{
    public class LocationQuery: QueryBase, ILocationQuery
    {
        private AppDbContext _appDbContext;
        public LocationQuery(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<LocationDto> GetLocationPoints(DateTimeOffset dateTime, Guid underTrackId)
        {
            var locations =
            (
                from l in _appDbContext.LocationsPoints
                join u in _appDbContext.UnderTracks on l.UnderTrackId equals u.Id
                where l.CreationDate.CompareTo(dateTime) == 0 && l.UnderTrackId == underTrackId
                select new {LocationPoints = l, UnderTracks = u}
            ).ToList();

            var locationsDto = locations
                .ConvertAll(l => new LocationDto
                {
                    Accuracy = l.LocationPoints.Accuracy,
                    Altitude = l.LocationPoints.Altitude,
                    CreationDate = l.LocationPoints.CreationDate,
                    Imei = l.LocationPoints.Imei,
                    Latitude = l.LocationPoints.Latitude,
                    Longitude = l.LocationPoints.Longitude,
                    Speed = l.LocationPoints.Speed,
                    Time = l.LocationPoints.Time,
                    UnderTrackId = l.LocationPoints.UnderTrackId,
                    UnderTrackName = l.UnderTracks.Name,

                });
            return locationsDto;
        }
    }
}
