using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Zoo.Migrations
{
    /// <inheritdoc />
    public partial class PorSiAcaso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animalia");

            migrationBuilder.CreateTable(
                name: "Animaliak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Izena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sarrera_data = table.Column<DateOnly>(type: "date", nullable: false),
                    urte_betetzea = table.Column<DateOnly>(type: "date", nullable: false),
                    ID_arraza = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animaliak", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Animaliak_Arrazak_ID_arraza",
                        column: x => x.ID_arraza,
                        principalTable: "Arrazak",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Animaliak",
                columns: new[] { "ID", "ID_arraza", "ImageUrl", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[,]
                {
                    { 1, 1, "", "Tony the Terrific Tige", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 2, 7, "", "Eric the Enthusiastic Elephant", new DateOnly(202, 11, 30), new DateOnly(2019, 4, 20) },
                    { 3, 1, "", "Tara the Tremendous Tiger", new DateOnly(2021, 4, 5), new DateOnly(2021, 10, 10) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animaliak_ID_arraza",
                table: "Animaliak",
                column: "ID_arraza");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animaliak");

            migrationBuilder.CreateTable(
                name: "Animalia",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_arraza = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Izena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sarrera_data = table.Column<DateOnly>(type: "date", nullable: false),
                    urte_betetzea = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animalia", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Animalia",
                columns: new[] { "ID", "ID_arraza", "ImageUrl", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[,]
                {
                    { 1, 1, "", "Tony the Terrific Tige", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 2, 7, "", "Eric the Enthusiastic Elephant", new DateOnly(202, 11, 30), new DateOnly(2019, 4, 20) },
                    { 3, 1, "", "Tara the Tremendous Tiger", new DateOnly(2021, 4, 5), new DateOnly(2021, 10, 10) }
                });
        }
    }
}
