using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreateProvinceSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceId", "CountryId", "ProvinceName" },
                values: new object[,]
                {
                    { 1, 1, "AB" },
                    { 2, 1, "BC" },
                    { 3, 1, "MB" },
                    { 4, 1, "NB" },
                    { 5, 1, "NL" },
                    { 6, 1, "NT" },
                    { 7, 1, "NS" },
                    { 8, 1, "NU" },
                    { 9, 1, "ON" },
                    { 10, 1, "PE" },
                    { 11, 1, "QC" },
                    { 12, 1, "SK" },
                    { 13, 1, "YT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryId",
                table: "Province",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
