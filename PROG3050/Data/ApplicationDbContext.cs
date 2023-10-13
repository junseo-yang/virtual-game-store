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
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 2,
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 3,
                    LanguageId = 1
                },
                new Preference
                {
                    PreferenceId = 4,
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
                    Province = "NU",
                    Country = "Canada",
                    PostalCode = "B3J 2B3",
                    DeliveryInstruction = "At the door"
                },
                new MailingAddress
                {
                    MailingAddressId = 2,
                    Unit = "501",
                    Street = "87 DANFORTH AVE",
                    City = "TORONTO",
                    Province = "ON",
                    Country = "Canada",
                    PostalCode = "M4K 1M8",
                    DeliveryInstruction = "At the Post Box"
                },
                new MailingAddress
                {
                    MailingAddressId = 3,
                    Street = "4 FIRST AVE S",
                    City = "BIG VALLEY",
                    Province = "AB",
                    Country = "Canada",
                    PostalCode = "T0L 1K0"
                },
                new MailingAddress
                {
                    MailingAddressId = 4,
                    Street = "PO BOX 4600 STN B",
                    City = "COURTENAY",
                    Province = "BC",
                    Country = "Canada",
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
                    UserId = basic.Id,
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
                    Description = "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.",
                    Rating = 2,
                    Status = "Pending",
                    UserId = moderator.Id,
                    GameId = 3,
                },
                new Review
                {
                    ReviewId = 4,
                    Title = "Bad Game!",
                    Description = "Counter-Strike 2 is the best game that I've ever played. Actions and graphics are amazing.",
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
                    UserId = basic.Id,
                    Status = "Processed",
                    OrderDate = DateTime.Parse("2012-09-21"),
                    ShippingAddressId = 4
                },
                new Order
                {
                    OrderId = 2,
                    UserId = admin.Id,
                    Status = "Processed",
                    OrderDate = DateTime.Parse("2020-10-21"),
                    ShippingAddressId = 2
                },
                new Order
                {
                    OrderId = 3,
                    UserId = moderator.Id,
                    Status = "Pending",
                    OrderDate = DateTime.Parse("2022-02-19"),
                    ShippingAddressId = 3
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
                .HasForeignKey(eu=> eu.UserId);

            builder.Entity<EventUser>().HasData(
                new EventUser
                {
                    EventId = 1,
                    UserId = basic.Id
                },
                new EventUser
                {
                    EventId = 2,
                    UserId = basic.Id
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
        }

        public DbSet<Gender>? Genders { get; set; }

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
    }
}