using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreateGameSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f16fdd05-ee33-425e-938e-177d43a6e91f", "05a54395-7d27-41aa-8786-70fed42eeee2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d30d0e42-1e88-45c7-a852-6166d15d23b2", "66ea6e75-86b2-4963-ac5a-ce33fa50a736" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc085708-8d2a-4212-bc95-c90c6e5bc17c", "94fbb019-75cb-4231-a540-6fcb5af2ef48" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecd5b421-f226-4830-80c4-a2a8e8ec54e7", "e9614465-2aa3-47a4-98cd-5e314924f53c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05a54395-7d27-41aa-8786-70fed42eeee2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66ea6e75-86b2-4963-ac5a-ce33fa50a736");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94fbb019-75cb-4231-a540-6fcb5af2ef48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9614465-2aa3-47a4-98cd-5e314924f53c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "bc085708-8d2a-4212-bc95-c90c6e5bc17c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d30d0e42-1e88-45c7-a852-6166d15d23b2");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ecd5b421-f226-4830-80c4-a2a8e8ec54e7");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f16fdd05-ee33-425e-938e-177d43a6e91f");

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Game_GameCategory_GameCategoryId",
                        column: x => x.GameCategoryId,
                        principalTable: "GameCategory",
                        principalColumn: "GameCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5a4589fe-ab4d-4abf-adc6-125d3af2375b", 0, "31c147c4-97a4-45b8-aaac-4b7573c0cdfe", null, null, "moderator@gmail.com", true, null, 3, false, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEPci0Ko3DTFyL4F0mJlP0C5WuFamtsU0v/FtU+gUqd9NwE/HIWpNZ7Q0QkDilHuwqQ==", null, true, 3, "fb98bb63-f3d5-45c0-8a77-0f8b6c187867", false, "Moderator" },
                    { "85584bde-bb69-49d8-909c-a0226348cd97", 0, "8c33692d-cebd-423c-8719-70d852bf8310", null, null, "basic@gmail.com", true, null, 3, false, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAEFovn6V/JVO+RxPf3FJ9BE8t0NpxaPWsejjG8U1sxPgorsJ1Ek7ulSQ+9atfXcitkw==", null, true, 4, "4a23d75c-8ad8-48f7-b594-27ee1d4bb6bc", false, "Basic" },
                    { "d2ede571-f38f-4d49-9f1a-0e4bc00afb9e", 0, "827440da-c515-4cd5-a5cb-efa9fe58f8c2", null, null, "admin@gmail.com", true, null, 3, false, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHYLwsRMyOIRRhnWeNnlHvxxXxWx3wWeUPi3bEzLpq7jCzHyciWw84fVT1nf4T4/9w==", null, true, 2, "87ed8685-0a75-4caa-844a-f841fc8bd0ee", false, "Admin" },
                    { "f8f86319-335c-408f-98bc-fdfa74f2a68d", 0, "53ddae15-8514-4a82-9f70-a096a73d544a", null, null, "superadmin@gmail.com", true, null, 3, false, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAED9Li4p+KkJm01QfVK1Mw0LBUPP2WXFzBx/8qep1jlb4fednqnnHZNEetcMBB1k0Dg==", null, true, 1, "01ae49c7-96cf-4bfc-b9d0-7bf5a3103840", false, "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Description", "GameCategoryId", "Price", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "For over two decades, Counter-Strike has offered an elite competitive experience, one shaped by millions of players from across the globe. And now the next chapter in the CS story is about to begin. This is Counter-Strike 2.", 3, 0.0, new DateTime(2012, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Counter-Strike 2" },
                    { 2, "Star Trek: Infinite is a grand strategy experience that lets you play your own Star Trek story as the leader of one of four major factions in the galaxy. Follow the specially crafted story or blaze your own trail in the first Star Trek grand strategy game.", 1, 39.990000000000002, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Trek: Infinite" },
                    { 3, "Raise a city from the ground up and transform it into a thriving metropolis with the most realistic city builder ever. Push your creativity and problem-solving to build on a scale you've never experienced. With deep simulation and a living economy, this is world-building without limits.", 2, 59.990000000000002, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cities: Skylines II" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0094314a-0df4-451d-a539-67ff9ab1a96d", "08dc6d9b-bf04-463b-b892-1c97cc68a54c", "SuperAdmin", "SUPERADMIN" },
                    { "09196d59-4695-4dd2-9b22-667701807104", "58516f24-4906-4931-b601-02c29a36e8fa", "Moderator", "MODERATOR" },
                    { "8d429109-2b04-4636-8709-a860651ab992", "0b199d55-653e-4ce2-8a52-6c937db57f25", "Basic", "BASIC" },
                    { "a415d401-54fb-49e7-80e5-722a26a66c6f", "0fc6a867-8e90-4d7a-8e77-4fc9046cacf9", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "09196d59-4695-4dd2-9b22-667701807104", "5a4589fe-ab4d-4abf-adc6-125d3af2375b" },
                    { "8d429109-2b04-4636-8709-a860651ab992", "85584bde-bb69-49d8-909c-a0226348cd97" },
                    { "a415d401-54fb-49e7-80e5-722a26a66c6f", "d2ede571-f38f-4d49-9f1a-0e4bc00afb9e" },
                    { "0094314a-0df4-451d-a539-67ff9ab1a96d", "f8f86319-335c-408f-98bc-fdfa74f2a68d" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameCategoryId",
                table: "Game",
                column: "GameCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09196d59-4695-4dd2-9b22-667701807104", "5a4589fe-ab4d-4abf-adc6-125d3af2375b" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d429109-2b04-4636-8709-a860651ab992", "85584bde-bb69-49d8-909c-a0226348cd97" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a415d401-54fb-49e7-80e5-722a26a66c6f", "d2ede571-f38f-4d49-9f1a-0e4bc00afb9e" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0094314a-0df4-451d-a539-67ff9ab1a96d", "f8f86319-335c-408f-98bc-fdfa74f2a68d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a4589fe-ab4d-4abf-adc6-125d3af2375b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85584bde-bb69-49d8-909c-a0226348cd97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2ede571-f38f-4d49-9f1a-0e4bc00afb9e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8f86319-335c-408f-98bc-fdfa74f2a68d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0094314a-0df4-451d-a539-67ff9ab1a96d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "09196d59-4695-4dd2-9b22-667701807104");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8d429109-2b04-4636-8709-a860651ab992");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a415d401-54fb-49e7-80e5-722a26a66c6f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05a54395-7d27-41aa-8786-70fed42eeee2", 0, "c750abec-147b-4d93-9be3-381c1c445299", null, null, "moderator@gmail.com", true, null, 3, false, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEE1+U09TU8OVRazkyWJHzZksTgIuT3g6i3Tn+BDKtlAiCePsXhzV48zfXyrxOcNMXQ==", null, true, 3, "c64301ad-9dda-436a-93ac-4c0848823abc", false, "Moderator" },
                    { "66ea6e75-86b2-4963-ac5a-ce33fa50a736", 0, "4a1b8cb5-0a0c-4c1c-93e7-a880cc771bd3", null, null, "superadmin@gmail.com", true, null, 3, false, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAELtpuPHzmCR/PtQuUvTd/ZraMGVLjVOVpzGAWTkZ2hVhu9nXdDPzAYQ7qD8uYekirQ==", null, true, 1, "2c3839ef-97a9-4dff-8fd5-8200acedaaa7", false, "SuperAdmin" },
                    { "94fbb019-75cb-4231-a540-6fcb5af2ef48", 0, "864d6b85-f15a-4283-9b8f-59e773f7afe5", null, null, "admin@gmail.com", true, null, 3, false, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEGQ5++hFvJ1zf0o5iH6/I0dFaF5K1wrTL3bZGDwB6ikbpWIvo0gLIhwHML+WDQRGGQ==", null, true, 2, "f5511550-6a3a-4f7d-8717-469eb5f8842f", false, "Admin" },
                    { "e9614465-2aa3-47a4-98cd-5e314924f53c", 0, "a0f5eb56-6888-4efb-bb49-652388da0e31", null, null, "basic@gmail.com", true, null, 3, false, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAEOrgj3bYedqZxlPjF+C7vyj73VcMg+MAn6GEg5SVwrqbvCVbd2QbcBSwxOrj2c194Q==", null, true, 4, "53ed6280-07b4-44b1-8f57-33aa800ac4a2", false, "Basic" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bc085708-8d2a-4212-bc95-c90c6e5bc17c", "5186f986-ed94-4ad5-a2a8-1f5e5a355a94", "Admin", "ADMIN" },
                    { "d30d0e42-1e88-45c7-a852-6166d15d23b2", "3fd8f7c9-14e0-45cd-80a0-cbf6148aca3f", "SuperAdmin", "SUPERADMIN" },
                    { "ecd5b421-f226-4830-80c4-a2a8e8ec54e7", "8f5fa2ed-e35e-44b2-9a68-33d6824ed55d", "Basic", "BASIC" },
                    { "f16fdd05-ee33-425e-938e-177d43a6e91f", "31789cc6-6589-4942-b7aa-e3cf0c0a623c", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f16fdd05-ee33-425e-938e-177d43a6e91f", "05a54395-7d27-41aa-8786-70fed42eeee2" },
                    { "d30d0e42-1e88-45c7-a852-6166d15d23b2", "66ea6e75-86b2-4963-ac5a-ce33fa50a736" },
                    { "bc085708-8d2a-4212-bc95-c90c6e5bc17c", "94fbb019-75cb-4231-a540-6fcb5af2ef48" },
                    { "ecd5b421-f226-4830-80c4-a2a8e8ec54e7", "e9614465-2aa3-47a4-98cd-5e314924f53c" }
                });
        }
    }
}
