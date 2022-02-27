using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Protection_civile.Migrations
{
    public partial class demande : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Demande",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(nullable: true),
                    prenom = table.Column<string>(nullable: true),
                    tel = table.Column<int>(nullable: false),
                    numcin = table.Column<string>(nullable: true),
                    nomentreprise = table.Column<string>(nullable: true),
                    adresse = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    categorie = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    numdemande = table.Column<string>(nullable: true),
                    numrecu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demande", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demande");
        }
    }
}
