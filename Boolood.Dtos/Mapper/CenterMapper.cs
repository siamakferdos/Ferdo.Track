using System;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Model.Dtos;

namespace Ferdo.Track.Model.Mapper
{
    public static class CenterMapper
    {
        public static Center MapToDbModel(this CenterDto centerDto)
        {
            var center = new Center
            {
                Name = centerDto.Name,
                UserId = centerDto.UserId,
                ContractExpireTime = centerDto.ContractExpireTime
            };
            if (centerDto.Id != null) center.Id = centerDto.Id.Value;
            if (centerDto.CreationDate != null) center.CreationDate = centerDto.CreationDate.Value;
            return center;

        }

    }
}
