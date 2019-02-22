using Ferdo.Track.Model.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ferdo.Track.Framework.Core.Services
{
    public interface ITrackSettingRepository
    {
        void AddSettingUnitLevels(List<SettingUnitLevel> settingUnitLevels);
        List<SettingUnitLevel> GetSettingUnitLevels();
    }
}
