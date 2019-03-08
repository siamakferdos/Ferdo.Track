using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Model.Dtos;

namespace Ferdo.Track.Framework.Core.Query
{
    public interface IUnderTrackQuery
    {
        List<UnderTrackGroupDto> GetUnderTrackGroups(string username);
        List<UnderTrackTypeDto> GetUnderTrackTypes();
    }
}
