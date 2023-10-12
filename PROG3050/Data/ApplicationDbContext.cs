using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROG3050.Models;

namespace PROG3050.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
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

            builder.Entity<Language>().HasData(
                new Language
                {
                    LanguageId = 1,
                    LanguageName = "English"
                }
            );

            builder.Entity<Preference>().HasData(
                new Preference
                {
                    PreferenceId = 1,
                    FavouritePlatformId = 1,
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 2,
                    FavouritePlatformId = 2,
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 3,
                    FavouritePlatformId = 3,
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 4,
                    FavouritePlatformId = 1,
                    LanguageId = 1
                }
            );

            // Configure Many-to-Many relationship between Preference-PreferenceGameCategory-GameCategory
            builder.Entity<PreferenceGameCategory>()
                .HasKey(pgc => new { pgc.PreferenceId, pgc.GameCategoryId });
            builder.Entity<PreferenceGameCategory>()
                .HasOne(pgc => pgc.Preference)
                .WithMany(p => p.PreferenceGameCategories)
                .HasForeignKey(pgc => pgc.PreferenceId);
            builder.Entity<PreferenceGameCategory>()
                .HasOne(pgc => pgc.GameCategory)
                .WithMany(g => g.PreferenceGameCategories)
                .HasForeignKey(pgc => pgc.GameCategoryId);


            builder.Entity<PreferenceGameCategory>().HasData(
                new PreferenceGameCategory
                {
                    PreferenceId = 1,
                    GameCategoryId = 1
                },
                new PreferenceGameCategory
                {
                    PreferenceId = 1,
                    GameCategoryId = 2
                },
                new PreferenceGameCategory
                {
                    PreferenceId = 2,
                    GameCategoryId = 2
                },
                new PreferenceGameCategory
                {
                    PreferenceId = 2,
                    GameCategoryId = 3
                },
                new PreferenceGameCategory
                {
                    PreferenceId = 3,
                    GameCategoryId = 1
                }
            );

            builder.Entity<MailingAddress>().HasData(
                new MailingAddress
                {
                    MailingAddressId = 1,
                    Street = "978 ARGYLE ST N",
                    City = "HALIFAX",
                    ProvinceId = 7,
                    PostalCode = "B3J 2B3",
                    DeliveryInstruction = "At the door"
                },
                new MailingAddress
                {
                    MailingAddressId = 2,
                    Unit = "501",
                    Street = "87 DANFORTH AVE",
                    City = "TORONTO",
                    ProvinceId = 9,
                    PostalCode = "M4K 1M8",
                    DeliveryInstruction = "At the Post Box"
                },
                new MailingAddress
                {
                    MailingAddressId = 3,
                    Street = "4 FIRST AVE S",
                    City = "BIG VALLEY",
                    ProvinceId = 1,
                    PostalCode = "T0L 1K0"
                },
                new MailingAddress
                {
                    MailingAddressId = 4,
                    Street = "PO BOX 4600 STN B",
                    City = "COURTENAY",
                    ProvinceId = 2,
                    PostalCode = "V9N 0A7",
                    DeliveryInstruction = "Ask the security Guard to get in."
                }
            );

            var superadminRole = new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN"
            };

            var adminRole = new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            var moderatorRole = new IdentityRole
            {
                Name = "Moderator",
                NormalizedName = "MODERATOR"
            };
            var basicRole = new IdentityRole
            {
                Name = "Basic",
                NormalizedName = "BASIC"
            };

            builder.Entity<IdentityRole>().HasData(
                superadminRole,
                adminRole,
                moderatorRole,
                basicRole
            );

            // Seed Default Users
            PasswordHasher<User> ph = new PasswordHasher<User>();

            var superadmin = new User
            {
                UserName = "SuperAdmin",
                NormalizedUserName = "SUPERADMIN",
                Email = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 1,
                GenderId = 3,
                PreferenceId = 1
            };
            
            superadmin.PasswordHash = ph.HashPassword(superadmin, "Superadmin123!@");

            var admin = new User
            {
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 2,
                GenderId = 3,
                PreferenceId = 2
            };

            admin.PasswordHash = ph.HashPassword(admin, "Admin123!@");

            var moderator = new User
            {
                UserName = "Moderator",
                NormalizedEmail = "MODERATOR",
                Email = "moderator@gmail.com",
                NormalizedUserName = "MODERATOR@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 3,
                GenderId = 3,
                PreferenceId = 3
            };

            moderator.PasswordHash = ph.HashPassword(moderator, "Moderator123!@");

            var basic = new User
            {
                UserName = "Basic",
                NormalizedUserName = "BASIC",
                Email = "basic@gmail.com",
                NormalizedEmail = "BASIC@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 4,
                GenderId = 3,
                PreferenceId = 4
            };

            basic.PasswordHash = ph.HashPassword(basic, "Basic123!@");

            builder.Entity<User>().HasData(superadmin);
            builder.Entity<User>().HasData(admin);
            builder.Entity<User>().HasData(moderator);
            builder.Entity<User>().HasData(basic);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = superadmin.Id,
                    RoleId = superadminRole.Id
                },
                new IdentityUserRole<string>
                {
                    UserId = admin.Id,
                    RoleId = adminRole.Id
                },
                new IdentityUserRole<string>
                {
                    UserId = moderator.Id,
                    RoleId = moderatorRole.Id
                },
                new IdentityUserRole<string>
                {
                    UserId = basic.Id,
                    RoleId = basicRole.Id
                }
            );
        }

        public DbSet<Gender>? Genders { get; set; }

        public DbSet<Country>? Country { get; set; }

        public DbSet<Province>? Province { get; set; }

        public DbSet<Language>? Language { get; set; }

        public DbSet<Preference>? Preference { get; set; }

        public DbSet<FavouritePlatform>? FavouritePlatform { get; set; }
    }
}