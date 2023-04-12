using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bibliotheek.WPF.Migrations
{
    /// <inheritdoc />
    public partial class igration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "img",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_img", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Summary = table.Column<string>(type: "ntext", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "ntext", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: true),
                    ReleasedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Tags = table.Column<string>(type: "ntext", nullable: true),
                    Img_idId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_author_img_Img_idId",
                        column: x => x.Img_idId,
                        principalTable: "img",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Img_idId = table.Column<int>(type: "int", nullable: true),
                    Phonenumber = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_img_Img_idId",
                        column: x => x.Img_idId,
                        principalTable: "img",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuthorModelItemModel",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    ItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorModelItemModel", x => new { x.AuthorId, x.ItemsId });
                    table.ForeignKey(
                        name: "FK_AuthorModelItemModel_author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorModelItemModel_item_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "FirstName", "Img_idId", "LastName", "Location", "Phonenumber", "Role" },
                values: new object[,]
                {
                    { 1, null, "Simonis", null, "Simonis", null, 451867, 1 },
                    { 2, null, "Klocko", null, "Klocko", null, 553476, 2 },
                    { 3, null, "Crooks", null, "Crooks", null, 544159, 1 },
                    { 4, null, "Koepp", null, "Koepp", null, 159408, 2 },
                    { 5, null, "Nienow", null, "Nienow", null, 371969, 1 },
                    { 6, null, "Reinger", null, "Reinger", null, 525252, 1 },
                    { 7, null, "Nitzsche", null, "Nitzsche", null, 793941, 2 },
                    { 8, null, "Rogahn", null, "Rogahn", null, 786408, 1 },
                    { 9, null, "Emmerich", null, "Emmerich", null, 830713, 1 },
                    { 10, null, "Durgan", null, "Durgan", null, 620668, 2 },
                    { 11, null, "Kshlerin", null, "Kshlerin", null, 670246, 1 },
                    { 12, null, "Gerlach", null, "Gerlach", null, 513533, 2 },
                    { 13, null, "Harvey", null, "Harvey", null, 588898, 2 },
                    { 14, null, "Moen", null, "Moen", null, 713356, 2 },
                    { 15, null, "Lang", null, "Lang", null, 520035, 1 },
                    { 16, null, "Corwin", null, "Corwin", null, 323327, 2 },
                    { 17, null, "Hane", null, "Hane", null, 724191, 1 },
                    { 18, null, "VonRueden", null, "VonRueden", null, 78236, 2 },
                    { 19, null, "Prohaska", null, "Prohaska", null, 137069, 2 },
                    { 20, null, "Hudson", null, "Hudson", null, 688228, 2 },
                    { 21, null, "Kub", null, "Kub", null, 984349, 2 },
                    { 22, null, "Gutmann", null, "Gutmann", null, 428004, 2 },
                    { 23, null, "Gaylord", null, "Gaylord", null, 645756, 1 },
                    { 24, null, "Sipes", null, "Sipes", null, 112874, 1 },
                    { 25, null, "Littel", null, "Littel", null, 215318, 2 },
                    { 26, null, "Dicki", null, "Dicki", null, 576699, 2 },
                    { 27, null, "Batz", null, "Batz", null, 263040, 1 },
                    { 28, null, "Farrell", null, "Farrell", null, 501813, 1 },
                    { 29, null, "Glover", null, "Glover", null, 890564, 1 },
                    { 30, null, "Prohaska", null, "Prohaska", null, 53924, 2 },
                    { 31, null, "Schultz", null, "Schultz", null, 886217, 1 },
                    { 32, null, "Russel", null, "Russel", null, 288398, 2 },
                    { 33, null, "Heller", null, "Heller", null, 821967, 1 },
                    { 34, null, "Smitham", null, "Smitham", null, 952901, 2 },
                    { 35, null, "Stehr", null, "Stehr", null, 559622, 1 },
                    { 36, null, "Keebler", null, "Keebler", null, 472973, 2 },
                    { 37, null, "Cummerata", null, "Cummerata", null, 182453, 2 },
                    { 38, null, "Kirlin", null, "Kirlin", null, 992672, 2 },
                    { 39, null, "Muller", null, "Muller", null, 230397, 1 },
                    { 40, null, "Gibson", null, "Gibson", null, 755249, 2 },
                    { 41, null, "Anderson", null, "Anderson", null, 475580, 2 },
                    { 42, null, "Klocko", null, "Klocko", null, 984010, 2 },
                    { 43, null, "Hills", null, "Hills", null, 14064, 1 },
                    { 44, null, "Kutch", null, "Kutch", null, 848768, 2 },
                    { 45, null, "Borer", null, "Borer", null, 871566, 2 },
                    { 46, null, "Adams", null, "Adams", null, 31929, 1 },
                    { 47, null, "Schmitt", null, "Schmitt", null, 19110, 1 },
                    { 48, null, "Daniel", null, "Daniel", null, 762410, 1 },
                    { 49, null, "Dibbert", null, "Dibbert", null, 229704, 1 },
                    { 50, null, "Emmerich", null, "Emmerich", null, 590582, 2 },
                    { 51, null, "Mertz", null, "Mertz", null, 803386, 1 },
                    { 52, null, "Walter", null, "Walter", null, 186461, 1 },
                    { 53, null, "Ziemann", null, "Ziemann", null, 751390, 2 },
                    { 54, null, "Stark", null, "Stark", null, 871984, 1 },
                    { 55, null, "Mertz", null, "Mertz", null, 161409, 1 },
                    { 56, null, "Rau", null, "Rau", null, 55749, 1 },
                    { 57, null, "Hackett", null, "Hackett", null, 829006, 2 },
                    { 58, null, "Hickle", null, "Hickle", null, 556540, 2 },
                    { 59, null, "Witting", null, "Witting", null, 246308, 1 },
                    { 60, null, "Thompson", null, "Thompson", null, 839983, 2 },
                    { 61, null, "Blanda", null, "Blanda", null, 187295, 1 },
                    { 62, null, "Mante", null, "Mante", null, 152826, 1 },
                    { 63, null, "Harber", null, "Harber", null, 959554, 1 },
                    { 64, null, "Flatley", null, "Flatley", null, 802095, 2 },
                    { 65, null, "Lockman", null, "Lockman", null, 813755, 1 },
                    { 66, null, "Bergstrom", null, "Bergstrom", null, 730401, 1 },
                    { 67, null, "Botsford", null, "Botsford", null, 449724, 1 },
                    { 68, null, "Beatty", null, "Beatty", null, 808368, 1 },
                    { 69, null, "Boyle", null, "Boyle", null, 780146, 2 },
                    { 70, null, "Ruecker", null, "Ruecker", null, 461486, 2 },
                    { 71, null, "Cormier", null, "Cormier", null, 134351, 1 },
                    { 72, null, "Grimes", null, "Grimes", null, 579524, 1 },
                    { 73, null, "Nikolaus", null, "Nikolaus", null, 655786, 1 },
                    { 74, null, "Wilderman", null, "Wilderman", null, 826793, 1 },
                    { 75, null, "Conroy", null, "Conroy", null, 486604, 2 },
                    { 76, null, "Kovacek", null, "Kovacek", null, 787440, 2 },
                    { 77, null, "Grady", null, "Grady", null, 443132, 2 },
                    { 78, null, "Zboncak", null, "Zboncak", null, 109120, 1 },
                    { 79, null, "Olson", null, "Olson", null, 988641, 2 },
                    { 80, null, "Swift", null, "Swift", null, 41280, 1 },
                    { 81, null, "Barton", null, "Barton", null, 74965, 2 },
                    { 82, null, "Weber", null, "Weber", null, 157925, 2 },
                    { 83, null, "Jerde", null, "Jerde", null, 684555, 2 },
                    { 84, null, "Davis", null, "Davis", null, 241239, 1 },
                    { 85, null, "Johns", null, "Johns", null, 39989, 1 },
                    { 86, null, "Cruickshank", null, "Cruickshank", null, 208699, 2 },
                    { 87, null, "Dickinson", null, "Dickinson", null, 597747, 2 },
                    { 88, null, "Beahan", null, "Beahan", null, 897952, 1 },
                    { 89, null, "Klein", null, "Klein", null, 749815, 2 },
                    { 90, null, "Kling", null, "Kling", null, 635715, 1 },
                    { 91, null, "Jakubowski", null, "Jakubowski", null, 198415, 1 },
                    { 92, null, "Crist", null, "Crist", null, 64645, 2 },
                    { 93, null, "Runte", null, "Runte", null, 310401, 2 },
                    { 94, null, "Grimes", null, "Grimes", null, 797745, 2 },
                    { 95, null, "Gutmann", null, "Gutmann", null, 447972, 2 },
                    { 96, null, "Zieme", null, "Zieme", null, 319310, 2 },
                    { 97, null, "Jakubowski", null, "Jakubowski", null, 169789, 2 },
                    { 98, null, "Kunde", null, "Kunde", null, 662804, 2 },
                    { 99, null, "Nikolaus", null, "Nikolaus", null, 191785, 2 },
                    { 100, null, "Dickens", null, "Dickens", null, 737610, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_author_Img_idId",
                table: "author",
                column: "Img_idId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorModelItemModel_ItemsId",
                table: "AuthorModelItemModel",
                column: "ItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Img_idId",
                table: "Users",
                column: "Img_idId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorModelItemModel");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "author");

            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "img");
        }
    }
}
