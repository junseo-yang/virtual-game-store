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
                name: "Wishlist",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => new { x.UserId, x.GameId });
                    table.ForeignKey(
                        name: "FK_Wishlist_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wishlist_Game_GameId",
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
                    { "34aef061-9798-4cad-89f2-6c73d4dc1bc4", "3a7c43b8-f8fe-438f-a858-0dd96d5d41a1", "Member", "MEMBER" },
                    { "4981dca7-2f95-4ca1-b721-e86fa8fac565", "51096ecc-3730-42d8-8c74-b016fd584ac1", "Admin", "ADMIN" },
                    { "55b9352e-5f3c-46cb-ab1f-3e46e2b87f0e", "e10e26bc-f4e8-477a-9012-9e22ba004de4", "Moderator", "MODERATOR" },
                    { "79c414a8-c7e1-4ea1-9c57-414efc3763c0", "0666bcef-0ee4-4451-bb93-ba780c6dd731", "SuperAdmin", "SUPERADMIN" }
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
                    { 13, 1, "YT" },
                    { 14, 2, "AL" },
                    { 15, 2, "AK" },
                    { 16, 2, "AZ" },
                    { 17, 2, "AR" },
                    { 18, 2, "CA" },
                    { 19, 2, "CO" },
                    { 20, 2, "CT" },
                    { 21, 2, "DE" },
                    { 22, 2, "DC" },
                    { 23, 2, "FL" },
                    { 24, 2, "GA" },
                    { 25, 2, "HI" },
                    { 26, 2, "ID" },
                    { 27, 2, "IL" },
                    { 28, 2, "IN" },
                    { 29, 2, "IA" },
                    { 30, 2, "KS" },
                    { 31, 2, "KY" },
                    { 32, 2, "LA" },
                    { 33, 2, "ME" }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceId", "CountryId", "ProvinceName" },
                values: new object[,]
                {
                    { 34, 2, "MD" },
                    { 35, 2, "MA" },
                    { 37, 2, "MI" },
                    { 38, 2, "MN" },
                    { 39, 2, "MS" },
                    { 40, 2, "MO" },
                    { 41, 2, "MT" },
                    { 42, 2, "NE" },
                    { 43, 2, "NV" },
                    { 44, 2, "NH" },
                    { 45, 2, "NJ" },
                    { 46, 2, "NM" },
                    { 47, 2, "NY" },
                    { 48, 2, "NC" },
                    { 49, 2, "NY" },
                    { 50, 2, "NC" },
                    { 51, 2, "ND" },
                    { 52, 2, "OH" },
                    { 53, 2, "OK" },
                    { 54, 2, "OR" },
                    { 55, 2, "PA" },
                    { 56, 2, "RI" },
                    { 57, 2, "SC" },
                    { 58, 2, "SD" },
                    { 59, 2, "TN" },
                    { 60, 2, "TX" },
                    { 61, 2, "UT" },
                    { 62, 2, "VT" },
                    { 63, 2, "VA" },
                    { 64, 2, "WA" },
                    { 65, 2, "WV" },
                    { 66, 2, "WI" },
                    { 67, 2, "WY" }
                });

            migrationBuilder.InsertData(
                table: "MailingAddress",
                columns: new[] { "MailingAddressId", "City", "DeliveryInstruction", "FirstName", "LastName", "PhoneNumber", "PostalCode", "ProvinceId", "Street", "Unit" },
                values: new object[,]
                {
                    { 1, "HALIFAX", "At the door", "Tyrone", "Mcgee", null, "B3J 2B3", 7, "978 ARGYLE ST N", null },
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
                    { "50ad2366-4a1d-4795-9d2e-809ed2048778", 0, "95babff4-f519-460d-9b25-4985daa2a7a1", null, null, "member@gmail.com", true, "Ernest", 3, false, false, "Mcknight", false, null, 4, "MEMBER@GMAIL.COM", "MEMBER", "AQAAAAEAACcQAAAAED3Al+gEpCQuDjeiSx+FUlBTxDT9Sm8GgJslWIyg+u/p1NOaWDk8DFtD9MNie72W6A==", null, true, 4, "90fd6702-871b-4e13-ad61-b7bd8eb0137f", false, "Member" },
                    { "971466af-19bf-4d82-b52d-82793a5367d8", 0, "f30bce2d-e3c6-433b-922f-df40bfb26fc5", null, null, "admin@gmail.com", true, "William", 3, false, false, "Potter", false, null, 2, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEBbJHnZ37rBSSF8VZFLIP1dP4nHXqg6kjODYA/B4Ho5Z7iY5vB7z0pBhpafN7OgKCA==", null, true, 2, "177fe476-372b-4d37-a67b-b360977581cd", false, "Admin" },
                    { "d75cb3e8-41ae-4a55-91f0-5e3cbd620114", 0, "c30f2c67-971a-492b-aea2-8ab421a65c34", null, null, "moderator@gmail.com", true, "Francis", 3, false, false, "Ramos", false, null, 3, "MODERATOR@GMAIL.COM", "MODERATOR", "AQAAAAEAACcQAAAAENByrkcSANgLXkB49iAddDCDiEZA1GsF2lbnBFY/C11f+4HgU9dI18gDqIHzEpb70A==", null, true, 3, "cba13dac-3f6c-4d40-a098-1c933ee5831c", false, "Moderator" },
                    { "de17c4b9-7dcb-4958-8cd8-6ccbe39adc67", 0, "bbee3e2e-c003-4125-9b13-bf15f964c7d8", null, null, "superadmin@gmail.com", true, "Tyrone", 3, false, false, "Mcgee", false, null, 1, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEAsqrZpAWHbfJVYQfAta87BNo7py11n8FCUrNka8ojfOQH/nCNhhWhaT4f6k9Sz1ag==", null, true, 1, "804d4e42-7cf0-457a-92d7-0a9ddfb168ab", false, "SuperAdmin" },
                    { "e66ed2d8-ee6d-4c78-92f3-25c0b2ce81f2", 0, "8cc5e3fb-0b53-42cf-b752-042229fac080", null, null, "tester2@gmail.com", true, "Test2FirstName", 3, false, false, "Test2LastName", false, null, 6, "TESTER2@GMAIL.COM", "TESTER2", "AQAAAAEAACcQAAAAEAMO1Pi4C0nDDqfuQ1iFTQzoee5nLpqpbLi1HEsU7xx+nIo2eIVm+4ONerj3vl0TYQ==", null, true, 6, "58e8fb1c-3851-4f0b-a044-c996f4be3399", false, "Tester2" },
                    { "f2f8e54f-8ee7-472a-bd94-0a3d528f9f4a", 0, "010eb7dc-0783-45bf-88ae-2fe298c78288", null, null, "tester1@gmail.com", true, "Test1FirstName", 3, false, false, "Test1LastName", false, null, 5, "TESTER1@GMAIL.COM", "TESTER1", "AQAAAAEAACcQAAAAELy25yh5IP18gX8P/6i3+8fPB19SuSnF4tGyUT2li16td0G8kP3uKraTf/CvkWxSHA==", null, true, 5, "c75c95db-6f42-4140-8f27-3aeedf4e7456", false, "Tester1" }
                });

            migrationBuilder.InsertData(
                table: "EventUser",
                columns: new[] { "EventId", "UserId" },
                values: new object[,]
                {
                    { 1, "50ad2366-4a1d-4795-9d2e-809ed2048778" },
                    { 1, "971466af-19bf-4d82-b52d-82793a5367d8" },
                    { 1, "d75cb3e8-41ae-4a55-91f0-5e3cbd620114" },
                    { 2, "50ad2366-4a1d-4795-9d2e-809ed2048778" },
                    { 2, "971466af-19bf-4d82-b52d-82793a5367d8" }
                });

            migrationBuilder.InsertData(
                table: "FriendFamily",
                columns: new[] { "ReceiverUserId", "RequesterUserId", "Description", "Status" },
                values: new object[,]
                {
                    { "de17c4b9-7dcb-4958-8cd8-6ccbe39adc67", "50ad2366-4a1d-4795-9d2e-809ed2048778", "Friend", "Pending" },
                    { "50ad2366-4a1d-4795-9d2e-809ed2048778", "971466af-19bf-4d82-b52d-82793a5367d8", "Friend", "Processed" },
                    { "50ad2366-4a1d-4795-9d2e-809ed2048778", "d75cb3e8-41ae-4a55-91f0-5e3cbd620114", "Family", "Processed" },
                    { "de17c4b9-7dcb-4958-8cd8-6ccbe39adc67", "d75cb3e8-41ae-4a55-91f0-5e3cbd620114", "Family", "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDate", "ShippingAddressId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Processed", "50ad2366-4a1d-4795-9d2e-809ed2048778" },
                    { 2, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Processed", "971466af-19bf-4d82-b52d-82793a5367d8" },
                    { 3, new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Pending", "d75cb3e8-41ae-4a55-91f0-5e3cbd620114" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "Description", "GameId", "Rating", "Status", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 1, 5.0, "Pending", "The Best Game!", "50ad2366-4a1d-4795-9d2e-809ed2048778" },
                    { 2, "Star Trek: Infinite is a decent game to play. I'll definitely recommend you to play.", 2, 4.0, "Processed", "Good Game", "971466af-19bf-4d82-b52d-82793a5367d8" },
                    { 3, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 3, 2.0, "Pending", "Bad Game!", "d75cb3e8-41ae-4a55-91f0-5e3cbd620114" },
                    { 4, "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.", 2, 2.0, "Pending", "Bad Game!", "d75cb3e8-41ae-4a55-91f0-5e3cbd620114" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "34aef061-9798-4cad-89f2-6c73d4dc1bc4", "50ad2366-4a1d-4795-9d2e-809ed2048778" },
                    { "4981dca7-2f95-4ca1-b721-e86fa8fac565", "971466af-19bf-4d82-b52d-82793a5367d8" },
                    { "55b9352e-5f3c-46cb-ab1f-3e46e2b87f0e", "d75cb3e8-41ae-4a55-91f0-5e3cbd620114" },
                    { "79c414a8-c7e1-4ea1-9c57-414efc3763c0", "de17c4b9-7dcb-4958-8cd8-6ccbe39adc67" },
                    { "34aef061-9798-4cad-89f2-6c73d4dc1bc4", "e66ed2d8-ee6d-4c78-92f3-25c0b2ce81f2" },
                    { "34aef061-9798-4cad-89f2-6c73d4dc1bc4", "f2f8e54f-8ee7-472a-bd94-0a3d528f9f4a" }
                });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "GameId", "UserId", "Price", "Title" },
                values: new object[] { 1, "f2f8e54f-8ee7-472a-bd94-0a3d528f9f4a", 19.989999999999998, "Dummy Game" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_GameId",
                table: "Wishlist",
                column: "GameId");

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
                name: "Wishlist");

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
                keyValues: new object[] { "34aef061-9798-4cad-89f2-6c73d4dc1bc4", "50ad2366-4a1d-4795-9d2e-809ed2048778" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4981dca7-2f95-4ca1-b721-e86fa8fac565", "971466af-19bf-4d82-b52d-82793a5367d8" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55b9352e-5f3c-46cb-ab1f-3e46e2b87f0e", "d75cb3e8-41ae-4a55-91f0-5e3cbd620114" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79c414a8-c7e1-4ea1-9c57-414efc3763c0", "de17c4b9-7dcb-4958-8cd8-6ccbe39adc67" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34aef061-9798-4cad-89f2-6c73d4dc1bc4", "e66ed2d8-ee6d-4c78-92f3-25c0b2ce81f2" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34aef061-9798-4cad-89f2-6c73d4dc1bc4", "f2f8e54f-8ee7-472a-bd94-0a3d528f9f4a" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "34aef061-9798-4cad-89f2-6c73d4dc1bc4");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4981dca7-2f95-4ca1-b721-e86fa8fac565");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "55b9352e-5f3c-46cb-ab1f-3e46e2b87f0e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "79c414a8-c7e1-4ea1-9c57-414efc3763c0");

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
