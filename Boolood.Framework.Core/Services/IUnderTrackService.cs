using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Model.Dtos;

namespace Ferdo.Track.Framework.Core.Services
{
    public interface IUnderTrackService
    {
        void AddGroup(UnderTrackGroupDto underTrackGroupDto);
        void AddUnderTrack(UnderTrackDto underTrackDto);
        void UpdateGroupUnderTrackMembers(List<UnderTrackGroupMemberDto> underTrackGroupDtos);
    }
}
