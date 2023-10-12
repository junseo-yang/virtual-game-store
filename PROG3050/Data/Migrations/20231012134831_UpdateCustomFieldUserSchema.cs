using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class UpdateCustomFieldUserSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "PromotionalEmail",
                table: "Preference");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "IsPromotionalEmail",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "IsPromotionalEmail",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "PromotionalEmail",
                table: "Preference",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Preference",
                keyColumn: "PreferenceId",
                keyValue: 2,
                column: "PromotionalEmail",
                value: true);

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
        }
    }
}
