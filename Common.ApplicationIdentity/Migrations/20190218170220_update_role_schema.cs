using Microsoft.EntityFrameworkCore.Migrations;

namespace Common.ApplicationIdentity.Migrations
{
    public partial class update_role_schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Identity",
                table: "AspNetRoles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Identity",
                table: "AspNetRoles");
        }
    }
}
