using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class UpdateUserWithCreditCardExpiry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreditCardExpiry",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

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
                column: "UserId",
                value: "fb5f2467-38cd-455c-a8e8-5c72a6ca19e7");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "UserId",
                value: "ceab126d-5b79-4168-964f-160d0e705dc3");

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "UserId",
                value: "42137bba-a246-4f8e-8f8f-4678cc45c9d6");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "CreditCardExpiry",
                table: "AspNetUsers");

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
        }
    }
}
