using System;
using System.Collections.Generic;
using System.Text;
using Ferdo.Track.Framework.Core.Repository;
using Ferdo.Track.Framework.Repository;
using Ferdo.Track.Model.DbModels;
using Ferdo.Track.Persistence.DbContext;

namespace Ferdo.Track.Infrastructure
{
    public class UnderTrackRepository: RepositoryBase<AppDbContext>, IUnderTrackRepository
    {
        public void AddTypes(List<UnderTrackType> underTrackTypes)
        {
            AddEntities(underTrackTypes);
        }

        public List<UnderTrackType> GetTypes()
        {
            return GetAllEntities<UnderTrackType>();
        }

        public void AddGroup(UnderTrackGroup underTrackGroup)
        {
            AddEntity(underTrackGroup);
        }

        public void AddUnderTrack(UnderTrack underTrack)
        {
            AddEntity(underTrack);
        }

        public void UpdateGroupUnderTrackMembers(List<UnderTrackGroupMember> underTrackGroupMembers)
        {
            AddEntities(underTrackGroupMembers);
        }

        public Guid GetGuid(string imei)
        {
            return GetEntity<UnderTrack>(l => l.Imei == imei).Id;
        }

        public UnderTrackRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
