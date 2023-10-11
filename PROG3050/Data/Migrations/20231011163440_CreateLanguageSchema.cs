using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreateLanguageSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Gender_GenderId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

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

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Preference",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "GenderId");

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageId);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4013c02f-da9b-462e-a651-27df8a398432", 0, "d50fc429-1daf-4ff1-8baa-e4f542d7ef1c", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@gmail.com", true, null, 3, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAEPKjinScM8l2wJrYcLUHFsqEqc+sJfCbLRkjVKup2njA2jp3VEGUvz6uzDq2uat7Kg==", null, true, 4, "3c8e2702-327c-4a6c-b1ac-8f7bb022b670", false, "Basic" },
                    { "5cd51d58-e7cf-4d45-a466-d35e7cfdd12e", 0, "53adeeb3-588f-4963-8098-06a9b5dfd847", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, 3, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEDsGZzINPuTqw1zO1nY/vJYgUmcbAxwzFTLjIf5PAbr4+8aEOWB0t5esvxCMjz1AqA==", null, true, 2, "6771752b-c6ec-44a7-8866-d0b39cee514f", false, "Admin" },
                    { "5e15911b-7ab3-4d61-a5e6-9be6533af0d9", 0, "e1977eb2-c3a7-4732-808a-946d0d82f7e9", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@gmail.com", true, null, 3, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEAeJ79laqdRv/+jrgEBeNSnrbtcsGVUkEcM+5fJjqfCyE1AWzoxNZFtrsrDVOr7wLg==", null, true, 3, "ef267705-3e6e-474c-a022-969827876abc", false, "Moderator" },
                    { "eca07943-dbe8-4c80-80db-56fef2fe1905", 0, "bfdd761a-7b7b-4186-9fc9-8c34bd7fc787", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", true, null, 3, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEAMAZDmxQqaezTGE1dJasA4tiGFKLDeGbncvDnWxH8rHZR8VPTIC4cpaA/O4BKK8Cw==", null, true, 1, "ed17700a-5b2c-4274-a34f-21536e9bf3af", false, "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "LanguageId", "LanguageName" },
                values: new object[] { 1, "English" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06387c15-c763-42d3-96dc-11b7438157ac", "36fef08c-fd7e-43e7-b00f-d93f68c415e7", "Moderator", "MODERATOR" },
                    { "a56b54d5-d23c-4d98-9fd5-7a825e7006a5", "28795fc3-bb25-41a1-9754-1ce2dbcd0e5c", "Admin", "ADMIN" },
                    { "c0e00191-9b00-499d-a525-1afb8d42f53a", "3039a89f-abf8-4c5e-8785-018ffb2aec10", "SuperAdmin", "SUPERADMIN" },
                    { "e93225a6-2264-4f47-aee1-c2483080f5e4", "3efc8e46-50c5-4715-a3c5-559983c0faf4", "Basic", "BASIC" }
                });

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 1,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 2,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 3,
                column: "LanguageId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 4,
                column: "LanguageId",
                value: 1);

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e93225a6-2264-4f47-aee1-c2483080f5e4", "4013c02f-da9b-462e-a651-27df8a398432" },
                    { "a56b54d5-d23c-4d98-9fd5-7a825e7006a5", "5cd51d58-e7cf-4d45-a466-d35e7cfdd12e" },
                    { "06387c15-c763-42d3-96dc-11b7438157ac", "5e15911b-7ab3-4d61-a5e6-9be6533af0d9" },
                    { "c0e00191-9b00-499d-a525-1afb8d42f53a", "eca07943-dbe8-4c80-80db-56fef2fe1905" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Preference_LanguageId",
                table: "Preference",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Genders_GenderId",
                table: "AspNetUsers",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Preference_Language_LanguageId",
                table: "Preference",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Genders_GenderId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Preference_Language_LanguageId",
                table: "Preference");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Preference_LanguageId",
                table: "Preference");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e93225a6-2264-4f47-aee1-c2483080f5e4", "4013c02f-da9b-462e-a651-27df8a398432" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a56b54d5-d23c-4d98-9fd5-7a825e7006a5", "5cd51d58-e7cf-4d45-a466-d35e7cfdd12e" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "06387c15-c763-42d3-96dc-11b7438157ac", "5e15911b-7ab3-4d61-a5e6-9be6533af0d9" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c0e00191-9b00-499d-a525-1afb8d42f53a", "eca07943-dbe8-4c80-80db-56fef2fe1905" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4013c02f-da9b-462e-a651-27df8a398432");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cd51d58-e7cf-4d45-a466-d35e7cfdd12e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e15911b-7ab3-4d61-a5e6-9be6533af0d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eca07943-dbe8-4c80-80db-56fef2fe1905");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "06387c15-c763-42d3-96dc-11b7438157ac");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a56b54d5-d23c-4d98-9fd5-7a825e7006a5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c0e00191-9b00-499d-a525-1afb8d42f53a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "e93225a6-2264-4f47-aee1-c2483080f5e4");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Preference");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "GenderId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7c3bd4f8-d084-4084-b62e-b3df79610807", 0, "016b0a25-c33a-4d4d-ba47-16fdc72fd555", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@gmail.com", true, null, 3, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAEFLXpkDLAfHyXlSTRSrOux/E6S5HO3P4kKYDBIXk+MVxIYFQMzkyZAMnIVDNnSzbnw==", null, true, 4, "43bd39a6-26f1-4323-9662-14df6c74af1d", false, "Basic" },
                    { "835796e9-b68c-4776-be93-9ae9066ba37f", 0, "ba694a39-285d-4543-b786-470a973c865c", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "superadmin@gmail.com", true, null, 3, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEFaQv8mQ54gMygn90bVBVZ2Ue+CrsXCuoF7MhhAImZeor7Q2nAphiIOa84s+ax6RpA==", null, true, 1, "479cb410-09fa-4887-a609-aa409953841a", false, "SuperAdmin" },
                    { "9a12fb9f-5416-43fd-a405-4c569007d3b0", 0, "1d46af2e-8de0-4e05-ac43-33a3397304a5", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, null, 3, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEGIq5AA33zsKqHy+ElVRPSYbJa72Vf2iECFoEfSH1i6bx8zh1ewSxMH8BSe/+1imlQ==", null, true, 2, "6214f770-71ec-4df8-a85e-dc5747794074", false, "Admin" },
                    { "ed899802-efc8-4da0-8cac-52656df9a29f", 0, "c1f4cf1a-66a0-413b-afc7-53acc4aba4eb", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@gmail.com", true, null, 3, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEEHKXemvSo/LWoPCu0yruepRaeOg2PfzQWwEulvULU5rY4RJxIBnDs2+ZLuCUkDhTg==", null, true, 3, "78bf7680-39d9-4c19-a79e-76b3e6753341", false, "Moderator" }
                });

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
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1f33fe8d-b3d4-4129-baf0-3927e7d9c8f0", "7c3bd4f8-d084-4084-b62e-b3df79610807" },
                    { "d1242b95-91ef-4b6d-86fe-fa62704d161f", "835796e9-b68c-4776-be93-9ae9066ba37f" },
                    { "cb781dc5-59d4-4b03-87e8-4c63a215a87c", "9a12fb9f-5416-43fd-a405-4c569007d3b0" },
                    { "9b8fc441-6881-4be1-b169-5e63729e03cb", "ed899802-efc8-4da0-8cac-52656df9a29f" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Gender_GenderId",
                table: "AspNetUsers",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "GenderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
