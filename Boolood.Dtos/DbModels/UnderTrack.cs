using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.DbModels
{
    public class UnderTrack: EntityBase
    {
        public string Name { get; set; }
        public Guid UnderTrackTypeId { get; set; }
        public string Imei { get; set; }
        public string CellNumber { get; set; }

        public UnderTrackType UnderTrackType { get; set; }

    }
}
