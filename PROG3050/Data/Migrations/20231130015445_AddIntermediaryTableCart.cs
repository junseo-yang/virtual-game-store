using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class AddIntermediaryTableCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "f750397d-3ce4-4b34-a570-10c42503c427" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0", "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "7ea12475-e529-4874-a1fc-c6d73e04c0f5", "f750397d-3ce4-4b34-a570-10c42503c427" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0", "f750397d-3ce4-4b34-a570-10c42503c427" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "7ea12475-e529-4874-a1fc-c6d73e04c0f5", "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dca73993-5a8b-4a3f-b60a-2d2a1d9c0c0b", "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a7f75e1-de93-4ffa-96fb-3727f164b6b5", "7ea12475-e529-4874-a1fc-c6d73e04c0f5" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda", "bf3198fa-3b9c-405a-9a4f-37c62c877b56" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda", "db1c3398-640e-495d-8524-dd643f315296" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7a98b31-beb8-4f01-ae3c-808d476151c1", "f750397d-3ce4-4b34-a570-10c42503c427" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda", "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0" });

            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumns: new[] { "GameId", "UserId" },
                keyValues: new object[] { 1, "db1c3398-640e-495d-8524-dd643f315296" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea12475-e529-4874-a1fc-c6d73e04c0f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf3198fa-3b9c-405a-9a4f-37c62c877b56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db1c3398-640e-495d-8524-dd643f315296");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f750397d-3ce4-4b34-a570-10c42503c427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8a7f75e1-de93-4ffa-96fb-3727f164b6b5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a7a98b31-beb8-4f01-ae3c-808d476151c1");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "dca73993-5a8b-4a3f-b60a-2d2a1d9c0c0b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda");

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b5575e0-2d6c-46ff-a059-895149382a19", 0, "e5af73d2-4f93-4c99-9021-b031594c3913", null, null, "tester2@gmail.com", true, "Test2FirstName", 3, false, false, "Test2LastName", false, null, 6, "TESTER2@GMAIL.COM", "TESTER2", "AQAAAAEAACcQAAAAEOJNxVSKZfMkkNUTXySCZ5hYLQi0h0SMNAY9Sl6vbk6xefvoIF5Gonb9iATVUWpcqw==", null, true, 6, "0d788a2b-1c58-4ca4-a7f9-07a40f6296c2", false, "Tester2" },
                    { "39c35b8b-5abd-47a6-b41b-b4fb01ffc9f9", 0, "09ac42f2-4895-404e-86b1-643834b3bbab", null, null, "tester1@gmail.com", true, "Test1FirstName", 3, false, false, "Test1LastName", false, null, 5, "TESTER1@GMAIL.COM", "TESTER1", "AQAAAAEAACcQAAAAEArwuwGB7o6DQhYvpR7Fx2pBOnrKCFKNRazFHRaNoIvlErdCNKA9+zaKZiaXaUlRiQ==", null, true, 5, "3f3528fc-a7f1-45d4-b3ca-ef0bac8ebbdc", false, "Tester1" },
                    { "78f3f673-a5df-4948-9d2e-723c94684a3e", 0, "9b05be2d-aec1-446a-bcd9-e2f3ebf577d1", null, null, "admin@gmail.com", true, "William", 3, false, false, "Potter", false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEL4n7LyuaEXK7MGyTJOqVxTvFXVZ3zlbK9L2i7onBMK5DjyTFhO3Fhw6DYCz3gD7Pw==", null, true, 2, "951fc360-8980-477d-833e-a0a231783b38", false, "Admin" },
                    { "7b34e651-88f1-410d-9b82-7fcf0a74129f", 0, "d0710053-306f-40f0-988f-a2466a6ec2bd", null, null, "superadmin@gmail.com", true, "Tyrone", 3, false, false, "Mcgee", false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAENI2GbnRjX4L69MDKzE2i2Fp4CQ+HEwMIxt8tALAHe5sAj9/acGDeKoLWWZAI1pAGw==", null, true, 1, "9cbc9e5a-d781-4266-9025-2aa9aaeb9ec1", false, "SuperAdmin" },
                    { "86f401e8-c582-4d40-b5ef-4683b5e18619", 0, "674188f1-4fba-4bc5-a03a-2553ed0df617", null, null, "member@gmail.com", true, "Ernest", 3, false, false, "Mcknight", false, null, 4, "MEMBER@GMAIL.COM", "MEMBER", "AQAAAAEAACcQAAAAEAcDKUxCljRfPWM1hKyS17oxcYdQTLBVMCriglvcso3YbgXArhdQApmnZsYvhWOM/g==", null, true, 4, "14b47212-2904-4753-ba60-5aa6c617bde9", false, "Member" },
                    { "b2d45a6e-99d0-481b-b680-1bd093b32a64", 0, "25a313e2-bc74-46e9-a03f-9e38b2405b96", null, null, "moderator@gmail.com", true, "Francis", 3, false, false, "Ramos", false, null, 3, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAEAACcQAAAAEPWI28XvoqPt3j+rjtqYXAXCuba/SmtDk7mj0tfv5pueU6vAc96yPcKvIQ7/g8DhLg==", null, true, 3, "14d7f773-4c6c-42f2-b87d-f03da81b30a2", false, "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "44f0adee-745e-432f-a1bf-52edb463032c", "a850d8af-839b-4a55-8c25-20fcbcb7424e", "Admin", "ADMIN" },
                    { "5aae76cf-3e4b-4c36-b538-8a99670b243d", "1f76ab45-5d6d-48cf-b55b-6947fc176fc8", "Member", "MEMBER" },
                    { "6319e403-5829-4819-803c-b6b0eef93cfc", "82cda5ee-e527-407c-9108-d0d5080f1b0e", "SuperAdmin", "SUPERADMIN" },
                    { "ee72eecb-1b8b-42d6-ac89-b53688af6b20", "fc59ecae-6c6e-4d95-9559-c8c27fd2c889", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "78f3f673-a5df-4948-9d2e-723c94684a3e" },
                    { 1, "86f401e8-c582-4d40-b5ef-4683b5e18619" },
                    { 1, "b2d45a6e-99d0-481b-b680-1bd093b32a64" },
                    { 2, "78f3f673-a5df-4948-9d2e-723c94684a3e" },
                    { 2, "86f401e8-c582-4d40-b5ef-4683b5e18619" }
                });

            migrationBuilder.InsertData(
                table: "FriendFamily",
                columns: new[] { "ReceiverUserId", "RequesterUserId", "Description", "Status" },
                values: new object[,]
                {
                    { "86f401e8-c582-4d40-b5ef-4683b5e18619", "78f3f673-a5df-4948-9d2e-723c94684a3e", "Friend", "Processed" },
                    { "7b34e651-88f1-410d-9b82-7fcf0a74129f", "86f401e8-c582-4d40-b5ef-4683b5e18619", "Friend", "Pending" },
                    { "7b34e651-88f1-410d-9b82-7fcf0a74129f", "b2d45a6e-99d0-481b-b680-1bd093b32a64", "Family", "Pending" },
                    { "86f401e8-c582-4d40-b5ef-4683b5e18619", "b2d45a6e-99d0-481b-b680-1bd093b32a64", "Family", "Processed" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "UserId",
                value: "86f401e8-c582-4d40-b5ef-4683b5e18619");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "UserId",
                value: "78f3f673-a5df-4948-9d2e-723c94684a3e");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "UserId",
                value: "b2d45a6e-99d0-481b-b680-1bd093b32a64");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "UserId",
                value: "86f401e8-c582-4d40-b5ef-4683b5e18619");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "UserId",
                value: "78f3f673-a5df-4948-9d2e-723c94684a3e");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "UserId",
                value: "b2d45a6e-99d0-481b-b680-1bd093b32a64");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "UserId",
                value: "b2d45a6e-99d0-481b-b680-1bd093b32a64");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5aae76cf-3e4b-4c36-b538-8a99670b243d", "2b5575e0-2d6c-46ff-a059-895149382a19" },
                    { "5aae76cf-3e4b-4c36-b538-8a99670b243d", "39c35b8b-5abd-47a6-b41b-b4fb01ffc9f9" },
                    { "44f0adee-745e-432f-a1bf-52edb463032c", "78f3f673-a5df-4948-9d2e-723c94684a3e" },
                    { "6319e403-5829-4819-803c-b6b0eef93cfc", "7b34e651-88f1-410d-9b82-7fcf0a74129f" },
                    { "5aae76cf-3e4b-4c36-b538-8a99670b243d", "86f401e8-c582-4d40-b5ef-4683b5e18619" },
                    { "ee72eecb-1b8b-42d6-ac89-b53688af6b20", "b2d45a6e-99d0-481b-b680-1bd093b32a64" }
                });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "GameId", "UserId" },
                values: new object[] { 1, "39c35b8b-5abd-47a6-b41b-b4fb01ffc9f9" });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_GameId",
                table: "Cart",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "78f3f673-a5df-4948-9d2e-723c94684a3e" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "86f401e8-c582-4d40-b5ef-4683b5e18619" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "b2d45a6e-99d0-481b-b680-1bd093b32a64" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "78f3f673-a5df-4948-9d2e-723c94684a3e" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "86f401e8-c582-4d40-b5ef-4683b5e18619" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "86f401e8-c582-4d40-b5ef-4683b5e18619", "78f3f673-a5df-4948-9d2e-723c94684a3e" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "7b34e651-88f1-410d-9b82-7fcf0a74129f", "86f401e8-c582-4d40-b5ef-4683b5e18619" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "7b34e651-88f1-410d-9b82-7fcf0a74129f", "b2d45a6e-99d0-481b-b680-1bd093b32a64" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "86f401e8-c582-4d40-b5ef-4683b5e18619", "b2d45a6e-99d0-481b-b680-1bd093b32a64" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aae76cf-3e4b-4c36-b538-8a99670b243d", "2b5575e0-2d6c-46ff-a059-895149382a19" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aae76cf-3e4b-4c36-b538-8a99670b243d", "39c35b8b-5abd-47a6-b41b-b4fb01ffc9f9" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "44f0adee-745e-432f-a1bf-52edb463032c", "78f3f673-a5df-4948-9d2e-723c94684a3e" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6319e403-5829-4819-803c-b6b0eef93cfc", "7b34e651-88f1-410d-9b82-7fcf0a74129f" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5aae76cf-3e4b-4c36-b538-8a99670b243d", "86f401e8-c582-4d40-b5ef-4683b5e18619" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee72eecb-1b8b-42d6-ac89-b53688af6b20", "b2d45a6e-99d0-481b-b680-1bd093b32a64" });

            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumns: new[] { "GameId", "UserId" },
                keyValues: new object[] { 1, "39c35b8b-5abd-47a6-b41b-b4fb01ffc9f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b5575e0-2d6c-46ff-a059-895149382a19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39c35b8b-5abd-47a6-b41b-b4fb01ffc9f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78f3f673-a5df-4948-9d2e-723c94684a3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b34e651-88f1-410d-9b82-7fcf0a74129f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86f401e8-c582-4d40-b5ef-4683b5e18619");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2d45a6e-99d0-481b-b680-1bd093b32a64");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "44f0adee-745e-432f-a1bf-52edb463032c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5aae76cf-3e4b-4c36-b538-8a99670b243d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6319e403-5829-4819-803c-b6b0eef93cfc");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ee72eecb-1b8b-42d6-ac89-b53688af6b20");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8", 0, "309f314d-f98f-49d7-8783-82c67f20e3ce", null, null, "admin@gmail.com", true, "William", 3, false, false, "Potter", false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEIZfU1Mct/UAi3EFsbuzj1pOLW/1Upjwrpy+k2LeA0RwVUcWXvb2ThEUz7rYaOkm4g==", null, true, 2, "58ee6ca6-8715-40b0-bc13-e61f3eb50dc7", false, "Admin" },
                    { "7ea12475-e529-4874-a1fc-c6d73e04c0f5", 0, "4ee82f68-3e09-4880-851b-96ebe0816016", null, null, "superadmin@gmail.com", true, "Tyrone", 3, false, false, "Mcgee", false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEDrp076G00GqpG4Pqb0oq+808QsBrNauYQplyhCXYSBZkSINCQvqAgAM5x9OD3gG5A==", null, true, 1, "16ad03cb-501c-48f1-afa3-f14db9abaed4", false, "SuperAdmin" },
                    { "bf3198fa-3b9c-405a-9a4f-37c62c877b56", 0, "977d798e-6752-4af0-971d-6f123b7c65a2", null, null, "tester2@gmail.com", true, "Test2FirstName", 3, false, false, "Test2LastName", false, null, 6, "TESTER2@GMAIL.COM", "TESTER2", "AQAAAAEAACcQAAAAEMcjJOADZOwbywspC67LC47vVNmJseSQXujVlU3yFW8/g3cet1X09RYH6eUaDzWmVQ==", null, true, 6, "1da3fe35-630a-41f4-b882-4dbefe3246ec", false, "Tester2" },
                    { "db1c3398-640e-495d-8524-dd643f315296", 0, "ecc956ee-b61f-4535-8747-2dc158dcc668", null, null, "tester1@gmail.com", true, "Test1FirstName", 3, false, false, "Test1LastName", false, null, 5, "TESTER1@GMAIL.COM", "TESTER1", "AQAAAAEAACcQAAAAEEfT5osZiB3hcpZ45JY4oLygQaDBaUwHTttMmB9zHrMJqAggpEhMnTp5a3teqmY7lA==", null, true, 5, "4844e4a4-765a-4de6-b976-392bde82866e", false, "Tester1" },
                    { "f750397d-3ce4-4b34-a570-10c42503c427", 0, "f95abc4b-3524-405f-892e-9db080ce242a", null, null, "moderator@gmail.com", true, "Francis", 3, false, false, "Ramos", false, null, 3, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAEAACcQAAAAEHB6mh/jOIJ6tXcMVHmXLhINlby2DJafrVIjrsm2Lkf4GLA2YXAf+TZ8kjr1bxlqOA==", null, true, 3, "d972efb8-2b92-46ca-9554-a0ac0d8466b6", false, "Moderator" },
                    { "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0", 0, "21f2b790-ed6d-4973-9fd9-48c6fbe01e0a", null, null, "member@gmail.com", true, "Ernest", 3, false, false, "Mcknight", false, null, 4, "MEMBER@GMAIL.COM", "MEMBER", "AQAAAAEAACcQAAAAEFnmoW2TSYcbhEp1wef/G3WGRSTyb510W0E1wJQkox4qXQWYg014rNulHDfjVm5Yrg==", null, true, 4, "598b707a-98af-4ed2-87ec-dd35c4e6079f", false, "Member" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a7f75e1-de93-4ffa-96fb-3727f164b6b5", "9f6bb4be-09f5-42cb-9fac-039c13ed82d4", "SuperAdmin", "SUPERADMIN" },
                    { "a7a98b31-beb8-4f01-ae3c-808d476151c1", "44a56fb5-cb68-4ed6-a5d9-1459dd32a834", "Moderator", "MODERATOR" },
                    { "dca73993-5a8b-4a3f-b60a-2d2a1d9c0c0b", "65fe3bae-8d79-4833-b4fc-7efe13c47f25", "Admin", "ADMIN" },
                    { "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda", "1d6ebfcb-ebe8-4617-921d-1ee614032aeb", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8" },
                    { 1, "f750397d-3ce4-4b34-a570-10c42503c427" },
                    { 1, "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0" },
                    { 2, "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8" },
                    { 2, "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0" }
                });

            migrationBuilder.InsertData(
                table: "FriendFamily",
                columns: new[] { "ReceiverUserId", "RequesterUserId", "Description", "Status" },
                values: new object[,]
                {
                    { "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0", "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8", "Friend", "Processed" },
                    { "7ea12475-e529-4874-a1fc-c6d73e04c0f5", "f750397d-3ce4-4b34-a570-10c42503c427", "Family", "Pending" },
                    { "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0", "f750397d-3ce4-4b34-a570-10c42503c427", "Family", "Processed" },
                    { "7ea12475-e529-4874-a1fc-c6d73e04c0f5", "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0", "Friend", "Pending" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "UserId",
                value: "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "UserId",
                value: "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "UserId",
                value: "f750397d-3ce4-4b34-a570-10c42503c427");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "UserId",
                value: "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "UserId",
                value: "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "UserId",
                value: "f750397d-3ce4-4b34-a570-10c42503c427");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "UserId",
                value: "f750397d-3ce4-4b34-a570-10c42503c427");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dca73993-5a8b-4a3f-b60a-2d2a1d9c0c0b", "4cf3a1f6-097c-4395-aa6b-4ee2b6f4bdf8" },
                    { "8a7f75e1-de93-4ffa-96fb-3727f164b6b5", "7ea12475-e529-4874-a1fc-c6d73e04c0f5" },
                    { "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda", "bf3198fa-3b9c-405a-9a4f-37c62c877b56" },
                    { "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda", "db1c3398-640e-495d-8524-dd643f315296" },
                    { "a7a98b31-beb8-4f01-ae3c-808d476151c1", "f750397d-3ce4-4b34-a570-10c42503c427" },
                    { "fb687fbb-9f3f-4e46-a40d-5abb4fa1abda", "ff6db973-cd1f-4c26-8597-7f5cfd47a1c0" }
                });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "GameId", "UserId" },
                values: new object[] { 1, "db1c3398-640e-495d-8524-dd643f315296" });
        }
    }
}
