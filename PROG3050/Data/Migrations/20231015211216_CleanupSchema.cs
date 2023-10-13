using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CleanupSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.ReportId);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.ShippingAddressId);
                });

            migrationBuilder.CreateTable(
                name: "EventUser",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUser", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EventUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUser_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_ShippingAddress_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "ShippingAddress",
                        principalColumn: "ShippingAddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderGame",
                columns: table => new
                {
                    OrderGameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderGame", x => x.OrderGameId);
                    table.ForeignKey(
                        name: "FK_OrderGame_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderGame_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3791ec71-fa6f-4556-a960-5ecb38196cac", 0, "a4c900b6-5260-4fdb-9482-969490b566ac", null, null, "admin@gmail.com", true, null, 3, false, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAENZBvh0gcjUfSpwXwM7tr3S3x4e83UMto4zQ54Mn4Uq/n+cI7QUQKlhawhF2FLFLtw==", null, true, 2, "546506d0-e442-4f65-bc65-e31f80498577", false, "Admin" },
                    { "435b543f-5add-4af4-9119-1e9469ec90e9", 0, "ffb01fd0-e95f-42a4-9d24-731fd2a3292a", null, null, "superadmin@gmail.com", true, null, 3, false, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEJ38Hu3LyCpKqTNAfD6odUe5o7z1i5VrX9wfwc0Npl0I8/372yyzm+NBVMH8SYoWBA==", null, true, 1, "2b5905da-5a78-4e8b-bdaf-d198bb27172e", false, "SuperAdmin" },
                    { "8099c5a0-06bb-4310-8bc8-a2804d68e744", 0, "5452e86d-a248-4df9-a5e0-691d10aa3e0e", null, null, "moderator@gmail.com", true, null, 3, false, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEK69CC9bj0JnRB5jBMNarf5kF4Ko7q9mON8UpDVK2NJHHx97/2U2jA9D9fieEquRHg==", null, true, 3, "dfa668b2-33c3-4f8f-94cc-f6283143e8b9", false, "Moderator" },
                    { "dfe6af93-c3d5-4cde-9bea-5511e6e4b981", 0, "9de98bd2-0606-4abe-8f5e-930296606779", null, null, "basic@gmail.com", true, null, 3, false, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAEHK0ucv/oKeRW3kaDWieEbQkKzNJP1FFojXOpXfgsatgean28y2/sRKSVw1G0IBq9A==", null, true, 4, "8efce9d7-3278-41b7-b7ec-ff6797ef00e7", false, "Basic" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "Description", "EndDateTime", "StartDateTime", "Title" },
                values: new object[,]
                {
                    { 1, "Welcome Newcomers! Enjoy the party!", new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023 Annual Event" },
                    { 2, "Welcome Game Developers! Enjoy the party!", new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023 GameCon" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "120b517b-47f7-4bf2-a4fa-b5699a092b73", "e4f0f016-dc59-459d-9ace-081eea25bef2", "Basic", "BASIC" },
                    { "34ae1663-5f65-4fde-abe4-ff4fa01c6870", "9a70852f-97bf-4f05-a23b-66d0ea331988", "Admin", "ADMIN" },
                    { "94d69556-01c0-4a16-82f4-9a97382cdcec", "e97c9d36-38ae-43e7-82e0-9c9e3bbb23c2", "SuperAdmin", "SUPERADMIN" },
                    { "ff5ec64e-3dd2-4077-b971-c6a637c20ebf", "41c8de90-813b-4efc-8230-c0bbac24b891", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "ShippingAddress",
                columns: new[] { "ShippingAddressId", "City", "Country", "DeliveryInstruction", "PostalCode", "Province", "Street", "Unit" },
                values: new object[,]
                {
                    { 1, "HALIFAX", "Canada", "At the door", "B3J 2B3", "NU", "978 ARGYLE ST N", null },
                    { 2, "TORONTO", "Canada", "At the Post Box", "M4K 1M8", "ON", "87 DANFORTH AVE", "501" },
                    { 3, "BIG VALLEY", "Canada", null, "T0L 1K0", "AB", "4 FIRST AVE S", null },
                    { 4, "COURTENAY", "Canada", "Ask the security Guard to get in.", "V9N 0A7", "BC", "PO BOX 4600 STN B", null }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "3791ec71-fa6f-4556-a960-5ecb38196cac" },
                    { 1, "8099c5a0-06bb-4310-8bc8-a2804d68e744" },
                    { 1, "dfe6af93-c3d5-4cde-9bea-5511e6e4b981" },
                    { 2, "3791ec71-fa6f-4556-a960-5ecb38196cac" },
                    { 2, "dfe6af93-c3d5-4cde-9bea-5511e6e4b981" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "ShippingAddressId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Processed", "dfe6af93-c3d5-4cde-9bea-5511e6e4b981" },
                    { 2, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Processed", "3791ec71-fa6f-4556-a960-5ecb38196cac" },
                    { 3, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Pending", "8099c5a0-06bb-4310-8bc8-a2804d68e744" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "Description", "GameId", "Rating", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 1, 5.0, "Pending", "The Best Game!", "dfe6af93-c3d5-4cde-9bea-5511e6e4b981" },
                    { 2, "Star Trek: Infinite is a decent game to play. I'll definitely recommend you to play.", 2, 4.0, "Processed", "Good Game", "3791ec71-fa6f-4556-a960-5ecb38196cac" },
                    { 3, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 3, 2.0, "Pending", "Bad Game!", "8099c5a0-06bb-4310-8bc8-a2804d68e744" },
                    { 4, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 2, 2.0, "Pending", "Bad Game!", "8099c5a0-06bb-4310-8bc8-a2804d68e744" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "34ae1663-5f65-4fde-abe4-ff4fa01c6870", "3791ec71-fa6f-4556-a960-5ecb38196cac" },
                    { "94d69556-01c0-4a16-82f4-9a97382cdcec", "435b543f-5add-4af4-9119-1e9469ec90e9" },
                    { "ff5ec64e-3dd2-4077-b971-c6a637c20ebf", "8099c5a0-06bb-4310-8bc8-a2804d68e744" },
                    { "120b517b-47f7-4bf2-a4fa-b5699a092b73", "dfe6af93-c3d5-4cde-9bea-5511e6e4b981" }
                });

            migrationBuilder.InsertData(
                table: "OrderGame",
                columns: new[] { "OrderGameId", "GameId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 2 },
                    { 3, 2, 2, 1 },
                    { 4, 3, 2, 3 },
                    { 5, 3, 3, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_UserId",
                table: "EventUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderGame_GameId",
                table: "OrderGame",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderGame_OrderId",
                table: "OrderGame",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_GameId",
                table: "Review",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventUser");

            migrationBuilder.DropTable(
                name: "OrderGame");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ShippingAddress");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34ae1663-5f65-4fde-abe4-ff4fa01c6870", "3791ec71-fa6f-4556-a960-5ecb38196cac" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "94d69556-01c0-4a16-82f4-9a97382cdcec", "435b543f-5add-4af4-9119-1e9469ec90e9" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff5ec64e-3dd2-4077-b971-c6a637c20ebf", "8099c5a0-06bb-4310-8bc8-a2804d68e744" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "120b517b-47f7-4bf2-a4fa-b5699a092b73", "dfe6af93-c3d5-4cde-9bea-5511e6e4b981" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435b543f-5add-4af4-9119-1e9469ec90e9");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "120b517b-47f7-4bf2-a4fa-b5699a092b73");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "34ae1663-5f65-4fde-abe4-ff4fa01c6870");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "94d69556-01c0-4a16-82f4-9a97382cdcec");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ff5ec64e-3dd2-4077-b971-c6a637c20ebf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3791ec71-fa6f-4556-a960-5ecb38196cac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8099c5a0-06bb-4310-8bc8-a2804d68e744");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfe6af93-c3d5-4cde-9bea-5511e6e4b981");

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
        }
    }
}
