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
    [Migration("20231005152420_CreatePreferenceGameCategorySchema")]
    partial class CreatePreferenceGameCategorySchema
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
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.ToTable("Gender");

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

            modelBuilder.Entity("PROG3050.Models.Preference", b =>
                {
                    b.Property<int>("PreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PreferenceId"), 1L, 1);

                    b.Property<int>("FavouritePlatformId")
                        .HasColumnType("int");

                    b.Property<bool>("PromotionalEmail")
                        .HasColumnType("bit");

                    b.HasKey("PreferenceId");

                    b.HasIndex("FavouritePlatformId");

                    b.ToTable("Preference");

                    b.HasData(
                        new
                        {
                            PreferenceId = 1,
                            FavouritePlatformId = 1,
                            PromotionalEmail = false
                        },
                        new
                        {
                            PreferenceId = 2,
                            FavouritePlatformId = 2,
                            PromotionalEmail = true
                        },
                        new
                        {
                            PreferenceId = 3,
                            FavouritePlatformId = 3,
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PROG3050.Models.Preference", b =>
                {
                    b.HasOne("PROG3050.Models.FavouritePlatform", "FavouritePlatform")
                        .WithMany()
                        .HasForeignKey("FavouritePlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FavouritePlatform");
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
