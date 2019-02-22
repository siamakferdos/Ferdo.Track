using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.DbModels
{
    public class UnderTrackGroup: EntityBase
    {
        public Guid CenterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public UnderTrackType UnderTrackType { get; set; }
        public Center Center { get; set; }
        public List<UnderTrack> UnderTracks { get; set; }

    }
}
