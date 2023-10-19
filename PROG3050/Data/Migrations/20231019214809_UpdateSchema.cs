using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROG3050.Data.Migrations
{
    public partial class UpdateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_User_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_User_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_User_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_User_UserId",
                table: "UserTokens");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "User");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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
                name: "FavouritePlatform",
                columns: table => new
                {
                    FavouritePlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouritePlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouritePlatform", x => x.FavouritePlatformId);
                });

            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    GameCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => x.GameCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

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
                name: "Province",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Preference",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preference", x => x.PreferenceId);
                    table.ForeignKey(
                        name: "FK_Preference_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MailingAddress",
                columns: table => new
                {
                    MailingAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailingAddress", x => x.MailingAddressId);
                    table.ForeignKey(
                        name: "FK_MailingAddress_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "PreferenceGameCategory",
                columns: table => new
                {
                    PreferenceId = table.Column<int>(type: "int", nullable: false),
                    GameCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferenceGameCategory", x => new { x.PreferenceId, x.GameCategoryId });
                    table.ForeignKey(
                        name: "FK_PreferenceGameCategory_GameCategory_GameCategoryId",
                        column: x => x.GameCategoryId,
                        principalTable: "GameCategory",
                        principalColumn: "GameCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PreferenceGameCategory_Preference_PreferenceId",
                        column: x => x.PreferenceId,
                        principalTable: "Preference",
                        principalColumn: "PreferenceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailingAddressId = table.Column<int>(type: "int", nullable: false),
                    IsAddressSame = table.Column<bool>(type: "bit", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPromotionalEmail = table.Column<bool>(type: "bit", nullable: false),
                    CreditCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferenceId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_MailingAddress_MailingAddressId",
                        column: x => x.MailingAddressId,
                        principalTable: "MailingAddress",
                        principalColumn: "MailingAddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Preference_PreferenceId",
                        column: x => x.PreferenceId,
                        principalTable: "Preference",
                        principalColumn: "PreferenceId",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Country",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 1, "Canada" },
                    { 2, "US" }
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
                table: "FavouritePlatform",
                columns: new[] { "FavouritePlatformId", "FavouritePlatformName" },
                values: new object[,]
                {
                    { 1, "PC" },
                    { 2, "Mobile" },
                    { 3, "Console" },
                    { 4, "Others" }
                });

            migrationBuilder.InsertData(
                table: "GameCategory",
                columns: new[] { "GameCategoryId", "GameCategoryName" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "FPS" },
                    { 4, "Shooter" },
                    { 5, "Others" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" },
                    { 3, "Others" }
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
                    { "0475ff1a-69d1-458a-b0a4-3a0a651ae0a6", "d3d85868-8423-4a10-8550-59f26987f7fa", "Moderator", "MODERATOR" },
                    { "9e7b981b-da47-4597-a17a-ae4df723981d", "85e4cfe0-bf4a-4e51-8947-66917e23a990", "Basic", "BASIC" },
                    { "c1a9e393-125c-4548-9489-21b9808a61df", "1d5b0745-4f2d-4f15-a1bc-16b329100f0d", "Admin", "ADMIN" },
                    { "f80cf2ae-f5b3-422e-8225-6a760b3bd6df", "86557d82-7438-4805-b51b-4fa239fc49fa", "SuperAdmin", "SUPERADMIN" }
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
                table: "Game",
                columns: new[] { "GameId", "Description", "GameCategoryId", "Price", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "For over two decades, Counter-Strike has offered an elite competitive experience, one shaped by millions of players from across the globe. And now the next chapter in the CS story is about to begin. This is Counter-Strike 2.", 3, 0.0, new DateTime(2012, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Counter-Strike 2" },
                    { 2, "Star Trek: Infinite is a grand strategy experience that lets you play your own Star Trek story as the leader of one of four major factions in the galaxy. Follow the specially crafted story or blaze your own trail in the first Star Trek grand strategy game.", 1, 39.990000000000002, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Trek: Infinite" },
                    { 3, "Raise a city from the ground up and transform it into a thriving metropolis with the most realistic city builder ever. Push your creativity and problem-solving to build on a scale you've never experienced. With deep simulation and a living economy, this is world-building without limits.", 2, 59.990000000000002, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cities: Skylines II" }
                });

            migrationBuilder.InsertData(
                table: "Preference",
                columns: new[] { "PreferenceId", "LanguageId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 }
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
                table: "MailingAddress",
                columns: new[] { "MailingAddressId", "City", "DeliveryInstruction", "PostalCode", "ProvinceId", "Street", "Unit" },
                values: new object[,]
                {
                    { 1, "HALIFAX", "At the door", "B3J 2B3", 7, "978 ARGYLE ST N", null },
                    { 2, "TORONTO", "At the Post Box", "M4K 1M8", 9, "87 DANFORTH AVE", "501" },
                    { 3, "BIG VALLEY", null, "T0L 1K0", 1, "4 FIRST AVE S", null },
                    { 4, "COURTENAY", "Ask the security Guard to get in.", "V9N 0A7", 2, "PO BOX 4600 STN B", null }
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
                table: "PreferenceGameCategory",
                columns: new[] { "GameCategoryId", "PreferenceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "101de009-6ad9-4d24-a495-67bb602d0532", 0, "1085ab21-0cec-465d-b1f5-99c0ecbaa615", null, null, "moderator@gmail.com", true, null, 3, false, false, null, false, null, 3, "MODERATOR", "MODERATOR@GMAIL.COM", "AQAAAAEAACcQAAAAEGt2ldxsN6en5Mj39Ug3pEyHHStUKAXVYmO21LsvIbrQYFDnw34DKD8sRU1jKuJ9Ig==", null, true, 3, "f6cceded-1ea2-4a61-90fe-5b11dae784e7", false, "Moderator" },
                    { "4c22c984-e9df-4f81-a46c-11851ac4bf64", 0, "168be87d-538d-413f-bfb1-b09353dfd18e", null, null, "admin@gmail.com", true, null, 3, false, false, null, false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELKC6bNnpdUriR1GS7AeLLs9pUX+IetcNRPbgTGgceh5oeiknD2tlOOr7mcLdsAXWg==", null, true, 2, "22147c4a-aae8-4c74-9fc2-f36756d8ee85", false, "Admin" },
                    { "e03c8494-17d9-413f-b484-36dc8054f0e0", 0, "b5fc16db-6df0-4c99-a664-b14b0235247e", null, null, "superadmin@gmail.com", true, null, 3, false, false, null, false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAELBk2e6swexqfCS65M+PNu0G0UUYrZZnOHCJj0FmEa9M0m91kTW03qrNoVnxpFU5fQ==", null, true, 1, "a5cf4025-35db-423a-9219-f1aa5da4ab1a", false, "SuperAdmin" },
                    { "e40efa73-04a9-4e42-8f09-ab45b8676397", 0, "245b5b63-c6b6-4212-8578-ad6b0f962641", null, null, "basic@gmail.com", true, null, 3, false, false, null, false, null, 4, "BASIC@GMAIL.COM", "BASIC", "AQAAAAEAACcQAAAAECkpmgPfszc9WZjjEcp13SmDJLJa2VR3yNP74J0/GnhIpJW+CEFBMJ75I4Xydv0x1g==", null, true, 4, "2cef32a7-66dd-4d53-8cca-ad91d1ad9845", false, "Basic" }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "101de009-6ad9-4d24-a495-67bb602d0532" },
                    { 1, "4c22c984-e9df-4f81-a46c-11851ac4bf64" },
                    { 1, "e40efa73-04a9-4e42-8f09-ab45b8676397" },
                    { 2, "4c22c984-e9df-4f81-a46c-11851ac4bf64" },
                    { 2, "e40efa73-04a9-4e42-8f09-ab45b8676397" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "ShippingAddressId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Processed", "e40efa73-04a9-4e42-8f09-ab45b8676397" },
                    { 2, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Processed", "4c22c984-e9df-4f81-a46c-11851ac4bf64" },
                    { 3, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Pending", "101de009-6ad9-4d24-a495-67bb602d0532" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "Description", "GameId", "Rating", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 1, 5.0, "Pending", "The Best Game!", "e40efa73-04a9-4e42-8f09-ab45b8676397" },
                    { 2, "Star Trek: Infinite is a decent game to play. I'll definitely recommend you to play.", 2, 4.0, "Processed", "Good Game", "4c22c984-e9df-4f81-a46c-11851ac4bf64" },
                    { 3, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 3, 2.0, "Pending", "Bad Game!", "101de009-6ad9-4d24-a495-67bb602d0532" },
                    { 4, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 2, 2.0, "Pending", "Bad Game!", "101de009-6ad9-4d24-a495-67bb602d0532" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0475ff1a-69d1-458a-b0a4-3a0a651ae0a6", "101de009-6ad9-4d24-a495-67bb602d0532" },
                    { "c1a9e393-125c-4548-9489-21b9808a61df", "4c22c984-e9df-4f81-a46c-11851ac4bf64" },
                    { "f80cf2ae-f5b3-422e-8225-6a760b3bd6df", "e03c8494-17d9-413f-b484-36dc8054f0e0" },
                    { "9e7b981b-da47-4597-a17a-ae4df723981d", "e40efa73-04a9-4e42-8f09-ab45b8676397" }
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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GenderId",
                table: "AspNetUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MailingAddressId",
                table: "AspNetUsers",
                column: "MailingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PreferenceId",
                table: "AspNetUsers",
                column: "PreferenceId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_UserId",
                table: "EventUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_GameCategoryId",
                table: "Game",
                column: "GameCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MailingAddress_ProvinceId",
                table: "MailingAddress",
                column: "ProvinceId");

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
                name: "IX_Preference_LanguageId",
                table: "Preference",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferenceFavouritePlatform_FavouritePlatformId",
                table: "PreferenceFavouritePlatform",
                column: "FavouritePlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_PreferenceGameCategory_GameCategoryId",
                table: "PreferenceGameCategory",
                column: "GameCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Province_CountryId",
                table: "Province",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_GameId",
                table: "Review",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_AspNetUsers_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_AspNetUsers_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_AspNetUsers_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_AspNetUsers_UserId",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "EventUser");

            migrationBuilder.DropTable(
                name: "OrderGame");

            migrationBuilder.DropTable(
                name: "PreferenceFavouritePlatform");

            migrationBuilder.DropTable(
                name: "PreferenceGameCategory");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "FavouritePlatform");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ShippingAddress");

            migrationBuilder.DropTable(
                name: "GameCategory");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "MailingAddress");

            migrationBuilder.DropTable(
                name: "Preference");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0475ff1a-69d1-458a-b0a4-3a0a651ae0a6", "101de009-6ad9-4d24-a495-67bb602d0532" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1a9e393-125c-4548-9489-21b9808a61df", "4c22c984-e9df-4f81-a46c-11851ac4bf64" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f80cf2ae-f5b3-422e-8225-6a760b3bd6df", "e03c8494-17d9-413f-b484-36dc8054f0e0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9e7b981b-da47-4597-a17a-ae4df723981d", "e40efa73-04a9-4e42-8f09-ab45b8676397" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0475ff1a-69d1-458a-b0a4-3a0a651ae0a6");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9e7b981b-da47-4597-a17a-ae4df723981d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c1a9e393-125c-4548-9489-21b9808a61df");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f80cf2ae-f5b3-422e-8225-6a760b3bd6df");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_User_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_User_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_User_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_User_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
