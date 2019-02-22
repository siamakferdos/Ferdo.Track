using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferdo.Track.Persistence.Migrations
{
    public partial class init_tracking_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Track");

            migrationBuilder.CreateTable(
                name: "Centers",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ContractExpireTime = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocationsPoints",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    Imei = table.Column<string>(nullable: true),
                    UnderTrackId = table.Column<Guid>(nullable: false),
                    Accuracy = table.Column<float>(nullable: false),
                    Altitude = table.Column<double>(nullable: false),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Speed = table.Column<float>(nullable: false),
                    Time = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationsPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SettingUnitLevels",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingUnitLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnderTrackTypes",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderTrackTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnderTrackSettings",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    UnitId = table.Column<Guid>(nullable: false),
                    GroupLevel = table.Column<Guid>(nullable: false),
                    TrackingStartTime = table.Column<TimeSpan>(nullable: false),
                    TrackingEndTime = table.Column<TimeSpan>(nullable: false),
                    UpdateTimeSpeed = table.Column<int>(nullable: false),
                    CenterId = table.Column<Guid>(nullable: true),
                    SettingUnitLevelId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderTrackSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderTrackSettings_Centers_CenterId",
                        column: x => x.CenterId,
                        principalSchema: "Track",
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderTrackSettings_SettingUnitLevels_SettingUnitLevelId",
                        column: x => x.SettingUnitLevelId,
                        principalSchema: "Track",
                        principalTable: "SettingUnitLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderTrackGroups",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    CenterId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UnderTrackTypeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderTrackGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderTrackGroups_Centers_CenterId",
                        column: x => x.CenterId,
                        principalSchema: "Track",
                        principalTable: "Centers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnderTrackGroups_UnderTrackTypes_UnderTrackTypeId",
                        column: x => x.UnderTrackTypeId,
                        principalSchema: "Track",
                        principalTable: "UnderTrackTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UnderTracks",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UnderTrackTypeId = table.Column<Guid>(nullable: false),
                    Imei = table.Column<string>(nullable: true),
                    CellNumber = table.Column<string>(nullable: true),
                    UnderTrackGroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderTracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderTracks_UnderTrackGroups_UnderTrackGroupId",
                        column: x => x.UnderTrackGroupId,
                        principalSchema: "Track",
                        principalTable: "UnderTrackGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderTracks_UnderTrackTypes_UnderTrackTypeId",
                        column: x => x.UnderTrackTypeId,
                        principalSchema: "Track",
                        principalTable: "UnderTrackTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnderTrackGroups_CenterId",
                schema: "Track",
                table: "UnderTrackGroups",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderTrackGroups_UnderTrackTypeId",
                schema: "Track",
                table: "UnderTrackGroups",
                column: "UnderTrackTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderTracks_UnderTrackGroupId",
                schema: "Track",
                table: "UnderTracks",
                column: "UnderTrackGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderTracks_UnderTrackTypeId",
                schema: "Track",
                table: "UnderTracks",
                column: "UnderTrackTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderTrackSettings_CenterId",
                schema: "Track",
                table: "UnderTrackSettings",
                column: "CenterId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderTrackSettings_SettingUnitLevelId",
                schema: "Track",
                table: "UnderTrackSettings",
                column: "SettingUnitLevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocationsPoints",
                schema: "Track");

            migrationBuilder.DropTable(
                name: "UnderTracks",
                schema: "Track");

            migrationBuilder.DropTable(
                name: "UnderTrackSettings",
                schema: "Track");

            migrationBuilder.DropTable(
                name: "UnderTrackGroups",
                schema: "Track");

            migrationBuilder.DropTable(
                name: "SettingUnitLevels",
                schema: "Track");

            migrationBuilder.DropTable(
                name: "Centers",
                schema: "Track");

            migrationBuilder.DropTable(
                name: "UnderTrackTypes",
                schema: "Track");
        }
    }
}
