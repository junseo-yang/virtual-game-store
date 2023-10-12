using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class CreatePreferenceFavouritePlatformSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Preference_FavouritePlatform_FavouritePlatformId",
                table: "Preference");

            migrationBuilder.DropIndex(
                name: "IX_Preference_FavouritePlatformId",
                table: "Preference");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ae0eb5e-034a-4568-a9b0-a2870c697f6c", "1e06a759-30fd-4878-9e78-baa7a68b2ba4" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f7ca194-6dac-4733-afe7-631dd7768c14", "b3a09fe7-aa7f-450a-8b44-763ba95ed432" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ef3717b9-7c8d-4bc0-b5aa-64ca371df24a", "ccf4bbc3-4c23-4aab-b4b2-14a27ab52aa1" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8ce78e2-618a-43d7-be3c-4f3c8d53c4e7", "fad57948-23b9-47f9-8453-3a352d8f977c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e06a759-30fd-4878-9e78-baa7a68b2ba4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3a09fe7-aa7f-450a-8b44-763ba95ed432");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf4bbc3-4c23-4aab-b4b2-14a27ab52aa1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fad57948-23b9-47f9-8453-3a352d8f977c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3f7ca194-6dac-4733-afe7-631dd7768c14");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8ae0eb5e-034a-4568-a9b0-a2870c697f6c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ef3717b9-7c8d-4bc0-b5aa-64ca371df24a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f8ce78e2-618a-43d7-be3c-4f3c8d53c4e7");

            migrationBuilder.DropColumn(
                name: "FavouritePlatformId",
                table: "Preference");

            migrationBuilder.CreateTable(
                name: "PreferenceFavouritePlatform",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(type: "int", nullable: false),
                    FavouritePlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferenceFavouritePlatform", x => new { x.PreferenceId, x.FavouritePlatformId });
                    table.ForeignKey(
                        name: "FK_PreferenceFavouritePlatform_FavouritePlatform_FavouritePlatformId",
                        column: x => x.FavouritePlatformId,
                        principalTable: "FavouritePlatform",
                        principalColumn: "FavouritePlatformId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreferenceFavouritePlatform_Preference_PreferenceId",
                        column: x => x.PreferenceId,
                        principalTable: "Preference",
                        principalColumn: "PreferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "272d49b0-3428-431c-995d-41da8d49063c", 0, "01b9180f-8ea2-4118-b10a-8a1a01ef9f52", null, null, "superadmin@gmail.com", true, null, 3, false, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEPLnU73KaWL6Z75awgTg3wFiTt77B0zVZW0Z8VO/UL3Nxvhipa1XqAZpsbZ99WPA0Q==", null, true, 1, "14d1a896-a534-4cff-8fb7-b406c18ba953", false, "SuperAdmin" },
                    { "57e65a64-91b9-4812-a8c6-23db3911deaa", 0, "c091bd73-6660-4f9f-a45b-bcdba4bd19f1", null, null, "admin@gmail.com", true, null, 3, false, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOKtlr13LFpRADBwcXcTqPpVjgwJjeKPLYviOEEncMv+FNVVjv/D51e4q9WbiUdcTA==", null, true, 2, "1afd7aac-3093-4470-ad2b-e6132b499ae3", false, "Admin" },
                    { "ae83a109-b456-4545-ab4e-fd1fbb53828c", 0, "553fd713-4675-438e-bab3-8ca92645b2a6", null, null, "basic@gmail.com", true, null, 3, false, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAEB19LOhSRbzJ8QdnTAbMrMp49y/PtI8lMxlMf49DqYeeuFVuJcQ0p2FPBlUYjJp6dA==", null, true, 4, "310d916e-ce6a-40fd-8f4e-106d75685dde", false, "Basic" },
                    { "ce5a4d1f-9173-4158-8210-22f2f6be9c56", 0, "6644f646-7b45-4bdb-87ce-a2712d2dbd99", null, null, "moderator@gmail.com", true, null, 3, false, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAENpusdG/EMC2Dl0bmmZ2BgOpP0uZFC4dlPl5qUUwiPk1Fu05MlCAihASwikqJgie6A==", null, true, 3, "22945467-baba-49f7-a7f3-5fef885c091d", false, "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "PreferenceFavouritePlatform",
                columns: new[] { "FavouritePlatformId", "PreferenceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 },
                    { 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1bb281d5-9ce0-4e67-bd4e-967e44c8c068", "19f3e159-15ac-4272-8251-6e07a63c3d27", "Basic", "BASIC" },
                    { "4e73d15d-a0a7-4a42-a974-0f3202a92e0f", "9ebbaad3-32ca-4b27-a15d-fa7a236a0881", "Admin", "ADMIN" },
                    { "7845e505-01a7-4a1d-bf3a-0d4ce9017c4b", "dd5cb95a-d289-4fd3-87e5-c28a2d89baa9", "Moderator", "MODERATOR" },
                    { "f806b3a2-933b-43e5-87f7-f015988dbebe", "b4d1cc66-e23e-46ba-8a8a-de4eb367a760", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f806b3a2-933b-43e5-87f7-f015988dbebe", "272d49b0-3428-431c-995d-41da8d49063c" },
                    { "4e73d15d-a0a7-4a42-a974-0f3202a92e0f", "57e65a64-91b9-4812-a8c6-23db3911deaa" },
                    { "1bb281d5-9ce0-4e67-bd4e-967e44c8c068", "ae83a109-b456-4545-ab4e-fd1fbb53828c" },
                    { "7845e505-01a7-4a1d-bf3a-0d4ce9017c4b", "ce5a4d1f-9173-4158-8210-22f2f6be9c56" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreferenceFavouritePlatform_FavouritePlatformId",
                table: "PreferenceFavouritePlatform",
                column: "FavouritePlatformId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PreferenceFavouritePlatform");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f806b3a2-933b-43e5-87f7-f015988dbebe", "272d49b0-3428-431c-995d-41da8d49063c" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4e73d15d-a0a7-4a42-a974-0f3202a92e0f", "57e65a64-91b9-4812-a8c6-23db3911deaa" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1bb281d5-9ce0-4e67-bd4e-967e44c8c068", "ae83a109-b456-4545-ab4e-fd1fbb53828c" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7845e505-01a7-4a1d-bf3a-0d4ce9017c4b", "ce5a4d1f-9173-4158-8210-22f2f6be9c56" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "272d49b0-3428-431c-995d-41da8d49063c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e65a64-91b9-4812-a8c6-23db3911deaa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae83a109-b456-4545-ab4e-fd1fbb53828c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce5a4d1f-9173-4158-8210-22f2f6be9c56");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1bb281d5-9ce0-4e67-bd4e-967e44c8c068");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4e73d15d-a0a7-4a42-a974-0f3202a92e0f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "7845e505-01a7-4a1d-bf3a-0d4ce9017c4b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f806b3a2-933b-43e5-87f7-f015988dbebe");

            migrationBuilder.AddColumn<int>(
                name: "FavouritePlatformId",
                table: "Preference",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e06a759-30fd-4878-9e78-baa7a68b2ba4", 0, "d2dba4a1-39bc-46bf-9715-8ee41f0c0521", null, null, "superadmin@gmail.com", true, null, 3, false, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEGx2H6zf8sEGXbr0fJ09F+Vs1Ad05FJc4uAO4xLjFJSqw5KEnHmxucDucpncipkFyQ==", null, true, 1, "15eba815-e99d-4348-b957-c29bf0007f6e", false, "SuperAdmin" },
                    { "b3a09fe7-aa7f-450a-8b44-763ba95ed432", 0, "342c4fb2-e2fb-4924-998f-e96472306a50", null, null, "admin@gmail.com", true, null, 3, false, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEHofngcKXCH2GZz1wbtNM+ev4O6qQPjfzy/F4tvEsGSgu1en0UX4csVaO65LJsDv7Q==", null, true, 2, "053bfd86-97e8-4fa5-a3e9-226378344f9f", false, "Admin" },
                    { "ccf4bbc3-4c23-4aab-b4b2-14a27ab52aa1", 0, "971f5c9b-c2a3-4763-b383-f3464eb18dc6", null, null, "basic@gmail.com", true, null, 3, false, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAENsfNe0K5VxWzJoPwObAi4fHIS2oBMQ0YmSm3vgd+jVMexn4a42JTlB20syLe3Gy4g==", null, true, 4, "140dda03-2931-458f-8142-73e4988a21b4", false, "Basic" },
                    { "fad57948-23b9-47f9-8453-3a352d8f977c", 0, "6c8a1e8c-fe39-4b5d-8c79-eaa00331a267", null, null, "moderator@gmail.com", true, null, 3, false, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAED8dhI5MwmWLNvNgZeKJ+3yetBmOSYzFhef8kc2J792eLVZXvxbkMYRI9KJU4A52Qw==", null, true, 3, "abf2cc06-3834-498a-882c-880959be2146", false, "Moderator" }
                });

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 1,
                column: "FavouritePlatformId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 2,
                column: "FavouritePlatformId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 3,
                column: "FavouritePlatformId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 4,
                column: "FavouritePlatformId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f7ca194-6dac-4733-afe7-631dd7768c14", "cc6db016-b09d-4041-ad0a-1b49e5f89a83", "Admin", "ADMIN" },
                    { "8ae0eb5e-034a-4568-a9b0-a2870c697f6c", "fee6a4ac-41e7-407e-ab24-fb30443c8063", "SuperAdmin", "SUPERADMIN" },
                    { "ef3717b9-7c8d-4bc0-b5aa-64ca371df24a", "f5baa046-d881-452f-9d43-3a4155c88e50", "Basic", "BASIC" },
                    { "f8ce78e2-618a-43d7-be3c-4f3c8d53c4e7", "0d31767f-64e2-4d59-8ace-af0cecb19ea2", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8ae0eb5e-034a-4568-a9b0-a2870c697f6c", "1e06a759-30fd-4878-9e78-baa7a68b2ba4" },
                    { "3f7ca194-6dac-4733-afe7-631dd7768c14", "b3a09fe7-aa7f-450a-8b44-763ba95ed432" },
                    { "ef3717b9-7c8d-4bc0-b5aa-64ca371df24a", "ccf4bbc3-4c23-4aab-b4b2-14a27ab52aa1" },
                    { "f8ce78e2-618a-43d7-be3c-4f3c8d53c4e7", "fad57948-23b9-47f9-8453-3a352d8f977c" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Preference_FavouritePlatformId",
                table: "Preference",
                column: "FavouritePlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Preference_FavouritePlatform_FavouritePlatformId",
                table: "Preference",
                column: "FavouritePlatformId",
                principalTable: "FavouritePlatform",
                principalColumn: "FavouritePlatformId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
