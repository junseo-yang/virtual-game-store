using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROG3050.Models;
using System.Diagnostics.Metrics;

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

            builder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "Canada"
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "US"
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
                },
                new Province
                {
                    ProvinceId = 14,
                    ProvinceName = "AL",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 15,
                    ProvinceName = "AK",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 16,
                    ProvinceName = "AZ",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 17,
                    ProvinceName = "AR",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 18,
                    ProvinceName = "CA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 19,
                    ProvinceName = "CO",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 20,
                    ProvinceName = "CT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 21,
                    ProvinceName = "DE",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 22,
                    ProvinceName = "DC",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 23,
                    ProvinceName = "FL",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 24,
                    ProvinceName = "GA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 25,
                    ProvinceName = "HI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 26,
                    ProvinceName = "ID",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 27,
                    ProvinceName = "IL",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 28,
                    ProvinceName = "IN",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 29,
                    ProvinceName = "IA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 30,
                    ProvinceName = "KS",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 31,
                    ProvinceName = "KY",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 32,
                    ProvinceName = "LA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 33,
                    ProvinceName = "ME",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 34,
                    ProvinceName = "MD",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 35,
                    ProvinceName = "MA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 37,
                    ProvinceName = "MI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 38,
                    ProvinceName = "MN",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 39,
                    ProvinceName = "MS",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 40,
                    ProvinceName = "MO",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 41,
                    ProvinceName = "MT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 42,
                    ProvinceName = "NE",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 43,
                    ProvinceName = "NV",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 44,
                    ProvinceName = "NH",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 45,
                    ProvinceName = "NJ",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 46,
                    ProvinceName = "NM",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 47,
                    ProvinceName = "NY",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 48,
                    ProvinceName = "NC",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 49,
                    ProvinceName = "NY",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 50,
                    ProvinceName = "NC",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 51,
                    ProvinceName = "ND",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 52,
                    ProvinceName = "OH",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 53,
                    ProvinceName = "OK",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 54,
                    ProvinceName = "OR",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 55,
                    ProvinceName = "PA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 56,
                    ProvinceName = "RI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 57,
                    ProvinceName = "SC",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 58,
                    ProvinceName = "SD",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 59,
                    ProvinceName = "TN",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 60,
                    ProvinceName = "TX",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 61,
                    ProvinceName = "UT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 62,
                    ProvinceName = "VT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 63,
                    ProvinceName = "VA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 64,
                    ProvinceName = "WA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 65,
                    ProvinceName = "WV",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 66,
                    ProvinceName = "WI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 67,
                    ProvinceName = "WY",
                    CountryId = 2
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
                },
                new Language
                {
                    LanguageId = 2,
                    LanguageName = "French"
                },
                new Language
                {
                    LanguageId = 3,
                    LanguageName = "Spanish"
                },
                new Language
                {
                    LanguageId = 4,
                    LanguageName = "Korean"
                }
            );

            builder.Entity<Preference>().HasData(
                new Preference
                {
                    PreferenceId = 1,
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 2,
                    LanguageId = 2
                },
                new Preference
                {
                    PreferenceId = 3,
                    LanguageId = 3
                },
                new Preference
                {
                    PreferenceId = 4,
                    LanguageId = 4
                },
                new Preference
                {
                    PreferenceId = 5,
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 6,
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
                },
                new PreferenceGameCategory
                {
                    PreferenceId = 4,
                    GameCategoryId = 1
                },
                new PreferenceGameCategory
                {
                    PreferenceId = 5,
                    GameCategoryId = 1
                },
                new PreferenceGameCategory
                {
                    PreferenceId = 6,
                    GameCategoryId = 1
                }
            );

            builder.Entity<MailingAddress>().HasData(
                new MailingAddress
                {
                    FirstName = "Tyrone",
                    LastName = "Mcgee",
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
                },
                new MailingAddress
                {
                    MailingAddressId = 5,
                    ProvinceId = 1
                },
                new MailingAddress
                {
                    MailingAddressId = 6,
                    ProvinceId = 2
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
            var memberRole = new IdentityRole
            {
                Name = "Member",
                NormalizedName = "MEMBER"
            };

            builder.Entity<IdentityRole>().HasData(
                superadminRole,
                adminRole,
                moderatorRole,
                memberRole
            );

            // Seed Default Users
            PasswordHasher<User> ph = new PasswordHasher<User>();

            var superadmin = new User
            {
                UserName = "SuperAdmin",
                NormalizedUserName = "SUPERADMIN",
                FirstName = "Tyrone",
                LastName = "Mcgee",
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
                FirstName = "William",
                LastName = "Potter",
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
                NormalizedUserName = "MODERATOR",
                FirstName = "Francis",
                LastName = "Ramos",
                Email = "moderator@gmail.com",
                NormalizedEmail = "MODERATOR@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 3,
                GenderId = 3,
                PreferenceId = 3
            };

            moderator.PasswordHash = ph.HashPassword(moderator, "Moderator123!@");

            var member = new User
            {
                UserName = "Member",
                NormalizedUserName = "MEMBER",
                FirstName = "Ernest",
                LastName = "Mcknight",
                Email = "member@gmail.com",
                NormalizedEmail = "MEMBER@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 4,
                GenderId = 3,
                PreferenceId = 4
            };

            member.PasswordHash = ph.HashPassword(member, "Member123!@");

            var tester1 = new User
            {
                UserName = "Tester1",
                NormalizedUserName = "TESTER1",
                FirstName = "Test1FirstName",
                LastName = "Test1LastName",
                Email = "tester1@gmail.com",
                NormalizedEmail = "TESTER1@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 5,
                GenderId = 3,
                PreferenceId = 5
            };

            tester1.PasswordHash = ph.HashPassword(tester1, "Tester1!@");

            var tester2 = new User
            {
                UserName = "Tester2",
                NormalizedUserName = "TESTER2",
                FirstName = "Test2FirstName",
                LastName = "Test2LastName",
                Email = "tester2@gmail.com",
                NormalizedEmail = "TESTER2@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                MailingAddressId = 6,
                GenderId = 3,
                PreferenceId = 6
            };

            tester2.PasswordHash = ph.HashPassword(tester2, "Tester2!@");

            builder.Entity<User>().HasData(superadmin);
            builder.Entity<User>().HasData(admin);
            builder.Entity<User>().HasData(moderator);
            builder.Entity<User>().HasData(member);
            builder.Entity<User>().HasData(tester1);
            builder.Entity<User>().HasData(tester2);

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
                    UserId = member.Id,
                    RoleId = memberRole.Id
                },
                new IdentityUserRole<string>
                {
                    UserId = tester1.Id,
                    RoleId = memberRole.Id
                },
                new IdentityUserRole<string>
                {
                    UserId = tester2.Id,
                    RoleId = memberRole.Id
                }
            );

            // Configure Many-to-Many relationship between Preference-PreferenceFavouritePlatform-FavouritePlatform
            builder.Entity<PreferenceFavouritePlatform>()
                .HasKey(pfp => new { pfp.PreferenceId, pfp.FavouritePlatformId });
            builder.Entity<PreferenceFavouritePlatform>()
                .HasOne(pfp => pfp.Preference)
                .WithMany(p => p.PreferenceFavouritePlatforms)
                .HasForeignKey(pfp => pfp.PreferenceId);
            builder.Entity<PreferenceFavouritePlatform>()
                .HasOne(pfp => pfp.FavouritePlatform)
                .WithMany(fp => fp.PreferenceFavouritePlatforms)
                .HasForeignKey(pfp => pfp.FavouritePlatformId);


            builder.Entity<PreferenceFavouritePlatform>().HasData(
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 1,
                    FavouritePlatformId = 1
                },
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 1,
                    FavouritePlatformId = 2
                },
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 2,
                    FavouritePlatformId = 2
                },
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 2,
                    FavouritePlatformId = 3
                },
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 3,
                    FavouritePlatformId = 1
                },
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 4,
                    FavouritePlatformId = 1
                },
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 5,
                    FavouritePlatformId = 1
                },
                new PreferenceFavouritePlatform
                {
                    PreferenceId = 6,
                    FavouritePlatformId = 1
                }
            );

            builder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Title = "Counter-Strike 2",
                    Description = "For over two decades, Counter-Strike has offered an elite competitive " +
                                    "experience, one shaped by millions of players from across the globe. " +
                                    "And now the next chapter in the CS story is about to begin. This is " +
                                    "Counter-Strike 2.",
                    Price = 0,
                    PublishDate = DateTime.Parse("2012-08-21"),
                    GameCategoryId = 3
                },
                new Game
                {
                    GameId = 2,
                    Title = "Star Trek: Infinite",
                    Description = "Star Trek: Infinite is a grand strategy experience that lets you play " +
                                    "your own Star Trek story as the leader of one of four major factions " +
                                    "in the galaxy. Follow the specially crafted story or blaze your own trail " +
                                    "in the first Star Trek grand strategy game.",
                    Price = 39.99,
                    PublishDate = DateTime.Parse("2023-10-12"),
                    GameCategoryId = 1
                },
                new Game
                {
                    GameId = 3,
                    Title = "Cities: Skylines II",
                    Description = "Raise a city from the ground up and transform it into a thriving metropolis " +
                                    "with the most realistic city builder ever. Push your creativity and " +
                                    "problem-solving to build on a scale you've never experienced. With deep " +
                                    "simulation and a living economy, this is world-building without limits.",
                    Price = 59.99,
                    PublishDate = DateTime.Parse("2023-10-12"),
                    GameCategoryId = 2
                }
            );

            // Configure Many-to-Many relationship between User-Review-Game
            builder.Entity<Review>()
                .HasKey(r => r.ReviewId);
            builder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);
            builder.Entity<Review>()
                .HasOne(r => r.Game)
                .WithMany(g => g.Reviews)
                .HasForeignKey(r => r.GameId);

            builder.Entity<Review>().HasData(
                new Review
                {
                    ReviewId = 1,
                    Title = "The Best Game!",
                    Description = "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.",
                    Rating = 5,
                    Status = "Pending",
                    UserId = member.Id,
                    GameId = 1,
                },
                new Review
                {
                    ReviewId = 2,
                    Title = "Good Game",
                    Description = "Star Trek: Infinite is a decent game to play. I'll definitely recommend you to play.",
                    Rating = 4,
                    Status = "Processed",
                    UserId = admin.Id,
                    GameId = 2,
                },
                new Review
                {
                    ReviewId = 3,
                    Title = "Bad Game!",
                    Description = "Cities: Skylines II is my type of game. I'm more into puzzle and mystery,",
                    Rating = 2,
                    Status = "Pending",
                    UserId = moderator.Id,
                    GameId = 3,
                },
                new Review
                {
                    ReviewId = 4,
                    Title = "Bad Game!",
                    Description = "I wasn't into this game since I have a 3D motion sickness.",
                    Rating = 2,
                    Status = "Pending",
                    UserId = moderator.Id,
                    GameId = 2,
                }
            );

            builder.Entity<ShippingAddress>().HasData(
                new ShippingAddress
                {
                    ShippingAddressId = 1,
                    Street = "978 ARGYLE ST N",
                    City = "HALIFAX",
                    Province = "NU",
                    Country = "Canada",
                    PostalCode = "B3J 2B3",
                    DeliveryInstruction = "At the door"
                },
                new ShippingAddress
                {
                    ShippingAddressId = 2,
                    Unit = "501",
                    Street = "87 DANFORTH AVE",
                    City = "TORONTO",
                    Province = "ON",
                    Country = "Canada",
                    PostalCode = "M4K 1M8",
                    DeliveryInstruction = "At the Post Box"
                },
                new ShippingAddress
                {
                    ShippingAddressId = 3,
                    Street = "4 FIRST AVE S",
                    City = "BIG VALLEY",
                    Province = "AB",
                    Country = "Canada",
                    PostalCode = "T0L 1K0"
                },
                new ShippingAddress
                {
                    ShippingAddressId = 4,
                    Street = "PO BOX 4600 STN B",
                    City = "COURTENAY",
                    Province = "BC",
                    Country = "Canada",
                    PostalCode = "V9N 0A7",
                    DeliveryInstruction = "Ask the security Guard to get in."
                }
            );

            builder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    UserId = member.Id,
                    Status = "Processed",
                    OrderDate = DateTime.Parse("2012-09-21"),
                    ShippingAddress = "PO BOX 4600 STN B, Courtenay, BC, Canada, V9N 0A7"
                },
                new Order
                {
                    OrderId = 2,
                    UserId = admin.Id,
                    Status = "Processed",
                    OrderDate = DateTime.Parse("2020-10-21"),
                    ShippingAddress = "87 Danforth Ave, Toronto, ON, Canada, M4K 1M8"
                },
                new Order
                {
                    OrderId = 3,
                    UserId = moderator.Id,
                    Status = "Pending",
                    OrderDate = DateTime.Parse("2022-02-19"),
                    ShippingAddress = "4 First Ave S, Big Valley, AB, Canada, T0L 1K0"
                }
            );

            // Configure Many-to-Many relationship between User-Review-Game
            builder.Entity<OrderGame>()
                .HasKey(og => og.OrderGameId);
            builder.Entity<OrderGame>()
                .HasOne(og => og.Order)
                .WithMany(o => o.OrderGames)
                .HasForeignKey(og => og.OrderId);
            builder.Entity<OrderGame>()
                .HasOne(og => og.Game)
                .WithMany(g => g.OrderGames)
                .HasForeignKey(og => og.GameId);

            builder.Entity<OrderGame>().HasData(
                new OrderGame
                {
                    OrderGameId = 1,
                    OrderId = 1,
                    GameId = 1,
                    Quantity = 1
                }
                ,
                new OrderGame
                {
                    OrderGameId = 2,
                    OrderId = 1,
                    GameId = 2,
                    Quantity = 2
                },
                new OrderGame
                {
                    OrderGameId = 3,
                    OrderId = 2,
                    GameId = 2,
                    Quantity = 1
                },
                new OrderGame
                {
                    OrderGameId = 4,
                    OrderId = 2,
                    GameId = 3,
                    Quantity = 3
                },
                new OrderGame
                {
                    OrderGameId = 5,
                    OrderId = 3,
                    GameId = 3,
                    Quantity = 1
                }
            );

            builder.Entity<Event>().HasData(
                new Event
                {
                    EventId = 1,
                    Title = "2023 Annual Event",
                    Description = "Welcome Newcomers! Enjoy the party!",
                    StartDateTime = DateTime.Parse("2023-11-11"),
                    EndDateTime = DateTime.Parse("2023-11-13")
                },
                new Event
                {
                    EventId = 2,
                    Title = "2023 GameCon",
                    Description = "Welcome Game Developers! Enjoy the party!",
                    StartDateTime = DateTime.Parse("2023-12-13"),
                    EndDateTime = DateTime.Parse("2023-12-14")
                }
            );

            // Configure Many-to-Many relationship between Preference-PreferenceFavouritePlatform-FavouritePlatform
            builder.Entity<EventUser>()
                .HasKey(eu => new { eu.EventId, eu.UserId });
            builder.Entity<EventUser>()
                .HasOne(eu => eu.Event)
                .WithMany(e => e.EventUsers)
                .HasForeignKey(eu => eu.EventId);
            builder.Entity<EventUser>()
                .HasOne(eu => eu.User)
                .WithMany(u => u.EventUsers)
                .HasForeignKey(eu => eu.UserId);

            builder.Entity<EventUser>().HasData(
                new EventUser
                {
                    EventId = 1,
                    UserId = member.Id
                },
                new EventUser
                {
                    EventId = 2,
                    UserId = member.Id
                },
                new EventUser
                {
                    EventId = 1,
                    UserId = moderator.Id
                },
                new EventUser
                {
                    EventId = 1,
                    UserId = admin.Id
                },
                new EventUser
                {
                    EventId = 2,
                    UserId = admin.Id
                }
            );

            builder.Entity<FriendFamily>()
                .HasKey(ff => new { ff.RequesterUserId, ff.ReceiverUserId });
            builder.Entity<FriendFamily>()
                .HasOne(ff => ff.RequesterUser)
                .WithMany(u => u.FriendFamilyRequester)
                .HasForeignKey(ff => ff.RequesterUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.Entity<FriendFamily>()
                .HasOne(ff => ff.ReceiverUser)
                .WithMany(u => u.FriendFamilyReceiver)
                .HasForeignKey(ff => ff.ReceiverUserId)
                .OnDelete(DeleteBehavior.ClientSetNull);


            builder.Entity<FriendFamily>().HasData(
                new FriendFamily
                {
                    RequesterUserId = admin.Id,
                    ReceiverUserId = member.Id,
                    Description = "Friend",
                    Status = "Processed"
                },
                new FriendFamily
                {
                    RequesterUserId = moderator.Id,
                    ReceiverUserId = member.Id,
                    Description = "Family",
                    Status = "Processed"
                },
                new FriendFamily
                {
                    RequesterUserId = member.Id,
                    ReceiverUserId = superadmin.Id,
                    Description = "Friend",
                    Status = "Pending"
                },
                new FriendFamily
                {
                    RequesterUserId = moderator.Id,
                    ReceiverUserId = superadmin.Id,
                    Description = "Family",
                    Status = "Pending"
                }
            );

            builder.Entity<Wishlist>()
            .HasKey(w => new { w.UserId, w.GameId });

            builder.Entity<Wishlist>().HasData(
                new Wishlist
                {
                    UserId = tester1.Id,
                    GameId = 1, 
                }
            );

            // Many-to-Many relationship between User and Games via Cart
            builder.Entity<Cart>()
                .HasKey(c => new { c.UserId, c.GameId });

            builder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany(u => u.Carts)
                .HasForeignKey(c => c.UserId);

            builder.Entity<Cart>()
                .HasOne(c => c.Game)
                .WithMany(g => g.Carts)
                .HasForeignKey(c => c.GameId);
        }

        public DbSet<Cart> Cart {  get; set; }

        public DbSet<Wishlist>? Wishlist { get; set; }

        public DbSet<Gender>? Genders { get; set; }

        public DbSet<Country>? Country { get; set; }

        public DbSet<Province>? Province { get; set; }

        public DbSet<Language>? Language { get; set; }

        public DbSet<Preference>? Preference { get; set; }

        public DbSet<FavouritePlatform>? FavouritePlatform { get; set; }

        public DbSet<PreferenceGameCategory>? PreferenceGameCategory { get; set; }

        public DbSet<PreferenceFavouritePlatform>? PreferenceFavouritePlatform { get; set; }

        public DbSet<MailingAddress>? MailingAddress { get; set; }

        public DbSet<GameCategory>? GameCategory { get; set; }

        public DbSet<Game>? Game { get; set; }

        public DbSet<Review>? Review { get; set; }

        public DbSet<ShippingAddress>? ShippingAddress { get; set; }

        public DbSet<Order>? Order { get; set; }

        public DbSet<OrderGame>? OrderGame { get; set; }

        public DbSet<Event>? Event { get; set; }

        public DbSet<EventUser>? EventUser { get; set; }

        public DbSet<Report>? Report { get; set; }

        public DbSet<FriendFamily>? FriendFamily { get; set; }

        public DbSet<User>? User { get; set; }
    }
}