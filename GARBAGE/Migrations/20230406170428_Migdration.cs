using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GARBAGE.Migrations
{
    /// <inheritdoc />
    public partial class Migdration : Migration
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
                    { 1, null, "Schimmel", null, "Schimmel", null, 441506, 1 },
                    { 2, null, "Cruickshank", null, "Cruickshank", null, 243479, 2 },
                    { 3, null, "Hodkiewicz", null, "Hodkiewicz", null, 857827, 1 },
                    { 4, null, "Kub", null, "Kub", null, 975219, 2 },
                    { 5, null, "O'Conner", null, "O'Conner", null, 484381, 1 },
                    { 6, null, "Denesik", null, "Denesik", null, 846627, 1 },
                    { 7, null, "Schaden", null, "Schaden", null, 164362, 1 },
                    { 8, null, "Cronin", null, "Cronin", null, 854459, 2 },
                    { 9, null, "Bailey", null, "Bailey", null, 740357, 2 },
                    { 10, null, "Price", null, "Price", null, 159927, 1 },
                    { 11, null, "Feest", null, "Feest", null, 312278, 1 },
                    { 12, null, "Tromp", null, "Tromp", null, 124643, 2 },
                    { 13, null, "Renner", null, "Renner", null, 468117, 1 },
                    { 14, null, "Gerlach", null, "Gerlach", null, 763680, 1 },
                    { 15, null, "Hagenes", null, "Hagenes", null, 669401, 2 },
                    { 16, null, "White", null, "White", null, 987935, 2 },
                    { 17, null, "Russel", null, "Russel", null, 106020, 2 },
                    { 18, null, "Prosacco", null, "Prosacco", null, 6825, 2 },
                    { 19, null, "Kirlin", null, "Kirlin", null, 773277, 2 },
                    { 20, null, "Simonis", null, "Simonis", null, 223903, 2 },
                    { 21, null, "Brakus", null, "Brakus", null, 635287, 2 },
                    { 22, null, "Bogisich", null, "Bogisich", null, 84227, 1 },
                    { 23, null, "Hoppe", null, "Hoppe", null, 140532, 1 },
                    { 24, null, "Halvorson", null, "Halvorson", null, 734882, 1 },
                    { 25, null, "Ankunding", null, "Ankunding", null, 309575, 1 },
                    { 26, null, "Kutch", null, "Kutch", null, 218194, 1 },
                    { 27, null, "Upton", null, "Upton", null, 747918, 2 },
                    { 28, null, "Conroy", null, "Conroy", null, 278150, 2 },
                    { 29, null, "Bogisich", null, "Bogisich", null, 823036, 1 },
                    { 30, null, "Ruecker", null, "Ruecker", null, 382851, 1 },
                    { 31, null, "O'Kon", null, "O'Kon", null, 397585, 2 },
                    { 32, null, "Bogisich", null, "Bogisich", null, 431235, 2 },
                    { 33, null, "Zieme", null, "Zieme", null, 487369, 2 },
                    { 34, null, "Predovic", null, "Predovic", null, 915485, 2 },
                    { 35, null, "Robel", null, "Robel", null, 426770, 2 },
                    { 36, null, "Christiansen", null, "Christiansen", null, 694706, 2 },
                    { 37, null, "Auer", null, "Auer", null, 861594, 2 },
                    { 38, null, "Haley", null, "Haley", null, 943643, 1 },
                    { 39, null, "Hintz", null, "Hintz", null, 256456, 1 },
                    { 40, null, "Fadel", null, "Fadel", null, 192498, 1 },
                    { 41, null, "Schultz", null, "Schultz", null, 659383, 1 },
                    { 42, null, "Kshlerin", null, "Kshlerin", null, 952990, 2 },
                    { 43, null, "Christiansen", null, "Christiansen", null, 729679, 1 },
                    { 44, null, "Kunde", null, "Kunde", null, 588432, 1 },
                    { 45, null, "Feeney", null, "Feeney", null, 784030, 2 },
                    { 46, null, "Lang", null, "Lang", null, 20799, 2 },
                    { 47, null, "Jerde", null, "Jerde", null, 763559, 2 },
                    { 48, null, "MacGyver", null, "MacGyver", null, 301274, 1 },
                    { 49, null, "Kiehn", null, "Kiehn", null, 961647, 2 },
                    { 50, null, "Schowalter", null, "Schowalter", null, 563128, 1 },
                    { 51, null, "Beahan", null, "Beahan", null, 124577, 2 },
                    { 52, null, "Sauer", null, "Sauer", null, 295319, 1 },
                    { 53, null, "Kutch", null, "Kutch", null, 134460, 2 },
                    { 54, null, "Gerlach", null, "Gerlach", null, 496333, 2 },
                    { 55, null, "Reinger", null, "Reinger", null, 192542, 2 },
                    { 56, null, "Rath", null, "Rath", null, 876726, 1 },
                    { 57, null, "Kreiger", null, "Kreiger", null, 707951, 1 },
                    { 58, null, "Goyette", null, "Goyette", null, 851967, 1 },
                    { 59, null, "Zboncak", null, "Zboncak", null, 472614, 2 },
                    { 60, null, "Beahan", null, "Beahan", null, 178491, 1 },
                    { 61, null, "Purdy", null, "Purdy", null, 708059, 1 },
                    { 62, null, "Grant", null, "Grant", null, 521064, 2 },
                    { 63, null, "Will", null, "Will", null, 40818, 1 },
                    { 64, null, "Donnelly", null, "Donnelly", null, 867158, 2 },
                    { 65, null, "Runolfsdottir", null, "Runolfsdottir", null, 271066, 2 },
                    { 66, null, "Morissette", null, "Morissette", null, 153158, 1 },
                    { 67, null, "Greenfelder", null, "Greenfelder", null, 76697, 1 },
                    { 68, null, "Rodriguez", null, "Rodriguez", null, 477820, 2 },
                    { 69, null, "Borer", null, "Borer", null, 307982, 1 },
                    { 70, null, "Becker", null, "Becker", null, 754735, 2 },
                    { 71, null, "Boyer", null, "Boyer", null, 380432, 1 },
                    { 72, null, "Gerhold", null, "Gerhold", null, 15271, 1 },
                    { 73, null, "Corwin", null, "Corwin", null, 412210, 2 },
                    { 74, null, "Waelchi", null, "Waelchi", null, 231305, 2 },
                    { 75, null, "Howell", null, "Howell", null, 374253, 2 },
                    { 76, null, "Koch", null, "Koch", null, 870781, 2 },
                    { 77, null, "DuBuque", null, "DuBuque", null, 653579, 1 },
                    { 78, null, "Armstrong", null, "Armstrong", null, 300876, 2 },
                    { 79, null, "Haag", null, "Haag", null, 523030, 1 },
                    { 80, null, "Altenwerth", null, "Altenwerth", null, 955740, 1 },
                    { 81, null, "Emmerich", null, "Emmerich", null, 656590, 1 },
                    { 82, null, "Anderson", null, "Anderson", null, 577846, 2 },
                    { 83, null, "Hodkiewicz", null, "Hodkiewicz", null, 532190, 1 },
                    { 84, null, "White", null, "White", null, 361560, 1 },
                    { 85, null, "Dach", null, "Dach", null, 447425, 1 },
                    { 86, null, "Muller", null, "Muller", null, 159309, 2 },
                    { 87, null, "Rodriguez", null, "Rodriguez", null, 701613, 1 },
                    { 88, null, "Boyer", null, "Boyer", null, 559480, 2 },
                    { 89, null, "Hilll", null, "Hilll", null, 368529, 2 },
                    { 90, null, "Monahan", null, "Monahan", null, 854743, 1 },
                    { 91, null, "Robel", null, "Robel", null, 78367, 2 },
                    { 92, null, "Schowalter", null, "Schowalter", null, 970578, 1 },
                    { 93, null, "Nader", null, "Nader", null, 87181, 2 },
                    { 94, null, "Barton", null, "Barton", null, 550235, 2 },
                    { 95, null, "Bernier", null, "Bernier", null, 511927, 1 },
                    { 96, null, "Blick", null, "Blick", null, 40577, 1 },
                    { 97, null, "Ziemann", null, "Ziemann", null, 447171, 1 },
                    { 98, null, "Johnston", null, "Johnston", null, 393544, 2 },
                    { 99, null, "Prosacco", null, "Prosacco", null, 379971, 1 },
                    { 100, null, "Jenkins", null, "Jenkins", null, 604022, 2 }
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
