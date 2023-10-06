using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreateMailingAddressSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MailingAddress",
                columns: table => new
                {
                    MailingAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailingAddress", x => x.MailingAddressId);
                    table.ForeignKey(
                        name: "FK_MailingAddress_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MailingAddress",
                columns: new[] { "MailingAddressId", "City", "DeliveryInstruction", "PostalCode", "ProvinceId", "Street", "Unit" },
                values: new object[,]
                {
                    { 1, "HALIFAX", "At the door", "B3J 2B3", 7, "978 ARGYLE ST N", null },
                    { 2, "TORONTO", "At the Post Box", "M4K 1M8", 9, "87 DANFORTH AVE", "501" },
                    { 3, "BIG VALLEY", null, "T0L 1K0", 1, "4 FIRST AVE S", null },
                    { 4, "COURTENAY", "Ask the security Guard to get in.", "V9N 0A7", 2, "PO BOX 4600 STN B", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MailingAddress_ProvinceId",
                table: "MailingAddress",
                column: "ProvinceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MailingAddress");
        }
    }
}
