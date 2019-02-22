using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.DbModels
{
    public class TrackSetting : EntityBase
    {
        public Guid UnitId { get; set; }
        public Guid GroupLevel { get; set; }
        public TimeSpan TrackingStartTime { get; set; }
        public TimeSpan TrackingEndTime { get; set; }
        public int UpdateTimeSpeed { get; set; }
    }
}
