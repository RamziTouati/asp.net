using Microsoft.EntityFrameworkCore.Migrations;

namespace Protection_civile.Migrations
{
    public partial class addrapportfinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numrf",
                table: "RapportFinal",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numrf",
                table: "RapportFinal");
        }
    }
}
