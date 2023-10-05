using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreateGenderSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[] { 1, "Male" });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[] { 2, "Female" });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[] { 3, "Others" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gender");
        }
    }
}
