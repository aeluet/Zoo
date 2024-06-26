using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Zoo.Migrations
{
    /// <inheritdoc />
    public partial class addAnimaliakToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Animalia",
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

            migrationBuilder.InsertData(
                table: "Arrazak",
                columns: new[] { "ID", "Deskribapena", "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 7, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 3, "", "Elephant" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animalia");

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
