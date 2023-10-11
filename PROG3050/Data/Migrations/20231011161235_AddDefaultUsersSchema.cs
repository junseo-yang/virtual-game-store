using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class AddDefaultUsersSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "835796e9-b68c-4776-be93-9ae9066ba37f", 0, "ba694a39-285d-4543-b786-470a973c865c", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", true, null, 3, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEFaQv8mQ54gMygn90bVBVZ2Ue+CrsXCuoF7MhhAImZeor7Q2nAphiIOa84s+ax6RpA==", null, true, 1, "479cb410-09fa-4887-a609-aa409953841a", false, "SuperAdmin" },
                    { "9a12fb9f-5416-43fd-a405-4c569007d3b0", 0, "1d46af2e-8de0-4e05-ac43-33a3397304a5", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, 3, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEGIq5AA33zsKqHy+ElVRPSYbJa72Vf2iECFoEfSH1i6bx8zh1ewSxMH8BSe/+1imlQ==", null, true, 2, "6214f770-71ec-4df8-a85e-dc5747794074", false, "Admin" },
                    { "ed899802-efc8-4da0-8cac-52656df9a29f", 0, "c1f4cf1a-66a0-413b-afc7-53acc4aba4eb", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@gmail.com", true, null, 3, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEEHKXemvSo/LWoPCu0yruepRaeOg2PfzQWwEulvULU5rY4RJxIBnDs2+ZLuCUkDhTg==", null, true, 3, "78bf7680-39d9-4c19-a79e-76b3e6753341", false, "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "Preference",
                columns: new[] { "PreferenceId", "FavouritePlatformId", "PromotionalEmail" },
                values: new object[] { 4, 1, false });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f33fe8d-b3d4-4129-baf0-3927e7d9c8f0", "2c5bfd91-58a0-4140-8e1c-9aeb64c040f0", "Basic", "BASIC" },
                    { "9b8fc441-6881-4be1-b169-5e63729e03cb", "bcb629d2-7931-40b4-9b69-610122046f1a", "Moderator", "MODERATOR" },
                    { "cb781dc5-59d4-4b03-87e8-4c63a215a87c", "c16e6ecf-4c5d-4d87-98ee-e3a9fcf9e9aa", "Admin", "ADMIN" },
                    { "d1242b95-91ef-4b6d-86fe-fa62704d161f", "3c779e49-e2bd-4219-84fe-fc6ab744811c", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c3bd4f8-d084-4084-b62e-b3df79610807", 0, "016b0a25-c33a-4d4d-ba47-16fdc72fd555", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@gmail.com", true, null, 3, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAEFLXpkDLAfHyXlSTRSrOux/E6S5HO3P4kKYDBIXk+MVxIYFQMzkyZAMnIVDNnSzbnw==", null, true, 4, "43bd39a6-26f1-4323-9662-14df6c74af1d", false, "Basic" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d1242b95-91ef-4b6d-86fe-fa62704d161f", "835796e9-b68c-4776-be93-9ae9066ba37f" },
                    { "cb781dc5-59d4-4b03-87e8-4c63a215a87c", "9a12fb9f-5416-43fd-a405-4c569007d3b0" },
                    { "9b8fc441-6881-4be1-b169-5e63729e03cb", "ed899802-efc8-4da0-8cac-52656df9a29f" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1f33fe8d-b3d4-4129-baf0-3927e7d9c8f0", "7c3bd4f8-d084-4084-b62e-b3df79610807" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f33fe8d-b3d4-4129-baf0-3927e7d9c8f0", "7c3bd4f8-d084-4084-b62e-b3df79610807" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1242b95-91ef-4b6d-86fe-fa62704d161f", "835796e9-b68c-4776-be93-9ae9066ba37f" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cb781dc5-59d4-4b03-87e8-4c63a215a87c", "9a12fb9f-5416-43fd-a405-4c569007d3b0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9b8fc441-6881-4be1-b169-5e63729e03cb", "ed899802-efc8-4da0-8cac-52656df9a29f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c3bd4f8-d084-4084-b62e-b3df79610807");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "835796e9-b68c-4776-be93-9ae9066ba37f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a12fb9f-5416-43fd-a405-4c569007d3b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed899802-efc8-4da0-8cac-52656df9a29f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1f33fe8d-b3d4-4129-baf0-3927e7d9c8f0");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9b8fc441-6881-4be1-b169-5e63729e03cb");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "cb781dc5-59d4-4b03-87e8-4c63a215a87c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d1242b95-91ef-4b6d-86fe-fa62704d161f");

            migrationBuilder.DeleteData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 4);

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
    }
}
