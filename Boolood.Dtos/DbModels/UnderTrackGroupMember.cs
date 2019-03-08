using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.DbModels
{
    public class UnderTrackGroupMember: EntityBase
    {
        public Guid GroupId { get; set; }
        public Guid UnderTrackId { get; set; }

        public UnderTrackGroup UnderTrackGroup { get; set; }
        public UnderTrack UnderTrack { get; set; }

    }
}
