using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class RemoveProvinceCountrySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MailingAddress_Province_ProvinceId",
                table: "MailingAddress");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_MailingAddress_ProvinceId",
                table: "MailingAddress");

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

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "MailingAddress");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "MailingAddress",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "MailingAddress",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 1,
                columns: new[] { "Country", "Province" },
                values: new object[] { "Canada", "NU" });

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 2,
                columns: new[] { "Country", "Province" },
                values: new object[] { "Canada", "ON" });

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 3,
                columns: new[] { "Country", "Province" },
                values: new object[] { "Canada", "AB" });

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 4,
                columns: new[] { "Country", "Province" },
                values: new object[] { "Canada", "BC" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Country",
                table: "MailingAddress");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "MailingAddress");

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "MailingAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Province_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
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
                table: "Country",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[] { 1, "Canada" });

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
                table: "Province",
                columns: new[] { "ProvinceId", "CountryId", "ProvinceName" },
                values: new object[,]
                {
                    { 1, 1, "AB" },
                    { 2, 1, "BC" },
                    { 3, 1, "MB" },
                    { 4, 1, "NB" },
                    { 5, 1, "NL" },
                    { 6, 1, "NT" },
                    { 7, 1, "NS" },
                    { 8, 1, "NU" },
                    { 9, 1, "ON" },
                    { 10, 1, "PE" },
                    { 11, 1, "QC" },
                    { 12, 1, "SK" },
                    { 13, 1, "YT" }
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

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 1,
                column: "ProvinceId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 2,
                column: "ProvinceId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 3,
                column: "ProvinceId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MailingAddress",
                keyColumn: "MailingAddressId",
                keyValue: 4,
                column: "ProvinceId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_MailingAddress_ProvinceId",
                table: "MailingAddress",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryId",
                table: "Province",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MailingAddress_Province_ProvinceId",
                table: "MailingAddress",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
