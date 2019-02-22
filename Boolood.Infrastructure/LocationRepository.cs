using System;
using System.Collections.Generic;
using Ferdo.Track.Framework.Repository;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Persistence.DbContext;

namespace Ferdo.Track.Infrastructure
{
    public class LocationRepository: RepositoryBase<AppDbContext>, ILocationRepository
    {
        private AppDbContext _appDbContext;
        public LocationRepository(AppDbContext dbContext) : base(dbContext)
        {
            _appDbContext = dbContext;
        }

        public void AddLocationPoints(List<LocationPoint> locationPoints)
        {
            AddEntities(locationPoints);
        }
    }
}
