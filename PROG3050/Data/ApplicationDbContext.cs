﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROG3050.Models;

namespace PROG3050.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable("User");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Role");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            builder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "Canada"
                }
            );


            builder.Entity<Province>().HasData(
                new Province
                {
                    ProvinceId = 1,
                    ProvinceName = "AB",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 2,
                    ProvinceName = "BC",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 3,
                    ProvinceName = "MB",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 4,
                    ProvinceName = "NB",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 5,
                    ProvinceName = "NL",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 6,
                    ProvinceName = "NT",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 7,
                    ProvinceName = "NS",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 8,
                    ProvinceName = "NU",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 9,
                    ProvinceName = "ON",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 10,
                    ProvinceName = "PE",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 11,
                    ProvinceName = "QC",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 12,
                    ProvinceName = "SK",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 13,
                    ProvinceName = "YT",
                    CountryId = 1
                }
            );

            builder.Entity<Gender>().HasData(
                new Gender
                {
                    GenderId = 1,
                    GenderName = "Male"
                },
                new Gender
                {
                    GenderId = 2,
                    GenderName = "Female"
                },
                new Gender
                {
                    GenderId = 3,
                    GenderName = "Others"
                }
            );

            builder.Entity<FavouritePlatform>().HasData(
                new FavouritePlatform
                {
                    FavouritePlatformId = 1,
                    FavouritePlatformName = "PC"
                },
                new FavouritePlatform
                {
                    FavouritePlatformId = 2,
                    FavouritePlatformName = "Mobile"
                },
                new FavouritePlatform
                {
                    FavouritePlatformId = 3,
                    FavouritePlatformName = "Console"
                },
                new FavouritePlatform
                {
                    FavouritePlatformId = 4,
                    FavouritePlatformName = "Others"
                }
            );

            builder.Entity<GameCategory>().HasData(
                new GameCategory
                {
                    GameCategoryId = 1,
                    GameCategoryName = "Action"
                },
                new GameCategory
                {
                    GameCategoryId = 2,
                    GameCategoryName = "Adventure"
                },
                new GameCategory
                {
                    GameCategoryId = 3,
                    GameCategoryName = "FPS"
                },
                new GameCategory
                {
                    GameCategoryId = 4,
                    GameCategoryName = "Shooter"
                },
                new GameCategory
                {
                    GameCategoryId = 5,
                    GameCategoryName = "Others"
                }
            );

            builder.Entity<Preference>().HasData(
                new Preference
                {
                    PreferenceId = 1,
                    PromotionalEmail = false,
                    FavouritePlatformId = 1
                },
                new Preference
                {
                    PreferenceId = 2,
                    PromotionalEmail = true,
                    FavouritePlatformId = 2
                },
                new Preference
                {
                    PreferenceId = 3,
                    PromotionalEmail = false,
                    FavouritePlatformId = 3
                }
            );
        }
    }
}