﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROG3050.Data;

#nullable disable

namespace PROG3050.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231011163440_CreateLanguageSchema")]
    partial class CreateLanguageSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c0e00191-9b00-499d-a525-1afb8d42f53a",
                            ConcurrencyStamp = "3039a89f-abf8-4c5e-8785-018ffb2aec10",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "a56b54d5-d23c-4d98-9fd5-7a825e7006a5",
                            ConcurrencyStamp = "28795fc3-bb25-41a1-9754-1ce2dbcd0e5c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "06387c15-c763-42d3-96dc-11b7438157ac",
                            ConcurrencyStamp = "36fef08c-fd7e-43e7-b00f-d93f68c415e7",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "e93225a6-2264-4f47-aee1-c2483080f5e4",
                            ConcurrencyStamp = "3efc8e46-50c5-4715-a3c5-559983c0faf4",
                            Name = "Basic",
                            NormalizedName = "BASIC"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "eca07943-dbe8-4c80-80db-56fef2fe1905",
                            RoleId = "c0e00191-9b00-499d-a525-1afb8d42f53a"
                        },
                        new
                        {
                            UserId = "5cd51d58-e7cf-4d45-a466-d35e7cfdd12e",
                            RoleId = "a56b54d5-d23c-4d98-9fd5-7a825e7006a5"
                        },
                        new
                        {
                            UserId = "5e15911b-7ab3-4d61-a5e6-9be6533af0d9",
                            RoleId = "06387c15-c763-42d3-96dc-11b7438157ac"
                        },
                        new
                        {
                            UserId = "4013c02f-da9b-462e-a651-27df8a398432",
                            RoleId = "e93225a6-2264-4f47-aee1-c2483080f5e4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("PROG3050.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Canada"
                        });
                });

            modelBuilder.Entity("PROG3050.Models.FavouritePlatform", b =>
                {
                    b.Property<int>("FavouritePlatformId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavouritePlatformId"), 1L, 1);

                    b.Property<string>("FavouritePlatformName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FavouritePlatformId");

                    b.ToTable("FavouritePlatform");

                    b.HasData(
                        new
                        {
                            FavouritePlatformId = 1,
                            FavouritePlatformName = "PC"
                        },
                        new
                        {
                            FavouritePlatformId = 2,
                            FavouritePlatformName = "Mobile"
                        },
                        new
                        {
                            FavouritePlatformId = 3,
                            FavouritePlatformName = "Console"
                        },
                        new
                        {
                            FavouritePlatformId = 4,
                            FavouritePlatformName = "Others"
                        });
                });

            modelBuilder.Entity("PROG3050.Models.GameCategory", b =>
                {
                    b.Property<int>("GameCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameCategoryId"), 1L, 1);

                    b.Property<string>("GameCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameCategoryId");

                    b.ToTable("GameCategory");

                    b.HasData(
                        new
                        {
                            GameCategoryId = 1,
                            GameCategoryName = "Action"
                        },
                        new
                        {
                            GameCategoryId = 2,
                            GameCategoryName = "Adventure"
                        },
                        new
                        {
                            GameCategoryId = 3,
                            GameCategoryName = "FPS"
                        },
                        new
                        {
                            GameCategoryId = 4,
                            GameCategoryName = "Shooter"
                        },
                        new
                        {
                            GameCategoryId = 5,
                            GameCategoryName = "Others"
                        });
                });

            modelBuilder.Entity("PROG3050.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderId"), 1L, 1);

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderId");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            GenderName = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            GenderName = "Female"
                        },
                        new
                        {
                            GenderId = 3,
                            GenderName = "Others"
                        });
                });

            modelBuilder.Entity("PROG3050.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LanguageId"), 1L, 1);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            LanguageId = 1,
                            LanguageName = "English"
                        });
                });

            modelBuilder.Entity("PROG3050.Models.MailingAddress", b =>
                {
                    b.Property<int>("MailingAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MailingAddressId"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryInstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MailingAddressId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("MailingAddress");

                    b.HasData(
                        new
                        {
                            MailingAddressId = 1,
                            City = "HALIFAX",
                            DeliveryInstruction = "At the door",
                            PostalCode = "B3J 2B3",
                            ProvinceId = 7,
                            Street = "978 ARGYLE ST N"
                        },
                        new
                        {
                            MailingAddressId = 2,
                            City = "TORONTO",
                            DeliveryInstruction = "At the Post Box",
                            PostalCode = "M4K 1M8",
                            ProvinceId = 9,
                            Street = "87 DANFORTH AVE",
                            Unit = "501"
                        },
                        new
                        {
                            MailingAddressId = 3,
                            City = "BIG VALLEY",
                            PostalCode = "T0L 1K0",
                            ProvinceId = 1,
                            Street = "4 FIRST AVE S"
                        },
                        new
                        {
                            MailingAddressId = 4,
                            City = "COURTENAY",
                            DeliveryInstruction = "Ask the security Guard to get in.",
                            PostalCode = "V9N 0A7",
                            ProvinceId = 2,
                            Street = "PO BOX 4600 STN B"
                        });
                });

            modelBuilder.Entity("PROG3050.Models.Preference", b =>
                {
                    b.Property<int>("PreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreferenceId"), 1L, 1);

                    b.Property<int>("FavouritePlatformId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<bool>("PromotionalEmail")
                        .HasColumnType("bit");

                    b.HasKey("PreferenceId");

                    b.HasIndex("FavouritePlatformId");

                    b.HasIndex("LanguageId");

                    b.ToTable("Preference");

                    b.HasData(
                        new
                        {
                            PreferenceId = 1,
                            FavouritePlatformId = 1,
                            LanguageId = 1,
                            PromotionalEmail = false
                        },
                        new
                        {
                            PreferenceId = 2,
                            FavouritePlatformId = 2,
                            LanguageId = 1,
                            PromotionalEmail = true
                        },
                        new
                        {
                            PreferenceId = 3,
                            FavouritePlatformId = 3,
                            LanguageId = 1,
                            PromotionalEmail = false
                        },
                        new
                        {
                            PreferenceId = 4,
                            FavouritePlatformId = 1,
                            LanguageId = 1,
                            PromotionalEmail = false
                        });
                });

            modelBuilder.Entity("PROG3050.Models.PreferenceGameCategory", b =>
                {
                    b.Property<int>("PreferenceId")
                        .HasColumnType("int");

                    b.Property<int>("GameCategoryId")
                        .HasColumnType("int");

                    b.HasKey("PreferenceId", "GameCategoryId");

                    b.HasIndex("GameCategoryId");

                    b.ToTable("PreferenceGameCategory");

                    b.HasData(
                        new
                        {
                            PreferenceId = 1,
                            GameCategoryId = 1
                        },
                        new
                        {
                            PreferenceId = 1,
                            GameCategoryId = 2
                        },
                        new
                        {
                            PreferenceId = 2,
                            GameCategoryId = 2
                        },
                        new
                        {
                            PreferenceId = 2,
                            GameCategoryId = 3
                        },
                        new
                        {
                            PreferenceId = 3,
                            GameCategoryId = 1
                        });
                });

            modelBuilder.Entity("PROG3050.Models.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProvinceId"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.HasIndex("CountryId");

                    b.ToTable("Province");

                    b.HasData(
                        new
                        {
                            ProvinceId = 1,
                            CountryId = 1,
                            ProvinceName = "AB"
                        },
                        new
                        {
                            ProvinceId = 2,
                            CountryId = 1,
                            ProvinceName = "BC"
                        },
                        new
                        {
                            ProvinceId = 3,
                            CountryId = 1,
                            ProvinceName = "MB"
                        },
                        new
                        {
                            ProvinceId = 4,
                            CountryId = 1,
                            ProvinceName = "NB"
                        },
                        new
                        {
                            ProvinceId = 5,
                            CountryId = 1,
                            ProvinceName = "NL"
                        },
                        new
                        {
                            ProvinceId = 6,
                            CountryId = 1,
                            ProvinceName = "NT"
                        },
                        new
                        {
                            ProvinceId = 7,
                            CountryId = 1,
                            ProvinceName = "NS"
                        },
                        new
                        {
                            ProvinceId = 8,
                            CountryId = 1,
                            ProvinceName = "NU"
                        },
                        new
                        {
                            ProvinceId = 9,
                            CountryId = 1,
                            ProvinceName = "ON"
                        },
                        new
                        {
                            ProvinceId = 10,
                            CountryId = 1,
                            ProvinceName = "PE"
                        },
                        new
                        {
                            ProvinceId = 11,
                            CountryId = 1,
                            ProvinceName = "QC"
                        },
                        new
                        {
                            ProvinceId = 12,
                            CountryId = 1,
                            ProvinceName = "SK"
                        },
                        new
                        {
                            ProvinceId = 13,
                            CountryId = 1,
                            ProvinceName = "YT"
                        });
                });

            modelBuilder.Entity("PROG3050.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAddressSame")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("MailingAddressId")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("PreferenceId")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("MailingAddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PreferenceId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "eca07943-dbe8-4c80-80db-56fef2fe1905",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bfdd761a-7b7b-4186-9fc9-8c34bd7fc787",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            GenderId = 3,
                            IsAddressSame = false,
                            LockoutEnabled = false,
                            MailingAddressId = 1,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEAMAZDmxQqaezTGE1dJasA4tiGFKLDeGbncvDnWxH8rHZR8VPTIC4cpaA/O4BKK8Cw==",
                            PhoneNumberConfirmed = true,
                            PreferenceId = 1,
                            SecurityStamp = "ed17700a-5b2c-4274-a34f-21536e9bf3af",
                            TwoFactorEnabled = false,
                            UserName = "SuperAdmin"
                        },
                        new
                        {
                            Id = "5cd51d58-e7cf-4d45-a466-d35e7cfdd12e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "53adeeb3-588f-4963-8098-06a9b5dfd847",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            GenderId = 3,
                            IsAddressSame = false,
                            LockoutEnabled = false,
                            MailingAddressId = 2,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEDsGZzINPuTqw1zO1nY/vJYgUmcbAxwzFTLjIf5PAbr4+8aEOWB0t5esvxCMjz1AqA==",
                            PhoneNumberConfirmed = true,
                            PreferenceId = 2,
                            SecurityStamp = "6771752b-c6ec-44a7-8866-d0b39cee514f",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "5e15911b-7ab3-4d61-a5e6-9be6533af0d9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e1977eb2-c3a7-4732-808a-946d0d82f7e9",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "moderator@gmail.com",
                            EmailConfirmed = true,
                            GenderId = 3,
                            IsAddressSame = false,
                            LockoutEnabled = false,
                            MailingAddressId = 3,
                            NormalizedEmail = "MODERATOR",
                            NormalizedUserName = "MODERATOR@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAeJ79laqdRv/+jrgEBeNSnrbtcsGVUkEcM+5fJjqfCyE1AWzoxNZFtrsrDVOr7wLg==",
                            PhoneNumberConfirmed = true,
                            PreferenceId = 3,
                            SecurityStamp = "ef267705-3e6e-474c-a022-969827876abc",
                            TwoFactorEnabled = false,
                            UserName = "Moderator"
                        },
                        new
                        {
                            Id = "4013c02f-da9b-462e-a651-27df8a398432",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d50fc429-1daf-4ff1-8baa-e4f542d7ef1c",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "basic@gmail.com",
                            EmailConfirmed = true,
                            GenderId = 3,
                            IsAddressSame = false,
                            LockoutEnabled = false,
                            MailingAddressId = 4,
                            NormalizedEmail = "BASIC@GMAIL.COM",
                            NormalizedUserName = "BASIC",
                            PasswordHash = "AQAAAAEAACcQAAAAEPKjinScM8l2wJrYcLUHFsqEqc+sJfCbLRkjVKup2njA2jp3VEGUvz6uzDq2uat7Kg==",
                            PhoneNumberConfirmed = true,
                            PreferenceId = 4,
                            SecurityStamp = "3c8e2702-327c-4a6c-b1ac-8f7bb022b670",
                            TwoFactorEnabled = false,
                            UserName = "Basic"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PROG3050.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PROG3050.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROG3050.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PROG3050.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PROG3050.Models.MailingAddress", b =>
                {
                    b.HasOne("PROG3050.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("PROG3050.Models.Preference", b =>
                {
                    b.HasOne("PROG3050.Models.FavouritePlatform", "FavouritePlatform")
                        .WithMany()
                        .HasForeignKey("FavouritePlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROG3050.Models.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FavouritePlatform");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("PROG3050.Models.PreferenceGameCategory", b =>
                {
                    b.HasOne("PROG3050.Models.GameCategory", "GameCategory")
                        .WithMany("PreferenceGameCategories")
                        .HasForeignKey("GameCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROG3050.Models.Preference", "Preference")
                        .WithMany("PreferenceGameCategories")
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameCategory");

                    b.Navigation("Preference");
                });

            modelBuilder.Entity("PROG3050.Models.Province", b =>
                {
                    b.HasOne("PROG3050.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("PROG3050.Models.User", b =>
                {
                    b.HasOne("PROG3050.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROG3050.Models.MailingAddress", "MailingAddress")
                        .WithMany()
                        .HasForeignKey("MailingAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PROG3050.Models.Preference", "Preference")
                        .WithMany()
                        .HasForeignKey("PreferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("MailingAddress");

                    b.Navigation("Preference");
                });

            modelBuilder.Entity("PROG3050.Models.GameCategory", b =>
                {
                    b.Navigation("PreferenceGameCategories");
                });

            modelBuilder.Entity("PROG3050.Models.Preference", b =>
                {
                    b.Navigation("PreferenceGameCategories");
                });
#pragma warning restore 612, 618
        }
    }
}