using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.DbModels
{
    public class Center: EntityBase
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTimeOffset ContractExpireTime { get; set; }
        public List<UnderTrackGroup> UnderTrackGroups { get; set; }
        public List<TrackSetting> UnderTrackSettings { get; set; }

    }
}
