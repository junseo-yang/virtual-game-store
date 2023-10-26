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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "FriendFamily",
                columns: table => new
                {
                    RequesterUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendFamily", x => new { x.RequesterUserId, x.ReceiverUserId });
                    table.ForeignKey(
                        name: "FK_FriendFamily_AspNetUsers_ReceiverUserId",
                        column: x => x.ReceiverUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FriendFamily_AspNetUsers_RequesterUserId",
                        column: x => x.RequesterUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                values: new object[,]
                {
                    { 1, "English" },
                    { 2, "French" },
                    { 3, "Spanish" },
                    { 4, "Korean" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0615df17-79fb-4054-9f7e-77ee21b16b09", "6c073ee2-c357-40ad-bc0f-4712c9a2c399", "Moderator", "MODERATOR" },
                    { "0e814cc3-b703-49c7-a366-94296560a108", "ce35693a-68b1-4399-96bf-21c27caaf274", "Member", "MEMBER" },
                    { "2a39f081-8f7b-488d-b3e6-a56970f2d44a", "7f521345-59f2-4213-abd1-2313f35020f0", "SuperAdmin", "SUPERADMIN" },
                    { "c1a97a43-5a5c-4f9a-9d2d-95eca89ed47f", "c21574b3-c1ad-428b-8499-b950b3f6a5ce", "Admin", "ADMIN" }
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
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 1 },
                    { 6, 1 }
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
                columns: new[] { "MailingAddressId", "City", "DeliveryInstruction", "FirstName", "LastName", "PhoneNumber", "PostalCode", "ProvinceId", "Street", "Unit" },
                values: new object[,]
                {
                    { 1, "HALIFAX", "At the door", "Tyrone", "Mcgee", "+15008040911", "B3J 2B3", 7, "978 ARGYLE ST N", null },
                    { 2, "TORONTO", "At the Post Box", null, null, null, "M4K 1M8", 9, "87 DANFORTH AVE", "501" },
                    { 3, "BIG VALLEY", null, null, null, null, "T0L 1K0", 1, "4 FIRST AVE S", null },
                    { 4, "COURTENAY", "Ask the security Guard to get in.", null, null, null, "V9N 0A7", 2, "PO BOX 4600 STN B", null },
                    { 5, null, null, null, null, null, null, 1, null, null },
                    { 6, null, null, null, null, null, null, 2, null, null }
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
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 }
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
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreditCard", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "GenderId", "IsAddressSame", "IsPromotionalEmail", "LastName", "LockoutEnabled", "LockoutEnd", "MailingAddressId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferenceId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "353308f7-af90-4aa4-ba55-337f949e4e89", 0, "2e2769ff-29cf-42ad-a2c7-1ca1a4c4710d", null, null, "member@gmail.com", true, "Ernest", 3, false, false, "Mcknight", false, null, 4, "MEMBER@GMAIL.COM", "MEMBER", "AQAAAAEAACcQAAAAECKaSNUjH4TfvopjSJP2HB1XSb0n3EzXL808im92sfs5ukR1qbvvlgGsvh+fXP5zEg==", null, true, 4, "f86c0e79-6b19-41e4-b236-6c9f263b26aa", false, "Member" },
                    { "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0", 0, "43f3f6bc-d358-4e90-8d49-c3f13c95ac00", null, null, "admin@gmail.com", true, "William", 3, false, false, "Potter", false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEAnM+hobQgEGQpfsLUn13v7a2fLwsxXbSa5SZJNBIivjTF8K1pIjbvd2/66FjfvcSg==", null, true, 2, "5b344b2b-6b20-4acd-a8f3-b61b3dee1b92", false, "Admin" },
                    { "3e1729d0-6ab3-4d24-adff-d61f1098003d", 0, "45ce0664-64a0-48df-af1b-aef9bbff0fe1", null, null, "tester1@gmail.com", true, "Test1FirstName", 3, false, false, "Test1LastName", false, null, 5, "TESTER1@GMAIL.COM", "TESTER1", "AQAAAAEAACcQAAAAEECcHG5nm0Ia/w83pISfMP0l5SR6jDDd+6xFBA4+ufTRra4Ui4S6A9R5t+JynAfq1w==", null, true, 5, "07e1e3a8-0e1e-4208-beea-0041a4750207", false, "Tester1" },
                    { "6ad978d1-80a9-4f9f-9921-599162449a12", 0, "56a1cdc0-48e7-4ff2-8198-a6f25fbfab6b", null, null, "tester2@gmail.com", true, "Test2FirstName", 3, false, false, "Test2LastName", false, null, 6, "TESTER2@GMAIL.COM", "TESTER2", "AQAAAAEAACcQAAAAEItcSuApYzzZLi8G1RW1jRAkqM6Z5yW/j1i+pK2bqFx6Fnq9i72jVdeVKkpMDaBjHQ==", null, true, 6, "59f4e88e-c4e0-4bd8-a248-717cebe3d2d2", false, "Tester2" },
                    { "a047c066-0a44-441a-b77b-fe0b2a681ada", 0, "a3cf87c8-f695-4dad-91b7-198b6d48dbd9", null, null, "superadmin@gmail.com", true, "Tyrone", 3, false, false, "Mcgee", false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEJRlUfeACAQhWYdVs01yNM6sWWcuZ3lBHMpAHRAJdbPQ34EqWQl/MeX5DEOBiE3GMQ==", null, true, 1, "ba5090c2-991f-49dc-bc89-09512a438cb6", false, "SuperAdmin" },
                    { "cd782a07-c5c9-4183-b085-bf956eb2eca0", 0, "7f7977ad-e525-4eb8-8b12-1ce63bbfb265", null, null, "moderator@gmail.com", true, "Francis", 3, false, false, "Ramos", false, null, 3, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAEAACcQAAAAEPLuuVclzgnMssaNuOxMorCW2hTRzzXQrperJE767Zak01ifjDszZg/gmTC0k6W8Ew==", null, true, 3, "762697e2-e0f3-4f81-8e6b-5c76d2cd8f73", false, "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "353308f7-af90-4aa4-ba55-337f949e4e89" },
                    { 1, "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0" },
                    { 1, "cd782a07-c5c9-4183-b085-bf956eb2eca0" },
                    { 2, "353308f7-af90-4aa4-ba55-337f949e4e89" },
                    { 2, "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0" }
                });

            migrationBuilder.InsertData(
                table: "FriendFamily",
                columns: new[] { "ReceiverUserId", "RequesterUserId", "Description", "Status" },
                values: new object[,]
                {
                    { "a047c066-0a44-441a-b77b-fe0b2a681ada", "353308f7-af90-4aa4-ba55-337f949e4e89", "Friend", "Pending" },
                    { "353308f7-af90-4aa4-ba55-337f949e4e89", "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0", "Friend", "Processed" },
                    { "353308f7-af90-4aa4-ba55-337f949e4e89", "cd782a07-c5c9-4183-b085-bf956eb2eca0", "Family", "Processed" },
                    { "a047c066-0a44-441a-b77b-fe0b2a681ada", "cd782a07-c5c9-4183-b085-bf956eb2eca0", "Family", "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "ShippingAddressId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Processed", "353308f7-af90-4aa4-ba55-337f949e4e89" },
                    { 2, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Processed", "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0" },
                    { 3, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Pending", "cd782a07-c5c9-4183-b085-bf956eb2eca0" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "Description", "GameId", "Rating", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 1, 5.0, "Pending", "The Best Game!", "353308f7-af90-4aa4-ba55-337f949e4e89" },
                    { 2, "Star Trek: Infinite is a decent game to play. I'll definitely recommend you to play.", 2, 4.0, "Processed", "Good Game", "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0" },
                    { 3, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 3, 2.0, "Pending", "Bad Game!", "cd782a07-c5c9-4183-b085-bf956eb2eca0" },
                    { 4, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 2, 2.0, "Pending", "Bad Game!", "cd782a07-c5c9-4183-b085-bf956eb2eca0" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0e814cc3-b703-49c7-a366-94296560a108", "353308f7-af90-4aa4-ba55-337f949e4e89" },
                    { "c1a97a43-5a5c-4f9a-9d2d-95eca89ed47f", "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0" },
                    { "0e814cc3-b703-49c7-a366-94296560a108", "3e1729d0-6ab3-4d24-adff-d61f1098003d" },
                    { "0e814cc3-b703-49c7-a366-94296560a108", "6ad978d1-80a9-4f9f-9921-599162449a12" },
                    { "2a39f081-8f7b-488d-b3e6-a56970f2d44a", "a047c066-0a44-441a-b77b-fe0b2a681ada" },
                    { "0615df17-79fb-4054-9f7e-77ee21b16b09", "cd782a07-c5c9-4183-b085-bf956eb2eca0" }
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
                name: "IX_FriendFamily_ReceiverUserId",
                table: "FriendFamily",
                column: "ReceiverUserId");

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
                name: "FriendFamily");

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
                keyValues: new object[] { "0e814cc3-b703-49c7-a366-94296560a108", "353308f7-af90-4aa4-ba55-337f949e4e89" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1a97a43-5a5c-4f9a-9d2d-95eca89ed47f", "3d5a4bf4-e5a7-4acb-8da5-277e4f4a61d0" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e814cc3-b703-49c7-a366-94296560a108", "3e1729d0-6ab3-4d24-adff-d61f1098003d" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0e814cc3-b703-49c7-a366-94296560a108", "6ad978d1-80a9-4f9f-9921-599162449a12" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a39f081-8f7b-488d-b3e6-a56970f2d44a", "a047c066-0a44-441a-b77b-fe0b2a681ada" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0615df17-79fb-4054-9f7e-77ee21b16b09", "cd782a07-c5c9-4183-b085-bf956eb2eca0" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0615df17-79fb-4054-9f7e-77ee21b16b09");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0e814cc3-b703-49c7-a366-94296560a108");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "2a39f081-8f7b-488d-b3e6-a56970f2d44a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c1a97a43-5a5c-4f9a-9d2d-95eca89ed47f");

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
