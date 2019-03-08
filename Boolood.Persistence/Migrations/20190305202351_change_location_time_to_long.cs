using Microsoft.EntityFrameworkCore.Migrations;

namespace Ferdo.Track.Persistence.Migrations
{
    public partial class change_location_time_to_long : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Time",
                schema: "Track",
                table: "LocationsPoints",
                nullable: false,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Time",
                schema: "Track",
                table: "LocationsPoints",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
