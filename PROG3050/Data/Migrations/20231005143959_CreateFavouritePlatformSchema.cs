using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreateFavouritePlatformSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavouritePlatform",
                columns: table => new
                {
                    FavouritePlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouritePlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouritePlatform", x => x.FavouritePlatformId);
                });

            migrationBuilder.InsertData(
                table: "FavouritePlatform",
                columns: new[] { "FavouritePlatformId", "FavouritePlatformName" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "Mobile" },
                    { 3, "Console" },
                    { 4, "Others" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouritePlatform");
        }
    }
}
