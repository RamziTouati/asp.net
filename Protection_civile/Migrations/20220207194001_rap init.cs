using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Protection_civile.Migrations
{
    public partial class rapinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attestation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateN = table.Column<DateTime>(nullable: false),
                    DemandeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attestation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attestation_Demande_DemandeId",
                        column: x => x.DemandeId,
                        principalTable: "Demande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paiement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numreçupaiement = table.Column<string>(nullable: true),
                    DateN = table.Column<DateTime>(nullable: false),
                    DemandeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paiement_Demande_DemandeId",
                        column: x => x.DemandeId,
                        principalTable: "Demande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RapportFinal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateN = table.Column<DateTime>(nullable: false),
                    DemandeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapportFinal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RapportFinal_Demande_DemandeId",
                        column: x => x.DemandeId,
                        principalTable: "Demande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RapportInitial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateN = table.Column<DateTime>(nullable: false),
                    description = table.Column<string>(nullable: true),
                    DemandeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapportInitial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RapportInitial_Demande_DemandeId",
                        column: x => x.DemandeId,
                        principalTable: "Demande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attestation_DemandeId",
                table: "Attestation",
                column: "DemandeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paiement_DemandeId",
                table: "Paiement",
                column: "DemandeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RapportFinal_DemandeId",
                table: "RapportFinal",
                column: "DemandeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RapportInitial_DemandeId",
                table: "RapportInitial",
                column: "DemandeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attestation");

            migrationBuilder.DropTable(
                name: "Paiement");

            migrationBuilder.DropTable(
                name: "RapportFinal");

            migrationBuilder.DropTable(
                name: "RapportInitial");
        }
    }
}
