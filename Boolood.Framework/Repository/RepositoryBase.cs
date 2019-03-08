using System;
using System.Collections.Generic;
using System.Linq;
using Ferdo.Track.Model.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Ferdo.Track.Framework.Repository
{
    public abstract class RepositoryBase<TDbContext> 
        where TDbContext: DbContext 
    {
        private readonly TDbContext _appDbContext;
        protected RepositoryBase(TDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        protected TDbContext GetAppDbContext()
        {
            return _appDbContext;
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }

        protected void AddEntity(EntityBase entity)
        {
            _appDbContext.Add(entity);
            SaveChanges();
        }

        protected void AddEntities<T>(List<T> entities) where T: EntityBase
        {
            _appDbContext.AddRange(entities);
            SaveChanges();
        }

        protected T GetEntity<T>(Guid id) where T: EntityBase
        {
            return GetAppDbContext().Find<T>(id);
        }

        protected T GetEntity<T>(Func<T, bool> predicate) where T : EntityBase
        {
            return GetAppDbContext().Set<T>().SingleOrDefault(predicate);
        }

        protected List<T> GetAllEntities<T>() where T : EntityBase
        {
            return GetAppDbContext().Set<T>().ToList();
        }
        protected List<T> GetAllEntities<T>(Func<T, bool> predicate) where T : EntityBase
        {
            return GetAppDbContext().Set<T>().Where(predicate).ToList();
        }
    }
}
