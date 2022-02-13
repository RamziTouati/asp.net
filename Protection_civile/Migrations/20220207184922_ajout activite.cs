using Microsoft.EntityFrameworkCore.Migrations;

namespace Protection_civile.Migrations
{
    public partial class ajoutactivite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "activite",
                table: "Demande",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "activite",
                table: "Demande");
        }
    }
}
