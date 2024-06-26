using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Zoo.Migrations
{
    /// <inheritdoc />
    public partial class NewAnimaliakEtaArrazak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 1,
                column: "Izena",
                value: "Charlie the Charming Chimpanzee");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ID_arraza", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[] { 2, "Goliath the Gentle Giant Gorilla", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ID_arraza", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[] { 3, "Ruby the Radiant Red Panda", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) });

            migrationBuilder.InsertData(
                table: "Animaliak",
                columns: new[] { "ID", "ID_arraza", "ImageUrl", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[,]
                {
                    { 4, 4, "", "Kenny the Kicking Kangaroo", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 5, 5, "", "Sammy the Sleepy Sloth", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 6, 6, "", "Aurora the Agile Arctic Fox", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 7, 7, "", "Eleanor the Elegant Elephant", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 13, 7, "", "Eric the Enthusiastic Elephant", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 24, 1, "", "Charlie the Cheerful Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 25, 1, "", "Chloe the Charming Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 26, 1, "", "Chip the Clever Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 27, 1, "", "Charlotte the Curious Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 28, 1, "", "Cooper the Confident Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 29, 1, "", "Cindy the Cute Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 30, 1, "", "Connor the Cuddly Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 31, 1, "", "Cleo the Creative Chimpanzee", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 44, 2, "", "Gus the Gentle Giant Gorilla", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 45, 2, "", "Greta the Gracious Gorilla", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 46, 2, "", "Greg the Gentle Gorilla", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 47, 2, "", "Gigi the Gorgeous Gorilla", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 48, 3, "", "Rusty the Radiant Red Panda", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) }
                });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 1,
                column: "Izena",
                value: "Chimpanze");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 2,
                column: "Izena",
                value: "Gorila");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 3,
                column: "Izena",
                value: "Panda Rojo");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 4,
                column: "Izena",
                value: "Canguro");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 5,
                column: "Izena",
                value: "Perezoso");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 6,
                column: "Izena",
                value: "Zorro artico");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 7,
                column: "Izena",
                value: "Elefante");

            migrationBuilder.InsertData(
                table: "Arrazak",
                columns: new[] { "ID", "Deskribapena", "ID_lekua", "ImageUrl", "Izena" },
                values: new object[,]
                {
                    { 8, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 2, "", "Flamenco" },
                    { 9, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 4, "", "Oso polar" },
                    { 10, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 4, "", "Pinguino" },
                    { 11, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 2, "", "Surikata" },
                    { 12, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 2, "", "Giboi" },
                    { 13, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 1, "", "Girafa" },
                    { 14, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 1, "", "Koala" },
                    { 15, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 3, "", "Mono" },
                    { 16, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 3, "", "Zebra" },
                    { 17, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 5, "", "Leon" },
                    { 18, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 5, "", "Tigre" }
                });

            migrationBuilder.InsertData(
                table: "Animaliak",
                columns: new[] { "ID", "ID_arraza", "ImageUrl", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[,]
                {
                    { 8, 8, "", "Felicia the Flamboyant Flamingo", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 9, 9, "", "Percy the Playful Polar Bear", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 10, 10, "", "Penny the Perky Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 11, 11, "", "Milo the Mischievous Meerkat", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 12, 12, "", "Gracie the Graceful Gibbon", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 14, 8, "", "Fiona the Fancy Flamingo", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 15, 13, "", "Gerald the Gentle Giraffe", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 16, 14, "", "Katie the Cuddly Koala", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 17, 15, "", "Manny the Merry Monkey", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 18, 16, "", "Zara the Zesty Zebra", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 19, 17, "", "Leo the Majestic Lion", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 20, 17, "", "Luna the Fierce Lioness", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 21, 17, "", "Max the Mighty Lion", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 22, 17, "", "Lola the Lovely Lioness", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 23, 17, "", "Simba the Courageous Lion", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 32, 10, "", "Paul the Playful Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 33, 10, "", "Poppy the Perky Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 34, 10, "", "Percy the Pensive Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 35, 10, "", "Penny the Polite Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 36, 10, "", "Pablo the Playful Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 37, 10, "", "Polly the Prancing Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 38, 10, "", "Peter the Peaceful Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 39, 10, "", "Penelope the Patient Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 40, 10, "", "Patrick the Playful Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 41, 10, "", "Pippa the Prankster Penguin", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 42, 16, "", "Zara the Zany Zebra", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 43, 16, "", "Ziggy the Zippy Zebra", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 49, 18, "", "Tony the Terrific Tiger", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 50, 18, "", "Tara the Tremendous Tiger", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 51, 18, "", "Tim the Tenacious Tiger", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 52, 18, "", "Tess the Fearless Tiger", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 53, 18, "", "Tyler the Triumphant Tiger", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) },
                    { 54, 18, "", "Tina the Tenacious Tiger", new DateOnly(2024, 4, 1), new DateOnly(2021, 10, 5) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 1,
                column: "Izena",
                value: "Tony the Terrific Tige");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ID_arraza", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[] { 7, "Eric the Enthusiastic Elephant", new DateOnly(202, 11, 30), new DateOnly(2019, 4, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ID_arraza", "Izena", "Sarrera_data", "urte_betetzea" },
                values: new object[] { 1, "Tara the Tremendous Tiger", new DateOnly(2021, 4, 5), new DateOnly(2021, 10, 10) });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 1,
                column: "Izena",
                value: "Tigre");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 2,
                column: "Izena",
                value: "Leon");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 3,
                column: "Izena",
                value: "Pato");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 4,
                column: "Izena",
                value: "Panda");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 5,
                column: "Izena",
                value: "Conejo");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 6,
                column: "Izena",
                value: "Delfin");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 7,
                column: "Izena",
                value: "Elephant");
        }
    }
}
