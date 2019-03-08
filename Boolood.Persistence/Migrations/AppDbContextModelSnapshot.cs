﻿// <auto-generated />
using System;
using Ferdo.Track.Persistence.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ferdo.Track.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Track")
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.Center", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("ContractExpireTime");

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Centers");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.LocationPoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Accuracy");

                    b.Property<double>("Altitude");

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<string>("Imei");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<float>("Speed");

                    b.Property<long>("Time");

                    b.Property<Guid>("UnderTrackId");

                    b.HasKey("Id");

                    b.ToTable("LocationsPoints");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.SettingUnitLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SettingUnitLevels");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.TrackSetting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CenterId");

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<Guid>("GroupLevel");

                    b.Property<Guid?>("SettingUnitLevelId");

                    b.Property<TimeSpan>("TrackingEndTime");

                    b.Property<TimeSpan>("TrackingStartTime");

                    b.Property<Guid>("UnitId");

                    b.Property<int>("UpdateTimeSpeed");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.HasIndex("SettingUnitLevelId");

                    b.ToTable("UnderTrackSettings");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.UnderTrack", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CellNumber");

                    b.Property<Guid>("CenterId");

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<string>("Imei");

                    b.Property<string>("Name");

                    b.Property<Guid?>("UnderTrackGroupId");

                    b.Property<Guid>("UnderTrackTypeId");

                    b.HasKey("Id");

                    b.HasIndex("UnderTrackGroupId");

                    b.HasIndex("UnderTrackTypeId");

                    b.ToTable("UnderTracks");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.UnderTrackGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CenterId");

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CenterId");

                    b.ToTable("UnderTrackGroups");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.UnderTrackGroupMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<Guid>("GroupId");

                    b.Property<Guid?>("UnderTrackGroupId");

                    b.Property<Guid>("UnderTrackId");

                    b.HasKey("Id");

                    b.HasIndex("UnderTrackGroupId");

                    b.HasIndex("UnderTrackId");

                    b.ToTable("UnderTrackGroupMembers");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.UnderTrackType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreationDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UnderTrackTypes");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.TrackSetting", b =>
                {
                    b.HasOne("Ferdo.Track.Model.DbModels.Center")
                        .WithMany("UnderTrackSettings")
                        .HasForeignKey("CenterId");

                    b.HasOne("Ferdo.Track.Model.DbModels.SettingUnitLevel")
                        .WithMany("UnderTrackSettings")
                        .HasForeignKey("SettingUnitLevelId");
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.UnderTrack", b =>
                {
                    b.HasOne("Ferdo.Track.Model.DbModels.UnderTrackGroup", "UnderTrackGroup")
                        .WithMany("UnderTracks")
                        .HasForeignKey("UnderTrackGroupId");

                    b.HasOne("Ferdo.Track.Model.DbModels.UnderTrackType", "UnderTrackType")
                        .WithMany("UnderTracks")
                        .HasForeignKey("UnderTrackTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.UnderTrackGroup", b =>
                {
                    b.HasOne("Ferdo.Track.Model.DbModels.Center", "Center")
                        .WithMany("UnderTrackGroups")
                        .HasForeignKey("CenterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ferdo.Track.Model.DbModels.UnderTrackGroupMember", b =>
                {
                    b.HasOne("Ferdo.Track.Model.DbModels.UnderTrackGroup", "UnderTrackGroup")
                        .WithMany()
                        .HasForeignKey("UnderTrackGroupId");

                    b.HasOne("Ferdo.Track.Model.DbModels.UnderTrack", "UnderTrack")
                        .WithMany()
                        .HasForeignKey("UnderTrackId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
