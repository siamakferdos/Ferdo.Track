﻿using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Model.DbModels;

namespace Ferdo.Track.Framework.Core.Repository
{
    public interface IUnderTrackRepository
    {
        void AddTypes(List<UnderTrackType> underTrackTypes);
        List<UnderTrackType> GetTypes();
        void AddGroup(UnderTrackGroup underTrackGroup);
        void AddUnderTrack(UnderTrack underTrack);
        void UpdateGroupUnderTrackMembers(List<UnderTrackGroupMember> underTrackGroupMembers);
        Guid GetGuid(string imei);
    }
}
