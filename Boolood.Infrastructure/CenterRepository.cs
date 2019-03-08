using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Framework.Repository;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Persistence.DbContext;

namespace Ferdo.Track.Infrastructure
{
    public class CenterRepository: RepositoryBase<AppDbContext>, ICenterRepository
    {
        private AppDbContext _appDbContext;
        public CenterRepository(AppDbContext dbContext) : base(dbContext)
        {
            _appDbContext = dbContext;
        }

        public void AddCenter(Center center)
        {
            AddEntity(center);
        }

        
    }
}
