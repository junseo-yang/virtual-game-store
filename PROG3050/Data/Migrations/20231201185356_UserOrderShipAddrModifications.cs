using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class UserOrderShipAddrModifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_ShippingAddress_ShippingAddressId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "42137bba-a246-4f8e-8f8f-4678cc45c9d6" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "ceab126d-5b79-4168-964f-160d0e705dc3" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "ceab126d-5b79-4168-964f-160d0e705dc3" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "84f7bede-1191-4cc7-8fcf-f00baa571937", "42137bba-a246-4f8e-8f8f-4678cc45c9d6" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7", "42137bba-a246-4f8e-8f8f-4678cc45c9d6" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7", "ceab126d-5b79-4168-964f-160d0e705dc3" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "84f7bede-1191-4cc7-8fcf-f00baa571937", "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aeebb091-081d-4c23-bde0-690dd94090f2", "049a1404-b475-4dc7-b053-fb0ecab7d3df" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a6e4eb8-347d-408c-8380-0b15b013dddf", "42137bba-a246-4f8e-8f8f-4678cc45c9d6" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a6154ec-dad0-40ff-abb9-ce8fbafec3e4", "84f7bede-1191-4cc7-8fcf-f00baa571937" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "409b3be1-8199-4378-8083-1595f2dbd971", "ceab126d-5b79-4168-964f-160d0e705dc3" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aeebb091-081d-4c23-bde0-690dd94090f2", "e9df12f9-87cd-4bb5-8a06-514dbf164b10" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aeebb091-081d-4c23-bde0-690dd94090f2", "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" });

            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumns: new[] { "GameId", "UserId" },
                keyValues: new object[] { 1, "e9df12f9-87cd-4bb5-8a06-514dbf164b10" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "049a1404-b475-4dc7-b053-fb0ecab7d3df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42137bba-a246-4f8e-8f8f-4678cc45c9d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84f7bede-1191-4cc7-8fcf-f00baa571937");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ceab126d-5b79-4168-964f-160d0e705dc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9df12f9-87cd-4bb5-8a06-514dbf164b10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "409b3be1-8199-4378-8083-1595f2dbd971");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "7a6154ec-dad0-40ff-abb9-ce8fbafec3e4");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9a6e4eb8-347d-408c-8380-0b15b013dddf");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "aeebb091-081d-4c23-bde0-690dd94090f2");

            migrationBuilder.DropColumn(
                name: "ShippingAddressId",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<double>(
                name: "OrderCost",
                table: "Order",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "CreditCardExpiry", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1795eaf4-2982-423d-97d1-4474fc92051a", 0, "df994878-5dd4-4037-a8b4-15697aab2c20", null, null, null, "tester2@gmail.com", true, "Test2FirstName", 3, false, false, "Test2LastName", false, null, 6, "TESTER2@GMAIL.COM", "TESTER2", "AQAAAAEAACcQAAAAEAf9vd+8DVsc7NgrNPUDKqpBmSxPovCrBCavlgJZy/IGn/Z2HmeDArIvWD/6OIX9Yw==", null, true, 6, "c993c595-f1d3-4522-a695-530ea5f677e8", false, "Tester2" },
                    { "266b5d37-00f7-41e0-a80a-46f06f3097d1", 0, "6a0f723a-b8f5-41c1-b155-23a013665aa9", null, null, null, "admin@gmail.com", true, "William", 3, false, false, "Potter", false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEFlCeRtPq8LXWgnMbX9/HL1zzI4/b5lzm7E7D8zY39k1mEl/MQC01goIUB5c8QcvwA==", null, true, 2, "0be6a421-8e53-4f98-9282-2bc098e17430", false, "Admin" },
                    { "799b44dc-99b4-4ae8-8320-3464b60e9960", 0, "a95f36cd-6fc8-4ea4-b6b2-bd65661e562e", null, null, null, "member@gmail.com", true, "Ernest", 3, false, false, "Mcknight", false, null, 4, "MEMBER@GMAIL.COM", "MEMBER", "AQAAAAEAACcQAAAAEAEwKftuOaLUbXP44/LfoQKBLlkVxbKuaCCAX5TvJqs0o+OnTv0Xd+axay2kyyLO4A==", null, true, 4, "26528190-4638-40dc-a25d-a1a417a0e6cb", false, "Member" },
                    { "af36ee0d-76bb-4b79-8add-28713cca8497", 0, "59a3f755-cd1e-45e8-a0e1-8913296e5451", null, null, null, "tester1@gmail.com", true, "Test1FirstName", 3, false, false, "Test1LastName", false, null, 5, "TESTER1@GMAIL.COM", "TESTER1", "AQAAAAEAACcQAAAAEOjYaXG/VqW2xIK54pui7SxoDXp3/go+7UQZ5HJlmNXG/Fg5sOTDXFbjzHsBZEKYUg==", null, true, 5, "fed27f7d-a5aa-4d43-8e3a-e7387d5a710a", false, "Tester1" },
                    { "c9374b91-fdd7-4366-b27f-34422567847c", 0, "7356a467-d6f1-43d2-a9bf-4a26ca3771be", null, null, null, "superadmin@gmail.com", true, "Tyrone", 3, false, false, "Mcgee", false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEE1THD5ono5vD/KP1N+SVL5E5SlS1fhyQ7quwSDduam3n/ZEEwEFyaDFMWfXlWBbDQ==", null, true, 1, "a92b18b9-2c0e-46d2-b82c-f29942e644ae", false, "SuperAdmin" },
                    { "fc71656a-3da9-4b7e-b8c2-af2f1c58e951", 0, "5cbfd7a7-b71a-405c-9014-d19e6b973b5c", null, null, null, "moderator@gmail.com", true, "Francis", 3, false, false, "Ramos", false, null, 3, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAEAACcQAAAAEDNsLvWGO1dqlbTFmyj+2yaCA18NK52QvQnXHNtg0+WnGbW2JbT5hO2LtUonMXXEzg==", null, true, 3, "99b343b9-7f01-4550-99c2-9354ab8551d5", false, "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38134da4-7669-4a5a-86a4-8c74ac1d17e6", "56927c14-ac89-46b5-8739-6eab5f42c23b", "Member", "MEMBER" },
                    { "66d73f06-3aa7-4a50-a314-18e8053d9925", "d5e38218-3cbc-44b2-b439-df3e3082e157", "Moderator", "MODERATOR" },
                    { "864113d3-ef4e-4fe4-adbf-42980b30f76d", "8151e387-744b-4448-b064-ce0fbf3c6d94", "Admin", "ADMIN" },
                    { "d3c9eefd-6508-474b-b0d6-d514a6645d42", "9dd128eb-68bc-4940-8e8e-62709ec2243f", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "266b5d37-00f7-41e0-a80a-46f06f3097d1" },
                    { 1, "799b44dc-99b4-4ae8-8320-3464b60e9960" },
                    { 1, "fc71656a-3da9-4b7e-b8c2-af2f1c58e951" },
                    { 2, "266b5d37-00f7-41e0-a80a-46f06f3097d1" },
                    { 2, "799b44dc-99b4-4ae8-8320-3464b60e9960" }
                });

            migrationBuilder.InsertData(
                table: "FriendFamily",
                columns: new[] { "ReceiverUserId", "RequesterUserId", "Description", "Status" },
                values: new object[,]
                {
                    { "799b44dc-99b4-4ae8-8320-3464b60e9960", "266b5d37-00f7-41e0-a80a-46f06f3097d1", "Friend", "Processed" },
                    { "c9374b91-fdd7-4366-b27f-34422567847c", "799b44dc-99b4-4ae8-8320-3464b60e9960", "Friend", "Pending" },
                    { "799b44dc-99b4-4ae8-8320-3464b60e9960", "fc71656a-3da9-4b7e-b8c2-af2f1c58e951", "Family", "Processed" },
                    { "c9374b91-fdd7-4366-b27f-34422567847c", "fc71656a-3da9-4b7e-b8c2-af2f1c58e951", "Family", "Pending" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "ShippingAddress", "UserId" },
                values: new object[] { "PO BOX 4600 STN B, Courtenay, BC, Canada, V9N 0A7", "799b44dc-99b4-4ae8-8320-3464b60e9960" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "ShippingAddress", "UserId" },
                values: new object[] { "87 Danforth Ave, Toronto, ON, Canada, M4K 1M8", "266b5d37-00f7-41e0-a80a-46f06f3097d1" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "ShippingAddress", "UserId" },
                values: new object[] { "4 First Ave S, Big Valley, AB, Canada, T0L 1K0", "fc71656a-3da9-4b7e-b8c2-af2f1c58e951" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "UserId",
                value: "799b44dc-99b4-4ae8-8320-3464b60e9960");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "UserId",
                value: "266b5d37-00f7-41e0-a80a-46f06f3097d1");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "UserId",
                value: "fc71656a-3da9-4b7e-b8c2-af2f1c58e951");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "UserId",
                value: "fc71656a-3da9-4b7e-b8c2-af2f1c58e951");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "38134da4-7669-4a5a-86a4-8c74ac1d17e6", "1795eaf4-2982-423d-97d1-4474fc92051a" },
                    { "864113d3-ef4e-4fe4-adbf-42980b30f76d", "266b5d37-00f7-41e0-a80a-46f06f3097d1" },
                    { "38134da4-7669-4a5a-86a4-8c74ac1d17e6", "799b44dc-99b4-4ae8-8320-3464b60e9960" },
                    { "38134da4-7669-4a5a-86a4-8c74ac1d17e6", "af36ee0d-76bb-4b79-8add-28713cca8497" },
                    { "d3c9eefd-6508-474b-b0d6-d514a6645d42", "c9374b91-fdd7-4366-b27f-34422567847c" },
                    { "66d73f06-3aa7-4a50-a314-18e8053d9925", "fc71656a-3da9-4b7e-b8c2-af2f1c58e951" }
                });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "GameId", "UserId" },
                values: new object[] { 1, "af36ee0d-76bb-4b79-8add-28713cca8497" });

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "266b5d37-00f7-41e0-a80a-46f06f3097d1" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "799b44dc-99b4-4ae8-8320-3464b60e9960" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 1, "fc71656a-3da9-4b7e-b8c2-af2f1c58e951" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "266b5d37-00f7-41e0-a80a-46f06f3097d1" });

            migrationBuilder.DeleteData(
                table: "EventUser",
                keyColumns: new[] { "EventId", "UserId" },
                keyValues: new object[] { 2, "799b44dc-99b4-4ae8-8320-3464b60e9960" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "799b44dc-99b4-4ae8-8320-3464b60e9960", "266b5d37-00f7-41e0-a80a-46f06f3097d1" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "c9374b91-fdd7-4366-b27f-34422567847c", "799b44dc-99b4-4ae8-8320-3464b60e9960" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "799b44dc-99b4-4ae8-8320-3464b60e9960", "fc71656a-3da9-4b7e-b8c2-af2f1c58e951" });

            migrationBuilder.DeleteData(
                table: "FriendFamily",
                keyColumns: new[] { "ReceiverUserId", "RequesterUserId" },
                keyValues: new object[] { "c9374b91-fdd7-4366-b27f-34422567847c", "fc71656a-3da9-4b7e-b8c2-af2f1c58e951" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38134da4-7669-4a5a-86a4-8c74ac1d17e6", "1795eaf4-2982-423d-97d1-4474fc92051a" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "864113d3-ef4e-4fe4-adbf-42980b30f76d", "266b5d37-00f7-41e0-a80a-46f06f3097d1" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38134da4-7669-4a5a-86a4-8c74ac1d17e6", "799b44dc-99b4-4ae8-8320-3464b60e9960" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "38134da4-7669-4a5a-86a4-8c74ac1d17e6", "af36ee0d-76bb-4b79-8add-28713cca8497" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3c9eefd-6508-474b-b0d6-d514a6645d42", "c9374b91-fdd7-4366-b27f-34422567847c" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66d73f06-3aa7-4a50-a314-18e8053d9925", "fc71656a-3da9-4b7e-b8c2-af2f1c58e951" });

            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumns: new[] { "GameId", "UserId" },
                keyValues: new object[] { 1, "af36ee0d-76bb-4b79-8add-28713cca8497" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1795eaf4-2982-423d-97d1-4474fc92051a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "266b5d37-00f7-41e0-a80a-46f06f3097d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "799b44dc-99b4-4ae8-8320-3464b60e9960");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af36ee0d-76bb-4b79-8add-28713cca8497");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9374b91-fdd7-4366-b27f-34422567847c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc71656a-3da9-4b7e-b8c2-af2f1c58e951");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "38134da4-7669-4a5a-86a4-8c74ac1d17e6");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "66d73f06-3aa7-4a50-a314-18e8053d9925");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "864113d3-ef4e-4fe4-adbf-42980b30f76d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d3c9eefd-6508-474b-b0d6-d514a6645d42");

            migrationBuilder.DropColumn(
                name: "OrderCost",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShippingAddress",
                table: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Order",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShippingAddressId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "CreditCardExpiry", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "049a1404-b475-4dc7-b053-fb0ecab7d3df", 0, "68049a6e-f0cf-46d9-8aaa-28c1f080456d", null, null, null, "tester2@gmail.com", true, "Test2FirstName", 3, false, false, "Test2LastName", false, null, 6, "TESTER2@GMAIL.COM", "TESTER2", "AQAAAAEAACcQAAAAENglfEr4YLjx3Q2XVjRi0Fd7GewT6umYqnFrnwNxloBVx1FGWsVXt44bADjO8V+0Bg==", null, true, 6, "8dfffdb0-7322-4de3-841b-00c07d6cadc0", false, "Tester2" },
                    { "42137bba-a246-4f8e-8f8f-4678cc45c9d6", 0, "dd036021-e384-4ffb-8a51-d1d9c69e7393", null, null, null, "moderator@gmail.com", true, "Francis", 3, false, false, "Ramos", false, null, 3, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAEAACcQAAAAEPLyq1MOedavXKyYGjy93jOreFQHPj5fQgpybI1CbvoKcZ8xS0Nio2qDmf8wkmT6DA==", null, true, 3, "891cdd88-499f-4a19-9ddd-fb057d2f1ca3", false, "Moderator" },
                    { "84f7bede-1191-4cc7-8fcf-f00baa571937", 0, "2e6769cb-1673-4e8d-a7ee-890b617d0703", null, null, null, "superadmin@gmail.com", true, "Tyrone", 3, false, false, "Mcgee", false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEFpj83d4gDMFJAPraJgA2iNvcqHX5Y6szPBhLVVUB7Y7e+906pYalyCzJcKeRq13SA==", null, true, 1, "44f8773a-b882-49b8-b23d-51c4ddf622ad", false, "SuperAdmin" },
                    { "ceab126d-5b79-4168-964f-160d0e705dc3", 0, "113b1dc5-cbc6-461f-b213-cef44843116a", null, null, null, "admin@gmail.com", true, "William", 3, false, false, "Potter", false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOh+VedE3SEJBhUGaOvfTi25yFZts4bglF9YfIaXckqLSP/QFIeWG69ouCM2EY9Mnw==", null, true, 2, "251a35ca-a068-4dfe-8da1-d1627ae05a9d", false, "Admin" },
                    { "e9df12f9-87cd-4bb5-8a06-514dbf164b10", 0, "7f89607f-9cf1-4f42-8895-ffa9af62c559", null, null, null, "tester1@gmail.com", true, "Test1FirstName", 3, false, false, "Test1LastName", false, null, 5, "TESTER1@GMAIL.COM", "TESTER1", "AQAAAAEAACcQAAAAEClVZYp6FI6wY6/yqz3eI1sSxE9awuFKtjJIu8p6qRLZv/TVqNOI5wH/1sZw02+9wg==", null, true, 5, "f8532e79-2de8-4f04-a79e-b3b28df404c1", false, "Tester1" },
                    { "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7", 0, "37015c73-a5aa-469b-8d01-89cd03ac70fd", null, null, null, "member@gmail.com", true, "Ernest", 3, false, false, "Mcknight", false, null, 4, "MEMBER@GMAIL.COM", "MEMBER", "AQAAAAEAACcQAAAAEISWL1aHQJrVvBlTfWhCG7c2ofoIav2qemqDd0yMejaNYEd7OBwZNd7xRkz53RwFrw==", null, true, 4, "01181263-b38d-4ce5-af25-78ced455baab", false, "Member" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "409b3be1-8199-4378-8083-1595f2dbd971", "e4dd4e81-eb29-4396-8f1c-b1fb8093977f", "Admin", "ADMIN" },
                    { "7a6154ec-dad0-40ff-abb9-ce8fbafec3e4", "28dc0b97-08a5-4697-947d-edc2c4fa8ab5", "SuperAdmin", "SUPERADMIN" },
                    { "9a6e4eb8-347d-408c-8380-0b15b013dddf", "13b7e5ba-9614-4058-9ade-1473436b3537", "Moderator", "MODERATOR" },
                    { "aeebb091-081d-4c23-bde0-690dd94090f2", "8ed36979-8b41-4bff-9952-ed10bead31a8", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "42137bba-a246-4f8e-8f8f-4678cc45c9d6" },
                    { 1, "ceab126d-5b79-4168-964f-160d0e705dc3" },
                    { 1, "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" },
                    { 2, "ceab126d-5b79-4168-964f-160d0e705dc3" },
                    { 2, "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" }
                });

            migrationBuilder.InsertData(
                table: "FriendFamily",
                columns: new[] { "ReceiverUserId", "RequesterUserId", "Description", "Status" },
                values: new object[,]
                {
                    { "84f7bede-1191-4cc7-8fcf-f00baa571937", "42137bba-a246-4f8e-8f8f-4678cc45c9d6", "Family", "Pending" },
                    { "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7", "42137bba-a246-4f8e-8f8f-4678cc45c9d6", "Family", "Processed" },
                    { "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7", "ceab126d-5b79-4168-964f-160d0e705dc3", "Friend", "Processed" },
                    { "84f7bede-1191-4cc7-8fcf-f00baa571937", "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7", "Friend", "Pending" }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "ShippingAddressId", "UserId" },
                values: new object[] { 4, "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "ShippingAddressId", "UserId" },
                values: new object[] { 2, "ceab126d-5b79-4168-964f-160d0e705dc3" });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "ShippingAddressId", "UserId" },
                values: new object[] { 3, "42137bba-a246-4f8e-8f8f-4678cc45c9d6" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "UserId",
                value: "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "UserId",
                value: "ceab126d-5b79-4168-964f-160d0e705dc3");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "UserId",
                value: "42137bba-a246-4f8e-8f8f-4678cc45c9d6");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "UserId",
                value: "42137bba-a246-4f8e-8f8f-4678cc45c9d6");

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "aeebb091-081d-4c23-bde0-690dd94090f2", "049a1404-b475-4dc7-b053-fb0ecab7d3df" },
                    { "9a6e4eb8-347d-408c-8380-0b15b013dddf", "42137bba-a246-4f8e-8f8f-4678cc45c9d6" },
                    { "7a6154ec-dad0-40ff-abb9-ce8fbafec3e4", "84f7bede-1191-4cc7-8fcf-f00baa571937" },
                    { "409b3be1-8199-4378-8083-1595f2dbd971", "ceab126d-5b79-4168-964f-160d0e705dc3" },
                    { "aeebb091-081d-4c23-bde0-690dd94090f2", "e9df12f9-87cd-4bb5-8a06-514dbf164b10" },
                    { "aeebb091-081d-4c23-bde0-690dd94090f2", "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7" }
                });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "GameId", "UserId" },
                values: new object[] { 1, "e9df12f9-87cd-4bb5-8a06-514dbf164b10" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ShippingAddress_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId",
                principalTable: "ShippingAddress",
                principalColumn: "ShippingAddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
