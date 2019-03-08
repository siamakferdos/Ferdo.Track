using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferdo.Track.Persistence.Migrations
{
    public partial class add_centerId_underTrackGroupMemeber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnderTrackGroups_UnderTrackTypes_UnderTrackTypeId",
                schema: "Track",
                table: "UnderTrackGroups");

            migrationBuilder.DropIndex(
                name: "IX_UnderTrackGroups_UnderTrackTypeId",
                schema: "Track",
                table: "UnderTrackGroups");

            migrationBuilder.DropColumn(
                name: "UnderTrackTypeId",
                schema: "Track",
                table: "UnderTrackGroups");

            migrationBuilder.AddColumn<Guid>(
                name: "CenterId",
                schema: "Track",
                table: "UnderTracks",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "UnderTrackGroupMembers",
                schema: "Track",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false),
                    UnderTrackId = table.Column<Guid>(nullable: false),
                    UnderTrackGroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnderTrackGroupMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnderTrackGroupMembers_UnderTrackGroups_UnderTrackGroupId",
                        column: x => x.UnderTrackGroupId,
                        principalSchema: "Track",
                        principalTable: "UnderTrackGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnderTrackGroupMembers_UnderTracks_UnderTrackId",
                        column: x => x.UnderTrackId,
                        principalSchema: "Track",
                        principalTable: "UnderTracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnderTrackGroupMembers_UnderTrackGroupId",
                schema: "Track",
                table: "UnderTrackGroupMembers",
                column: "UnderTrackGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UnderTrackGroupMembers_UnderTrackId",
                schema: "Track",
                table: "UnderTrackGroupMembers",
                column: "UnderTrackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnderTrackGroupMembers",
                schema: "Track");

            migrationBuilder.DropColumn(
                name: "CenterId",
                schema: "Track",
                table: "UnderTracks");

            migrationBuilder.AddColumn<Guid>(
                name: "UnderTrackTypeId",
                schema: "Track",
                table: "UnderTrackGroups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnderTrackGroups_UnderTrackTypeId",
                schema: "Track",
                table: "UnderTrackGroups",
                column: "UnderTrackTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UnderTrackGroups_UnderTrackTypes_UnderTrackTypeId",
                schema: "Track",
                table: "UnderTrackGroups",
                column: "UnderTrackTypeId",
                principalSchema: "Track",
                principalTable: "UnderTrackTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
