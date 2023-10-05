using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreatePreferenceSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preference",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromotionalEmail = table.Column<bool>(type: "bit", nullable: false),
                    FavouritePlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preference", x => x.PreferenceId);
                    table.ForeignKey(
                        name: "FK_Preference_FavouritePlatform_FavouritePlatformId",
                        column: x => x.FavouritePlatformId,
                        principalTable: "FavouritePlatform",
                        principalColumn: "FavouritePlatformId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Preference",
                columns: new[] { "PreferenceId", "FavouritePlatformId", "PromotionalEmail" },
                values: new object[] { 1, 1, false });

            migrationBuilder.InsertData(
                table: "Preference",
                columns: new[] { "PreferenceId", "FavouritePlatformId", "PromotionalEmail" },
                values: new object[] { 2, 2, true });

            migrationBuilder.InsertData(
                table: "Preference",
                columns: new[] { "PreferenceId", "FavouritePlatformId", "PromotionalEmail" },
                values: new object[] { 3, 3, false });

            migrationBuilder.CreateIndex(
                name: "IX_Preference_FavouritePlatformId",
                table: "Preference",
                column: "FavouritePlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preference");
        }
    }
}
