using Ferdo.Track.Model.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Ferdo.Track.Persistence.DbContext
{
    public class AppDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Track");
        }
       
        public DbSet<LocationPoint> LocationsPoints { get; set; }
        public DbSet<UnderTrack> UnderTracks { get; set; }
        public DbSet<UnderTrackGroup> UnderTrackGroups { get; set; }
        public DbSet<SettingUnitLevel> SettingUnitLevels { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<UnderTrackType> UnderTrackTypes { get; set; }
        public DbSet<TrackSetting> UnderTrackSettings { get; set; }
        public DbSet<UnderTrackGroupMember> UnderTrackGroupMembers { get; set; }
    }
}
