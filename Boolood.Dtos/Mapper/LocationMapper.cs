using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Model.Dtos;

namespace Ferdo.Track.Model.Mapper
{
    public static class LocationMapper
    {
        public static LocationPoint MapToDbModel(this LocationDto locationDto)
        {
            var locationPoint = new LocationPoint
            {
                Imei = locationDto.Imei,
                Accuracy = locationDto.Accuracy,
                Altitude = locationDto.Altitude,
                Latitude = locationDto.Latitude,
                Longitude = locationDto.Longitude,
                Speed = locationDto.Speed,
                Time = locationDto.Time
            };
            if (locationDto.Id.HasValue) locationPoint.Id = locationDto.Id.Value;
            if (locationDto.CreationDate != null) locationPoint.CreationDate = locationDto.CreationDate.Value;
            if (locationDto.UnderTrackId != null) locationPoint.UnderTrackId = locationDto.UnderTrackId.Value;

            return locationPoint;
        }

        public static LocationDto GetArticleDto(this LocationPoint article)
        {
            return new LocationDto
            {
                Id = article.Id,
                Imei = article.Imei,
                UnderTrackId = article.UnderTrackId,
                Accuracy = article.Accuracy,
                Altitude = article.Altitude,
                Latitude = article.Latitude,
                Longitude = article.Longitude,
                Speed = article.Speed,
                Time = article.Time,
                CreationDate = article.CreationDate
            };
        }
    }
}
