using Microsoft.EntityFrameworkCore.Migrations;

namespace Sallon_Appointment_API.Migrations
{
    public partial class initailmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sallon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hairdresser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Haircut = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sallon", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sallon");
        }
    }
}
