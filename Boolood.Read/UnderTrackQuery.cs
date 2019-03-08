
using System.Collections.Generic;
using System.Linq;
using Ferdo.Track.Framework.Core.Query;
using Ferdo.Track.Model.Dtos;
using Ferdo.Track.Persistence.DbContext;

namespace Ferdo.Track.Read
{
    public class UnderTrackQuery : QueryBase, IUnderTrackQuery
    {
        private AppDbContext _appDbContext;
        public UnderTrackQuery(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<UnderTrackGroupDto> GetUnderTrackGroups(string username)
        {
            var query = from groups in _appDbContext.UnderTrackGroups
                join center in _appDbContext.Centers
                    on groups.CenterId equals center.Id
                where center.UserId == username
                select new UnderTrackGroupDto {Id = groups.Id, Name = groups.Name};

            return query.ToList();

        }

        public List<UnderTrackTypeDto> GetUnderTrackTypes()
        {
            var query = _appDbContext.UnderTrackTypes;
            return query.ToList().ConvertAll(ut => new UnderTrackTypeDto
                {
                    Id = ut.Id,
                    Name = ut.Name
                });
        }
    }
}
