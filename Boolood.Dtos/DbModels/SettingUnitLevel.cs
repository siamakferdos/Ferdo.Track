using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Model.DbModels
{
    public class SettingUnitLevel : EntityBase
    {
        public string Name { get; set; }
        public List<TrackSetting> UnderTrackSettings { get; set; }
    }
}
