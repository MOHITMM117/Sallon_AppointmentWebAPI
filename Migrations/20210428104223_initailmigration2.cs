using Microsoft.EntityFrameworkCore.Migrations;

namespace Sallon_Appointment_API.Migrations
{
    public partial class initailmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sallon",
                newName: "Sallon_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sallon_ID",
                table: "Sallon",
                newName: "Id");
        }
    }
}
