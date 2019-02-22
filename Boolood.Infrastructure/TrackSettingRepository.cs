using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Framework.Core.Services;
using Ferdo.Track.Framework.Repository;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Persistence.DbContext;

namespace Ferdo.Track.Infrastructure
{
    public class TrackSettingRepository: RepositoryBase<AppDbContext>, ITrackSettingRepository
    {
        private AppDbContext _appDbContext;
        public TrackSettingRepository(AppDbContext dbContext) : base(dbContext)
        {
            _appDbContext = dbContext;
        }

        public void AddSettingUnitLevels(List<SettingUnitLevel> settingUnitLevels)
        {
            AddEntities(settingUnitLevels);
        }

        public List<SettingUnitLevel> GetSettingUnitLevels()
        {
            return GetAllEntities<SettingUnitLevel>();
        }
    }
}
