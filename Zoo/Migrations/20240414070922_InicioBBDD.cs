using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Zoo.Migrations
{
    /// <inheritdoc />
    public partial class InicioBBDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lekuak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Izena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deskribapena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lekuak", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Arrazak",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Izena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deskribapena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_lekua = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrazak", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Arrazak_Lekuak_ID_lekua",
                        column: x => x.ID_lekua,
                        principalTable: "Lekuak",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Lekuak",
                columns: new[] { "ID", "Deskribapena", "Izena" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.", "Interior1" },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.", "Interior2" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.", "Sabana" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.", "Lago" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed blandit vitae nunc vel consequat. Nulla euismod ex arcu, id ullamcorper nisi consequat ac. Fusce porta libero erat, sit amet fermentum libero ultricies feugiat. Mauris varius placerat accumsan. Aenean ornare orci quis arcu varius sagittis. Mauris rutrum augue vel ex aliquam, quis molestie dui rutrum. Sed vel augue iaculis metus imperdiet blandit in in justo. Sed efficitur leo at ornare varius. Nullam tincidunt nisl id ultrices convallis. Morbi volutpat turpis at ligula finibus, vel tincidunt mauris bibendum. Nullam auctor tellus quis porta ornare.", "Bosque" }
                });

            migrationBuilder.InsertData(
                table: "Arrazak",
                columns: new[] { "ID", "Deskribapena", "ID_lekua", "ImageUrl", "Izena" },
                values: new object[,]
                {
                    { 1, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 1, "", "Tigre" },
                    { 2, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 2, "", "Leon" },
                    { 3, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 3, "", "Pato" },
                    { 4, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 4, "", "Panda" },
                    { 5, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 5, "", "Conejo" },
                    { 6, "Donec ante enim, imperdiet non metus a, aliquet fermentum tortor. Etiam sem nunc, ornare id dignissim non, congue at nulla. Integer semper leo nisl, ac tincidunt libero aliquam id. Morbi quis ornare eros. Nunc at ultricies mi. Aliquam vitae bibendum metus. Aenean venenatis cursus sapien. Vivamus feugiat egestas urna.", 2, "", "Delfin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arrazak_ID_lekua",
                table: "Arrazak",
                column: "ID_lekua");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arrazak");

            migrationBuilder.DropTable(
                name: "Lekuak");
        }
    }
}
