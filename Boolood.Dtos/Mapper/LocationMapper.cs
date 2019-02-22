using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Model.Dtos;

namespace Ferdo.Track.Model.Mapper
{
    public static class LocationMapper
    {
        public static LocationPoint MapToDbModel(this LocationDto articleDto)
        {
            return new LocationPoint
            {
              
            };
        }

        public static LocationDto GetArticleDto(this LocationPoint article)
        {
            return new LocationDto
            {
               
            };
        }
    }
}
