using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Model.Dtos;
using Ferdo.Track.Model.Mapper;

namespace Ferdo.Track.Services.ConfigurationContext
{
    public class UnderTrackService: IUnderTrackService
    {
        private readonly IUnderTrackRepository _underTrackRepository;

        public UnderTrackService(IUnderTrackRepository underTrackRepository)
        {
            _underTrackRepository = underTrackRepository;
        }
        public void AddGroup(UnderTrackGroupDto underTrackGroupDto)
        {
            _underTrackRepository.AddGroup(underTrackGroupDto.MapToDbModel());
        }

        public void AddUnderTrack(UnderTrackDto underTrackDto)
        {
            _underTrackRepository.AddUnderTrack(underTrackDto.MapToDbModel());
        }

        public void UpdateGroupUnderTrackMembers(List<UnderTrackGroupMemberDto> underTrackGroupDtos)
        {
            _underTrackRepository.UpdateGroupUnderTrackMembers(
                underTrackGroupDtos.ConvertAll(u => u.MapToDbModel()));
        }

       
    }
}
