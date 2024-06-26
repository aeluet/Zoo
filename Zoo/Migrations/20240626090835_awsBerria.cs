using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoo.Migrations
{
    /// <inheritdoc />
    public partial class awsBerria : Migration
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Izena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abizena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");


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

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2022, 5, 15), new DateOnly(2019, 3, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2021, 10, 20), new DateOnly(2018, 7, 5) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2023, 1, 8), new DateOnly(2020, 2, 15) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2020, 12, 3), new DateOnly(2017, 9, 22) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2023, 4, 25), new DateOnly(2020, 10, 30) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2022, 8, 12), new DateOnly(2019, 6, 18) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2021, 11, 30), new DateOnly(2019, 4, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2022, 9, 15), new DateOnly(2020, 1, 5) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2020, 7, 22), new DateOnly(2018, 10, 12) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2023, 2, 28), new DateOnly(2020, 8, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2021, 12, 10), new DateOnly(2019, 5, 3) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2022, 6, 5), new DateOnly(2019, 1, 18) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2023, 4, 12), new DateOnly(2020, 1, 30) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2023, 7, 19), new DateOnly(2021, 2, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2023, 8, 20), new DateOnly(2020, 12, 5) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 1, 15), new DateOnly(2021, 5, 25) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 3, 1), new DateOnly(2021, 9, 12) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 2, 10), new DateOnly(2021, 6, 25) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 3, 10), new DateOnly(2021, 8, 25) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 3, 15), new DateOnly(2021, 9, 2) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 3, 20), new DateOnly(2021, 9, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 3, 25), new DateOnly(2021, 9, 18) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 3, 28), new DateOnly(2021, 9, 22) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 5), new DateOnly(2021, 10, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 10), new DateOnly(2021, 10, 15) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 15), new DateOnly(2021, 10, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 20), new DateOnly(2021, 10, 25) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 25), new DateOnly(2021, 10, 30) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 30), new DateOnly(2021, 11, 5) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 5, 5), new DateOnly(2021, 11, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 5), new DateOnly(2021, 10, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 10), new DateOnly(2021, 10, 15) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 15), new DateOnly(2021, 10, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 20), new DateOnly(2021, 10, 25) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 25), new DateOnly(2021, 10, 30) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 30), new DateOnly(2021, 11, 5) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 5, 5), new DateOnly(2021, 11, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 5, 10), new DateOnly(2021, 11, 15) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 5, 15), new DateOnly(2021, 11, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 5), new DateOnly(2021, 10, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 10), new DateOnly(2021, 10, 15) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 5), new DateOnly(2021, 10, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 10), new DateOnly(2021, 10, 15) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 15), new DateOnly(2021, 10, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 5), new DateOnly(2021, 10, 10) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 10), new DateOnly(2021, 10, 15) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 15), new DateOnly(2021, 10, 20) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 20), new DateOnly(2021, 10, 25) });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Sarrera_data", "urte_betetzea" },
                values: new object[] { new DateOnly(2024, 4, 25), new DateOnly(2021, 10, 30) });

            migrationBuilder.AddColumn<string>(
               name: "Langile_Abizena",
               table: "AspNetUsers",
               type: "nvarchar(max)",
               nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Langile_Izena",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postua",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Turnoa",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);


            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageUrl",
                value: "\\images\\animalia\\charlie.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageUrl",
                value: "\\images\\animalia\\goliath.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageUrl",
                value: "\\images\\animalia\\ruby.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageUrl",
                value: "\\images\\animalia\\kenny.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageUrl",
                value: "\\images\\animalia\\sammy.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 6,
                column: "ImageUrl",
                value: "\\images\\animalia\\aurora.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 7,
                column: "ImageUrl",
                value: "\\images\\animalia\\eleanor.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 8,
                column: "ImageUrl",
                value: "\\images\\animalia\\felicia.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 9,
                column: "ImageUrl",
                value: "\\images\\animalia\\percy.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 10,
                column: "ImageUrl",
                value: "\\images\\animalia\\penny.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 11,
                column: "ImageUrl",
                value: "\\images\\animalia\\milo.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 12,
                column: "ImageUrl",
                value: "\\images\\animalia\\gracie.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 13,
                column: "ImageUrl",
                value: "\\images\\animalia\\eric.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 14,
                column: "ImageUrl",
                value: "\\images\\animalia\\fiona.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 15,
                column: "ImageUrl",
                value: "\\images\\animalia\\gerald.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 16,
                column: "ImageUrl",
                value: "\\images\\animalia\\katie.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 17,
                column: "ImageUrl",
                value: "\\images\\animalia\\manny.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 18,
                column: "ImageUrl",
                value: "\\images\\animalia\\zara.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 19,
                column: "ImageUrl",
                value: "\\images\\animalia\\leo.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 20,
                column: "ImageUrl",
                value: "\\images\\animalia\\luna.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 21,
                column: "ImageUrl",
                value: "\\images\\animalia\\max.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 22,
                column: "ImageUrl",
                value: "\\images\\animalia\\lola.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 23,
                column: "ImageUrl",
                value: "\\images\\animalia\\simba.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "ImageUrl", "Izena" },
                values: new object[] { "\\images\\animalia\\carlos.jpg", "Carlos the Cheerful Chimpanzee" });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 25,
                column: "ImageUrl",
                value: "\\images\\animalia\\chloe.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 26,
                column: "ImageUrl",
                value: "\\images\\animalia\\chip.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 27,
                column: "ImageUrl",
                value: "\\images\\animalia\\charlotte.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 28,
                column: "ImageUrl",
                value: "\\images\\animalia\\cooper.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 29,
                column: "ImageUrl",
                value: "\\images\\animalia\\cindy.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 30,
                column: "ImageUrl",
                value: "\\images\\animalia\\connor.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 31,
                column: "ImageUrl",
                value: "\\images\\animalia\\cleo.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 32,
                column: "ImageUrl",
                value: "\\images\\animalia\\paul.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 33,
                column: "ImageUrl",
                value: "\\images\\animalia\\poppy.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "ImageUrl", "Izena" },
                values: new object[] { "\\images\\animalia\\arturo.jpg", "Arturo the Pensive Penguin" });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "ImageUrl", "Izena" },
                values: new object[] { "\\images\\animalia\\pen.jpg", "Pen the Polite Penguin" });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 36,
                column: "ImageUrl",
                value: "\\images\\animalia\\pablo.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 37,
                column: "ImageUrl",
                value: "\\images\\animalia\\polly.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 38,
                column: "ImageUrl",
                value: "\\images\\animalia\\peter.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 39,
                column: "ImageUrl",
                value: "\\images\\animalia\\penelope.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 40,
                column: "ImageUrl",
                value: "\\images\\animalia\\patrick.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 41,
                column: "ImageUrl",
                value: "\\images\\animalia\\pippa.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "ImageUrl", "Izena" },
                values: new object[] { "\\images\\animalia\\sarita.jpg", "Sarita the Zany Zebra" });

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 43,
                column: "ImageUrl",
                value: "\\images\\animalia\\ziggy.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 44,
                column: "ImageUrl",
                value: "\\images\\animalia\\gus.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 45,
                column: "ImageUrl",
                value: "\\images\\animalia\\greta.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 46,
                column: "ImageUrl",
                value: "\\images\\animalia\\greg.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 47,
                column: "ImageUrl",
                value: "\\images\\animalia\\gigi.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 48,
                column: "ImageUrl",
                value: "\\images\\animalia\\rusty.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 49,
                column: "ImageUrl",
                value: "\\images\\animalia\\tony.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 50,
                column: "ImageUrl",
                value: "\\images\\animalia\\tara.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 51,
                column: "ImageUrl",
                value: "\\images\\animalia\\tim.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 52,
                column: "ImageUrl",
                value: "\\images\\animalia\\tess.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 53,
                column: "ImageUrl",
                value: "\\images\\animalia\\tyler.jpg");

            migrationBuilder.UpdateData(
                table: "Animaliak",
                keyColumn: "ID",
                keyValue: 54,
                column: "ImageUrl",
                value: "\\images\\animalia\\tina.jpg");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 5, "\\images\\arraza\\chimpanzee1.jpg", "Txinpantze" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "ID_lekua", "ImageUrl" },
                values: new object[] { 5, "\\images\\arraza\\gorilla1.jpg" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 4, "\\images\\arraza\\red-panda1.jpg", "Panda Gorria" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 1, "\\images\\arraza\\kangaroo1.jpg", "Kanguru" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "ImageUrl", "Izena" },
                values: new object[] { "\\images\\arraza\\sloth1.jpg", "Nagi" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "ImageUrl", "Izena" },
                values: new object[] { "\\images\\arraza\\artic-fox1.jpg", "Azeri artikoa" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 7,
                column: "ImageUrl",
                value: "\\images\\arraza\\elephant1.jpg");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 4, "\\images\\arraza\\flamingo1.jpg", "Flamenko" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 2, "\\images\\arraza\\polar-bear1.jpg", "Hartz zuri" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "ID_lekua", "ImageUrl" },
                values: new object[] { 2, "\\images\\arraza\\penguin1.jpg" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "ID_lekua", "ImageUrl" },
                values: new object[] { 3, "\\images\\arraza\\meerkat1.jpg" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "ID_lekua", "ImageUrl" },
                values: new object[] { 5, "\\images\\arraza\\gibbon1.jpg" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 3, "\\images\\arraza\\giraffe1.jpg", "Jirafa" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 14,
                column: "ImageUrl",
                value: "\\images\\arraza\\koala1.jpg");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 5, "\\images\\arraza\\monkey1.jpg", "Tximino" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 16,
                column: "ImageUrl",
                value: "\\images\\arraza\\zebra1.jpg");

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "ID_lekua", "ImageUrl", "Izena" },
                values: new object[] { 3, "\\images\\arraza\\lion1.jpg", "Lehoi" });

            migrationBuilder.UpdateData(
                table: "Arrazak",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "ID_lekua", "ImageUrl" },
                values: new object[] { 3, "\\images\\arraza\\tiger1.jpg" });

            migrationBuilder.UpdateData(
                table: "Lekuak",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Deskribapena", "Izena" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Australia" });

            migrationBuilder.UpdateData(
                table: "Lekuak",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Deskribapena", "Izena" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Artikoa" });

            migrationBuilder.UpdateData(
                table: "Lekuak",
                keyColumn: "ID",
                keyValue: 3,
                column: "Deskribapena",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit.");

            migrationBuilder.UpdateData(
                table: "Lekuak",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Deskribapena", "Izena" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Asia" });

            migrationBuilder.UpdateData(
                table: "Lekuak",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Deskribapena", "Izena" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Baso Tropikala" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
