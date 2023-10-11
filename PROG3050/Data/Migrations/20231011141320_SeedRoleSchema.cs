using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class SeedRoleSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "48cabadd-b7cb-4d97-9a28-f1e4b2760648", "ee5a6380-cbe4-4fa9-aad5-8cdc301cab10", "Basic", "BASIC" },
                    { "4a16c8aa-27dd-4340-91ab-966c65b16e94", "a234dc23-e656-4fe7-9202-d87014652232", "Moderator", "MODERATOR" },
                    { "596ada88-f390-4758-b11b-13dde84b2554", "5c28790b-d69a-4284-abde-203a737837b8", "Admin", "ADMIN" },
                    { "de9c78b6-bbbf-4515-88d7-d3c6a9dfd180", "965c2813-49b5-4d22-a54d-8701b5fb96fe", "SuperAdmin", "SUPERADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "48cabadd-b7cb-4d97-9a28-f1e4b2760648");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4a16c8aa-27dd-4340-91ab-966c65b16e94");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "596ada88-f390-4758-b11b-13dde84b2554");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "de9c78b6-bbbf-4515-88d7-d3c6a9dfd180");
        }
    }
}
