using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Protection_civile.Migrations
{
    public partial class newattrri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Datev",
                table: "RapportInitial",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "numri",
                table: "RapportInitial",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Datev",
                table: "RapportInitial");

            migrationBuilder.DropColumn(
                name: "numri",
                table: "RapportInitial");
        }
    }
}
