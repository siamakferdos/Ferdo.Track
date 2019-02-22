using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.DbModels
{
    public class UnderTrackType: EntityBase
    {
        public string Name { get; set; }

        public List<UnderTrack> UnderTracks { get; set; }
    }
}
