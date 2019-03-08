using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Model.Dtos;

namespace Ferdo.Track.Model.Mapper
{
    public static class UnderTrackMapper
    {
        public static UnderTrackGroup MapToDbModel(this UnderTrackGroupDto underTrackGroupDto)
        {
            var underTrackGroup = new UnderTrackGroup
            {
                CenterId = underTrackGroupDto.CenterId,
                Name = underTrackGroupDto.Name,
                Description = underTrackGroupDto.Description,
            };
            if (underTrackGroupDto.Id.HasValue)
                underTrackGroup.Id = underTrackGroupDto.Id.Value;

            return underTrackGroup;
        }

        public static UnderTrack MapToDbModel(this UnderTrackDto underTrackDto)
        {
            var underTrack = new UnderTrack
            {
                CenterId = underTrackDto.CenterId,
                Name = underTrackDto.Name,
                CellNumber = underTrackDto.CellNumber,
                Imei = underTrackDto.Imei
            };
            if (underTrackDto.Id.HasValue) underTrack.Id = underTrackDto.Id.Value;
            if (underTrackDto.CreationDate != null) underTrack.CreationDate = underTrackDto.CreationDate.Value;
            if (underTrackDto.UnderTrackTypeId != null) underTrack.UnderTrackTypeId = underTrackDto.UnderTrackTypeId.Value;
            return underTrack;
        }

        public static UnderTrackGroupMember MapToDbModel(this UnderTrackGroupMemberDto underTrackGroupMemberDto)
        {
            var underTrackGroupMember = new UnderTrackGroupMember
            {
                GroupId = underTrackGroupMemberDto.GroupId,
                UnderTrackId = underTrackGroupMemberDto.UnderTrackId
            };
            if (underTrackGroupMemberDto.Id.HasValue)
                underTrackGroupMember.Id = underTrackGroupMemberDto.Id.Value;
            if (underTrackGroupMemberDto.CreationDate != null) underTrackGroupMember.CreationDate = underTrackGroupMemberDto.CreationDate.Value;

            return underTrackGroupMember;
        }
    }
}
