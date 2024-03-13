﻿// <auto-generated />
using System;
using BookManagementSystem.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagementSystem.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<Guid>("BooksId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenresId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BooksId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.ApplicationUser", b =>
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("TokensAvailable")
                        .HasColumnType("int");

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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "9fc6cbc1-880c-4d3a-9b47-323caa694751",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "56a367a1-6884-4279-b0f0-39ca1f3609d4",
                            Email = "admin@123.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Admin123",
                            NormalizedEmail = "ADMIN@123.COM",
                            NormalizedUserName = "ADMIN@123.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGFnW2Ay5ERZCT4eCder7omx+w1wxaMqeDfithv12wD0HOM8efOvGx4WE7bU0/A2pA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "65f65885-d0ef-41d8-83b1-2793f05ee918",
                            TokensAvailable = 0,
                            TwoFactorEnabled = false,
                            UserName = "admin@123.com"
                        },
                        new
                        {
                            Id = "bc63ba64-0945-4a63-8237-075242ca235d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "09e22560-dfa5-4220-bf95-ce4a510c29bc",
                            Email = "amisha1234@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Amisha12",
                            NormalizedEmail = "AMISHA1234@GMAIL.COM",
                            NormalizedUserName = "AMISH1234@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEE7wlSakHLXf+8PGKMqdAiHXDoi3e9CR6nz5viy/zDRlgjo/rQnWinE5v6xh6X/hfg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "36fb69b9-2d91-4b05-a55a-1df7227bfe29",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "amisha@1234"
                        },
                        new
                        {
                            Id = "fd94d74b-fae4-4813-b2e5-e218898e7813",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1875fd2f-d2d9-4f1d-83da-de1862fbb202",
                            Email = "user1@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "User01",
                            NormalizedEmail = "USER1@TEST.COM",
                            NormalizedUserName = "USER1@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAELcXA6+xID4CadwY0cJgdKb1K5MHaxglhuIXNFr3vjFCk0VEEeI4qNMs44+LJeGkQw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c1c1dc04-263d-41ea-a736-b6232a58c3cb",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "user1@test.com"
                        },
                        new
                        {
                            Id = "5a4bb6b2-d83f-4235-bc2c-ddebd71685c6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d3867f3e-cf01-41a6-9d34-3cf0c3096007",
                            Email = "amisha@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Amisha",
                            NormalizedEmail = "AMISHA@TEST.COM",
                            NormalizedUserName = "AMISHA@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAENZJ3BXMrBjK3oGvgYzNoa514xrv3qrQ4HGgAXrlLQWypwrIDBNz6XKBwoYAwT5Dfg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a5b6a481-e4f8-4905-b7fe-c371074a0411",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "amisha@test.com"
                        },
                        new
                        {
                            Id = "3db2d1d3-d595-421d-9f62-5973aafcb2e7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2a206bb3-c6f8-4bd7-b7f8-837707d994a8",
                            Email = "user3@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "User03",
                            NormalizedEmail = "USER3@TEST.COM",
                            NormalizedUserName = "USER3@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAED5plgBAMnuoVB/v9oe8X1k79qWRkX08at40XurTYtow/6GHe7yj7w4UtXcu5OMFvQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "323ac729-db80-42c9-9185-f19a526c5460",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "user3@test.com"
                        });
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentlyBorrowedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("LentByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ratings")
                        .HasColumnType("float");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.BookImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookImages");
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b2cc93b6-4ebe-4f73-bc4b-2ea55e6ad1bd"),
                            Name = "Fantasy",
                            UrlHandle = "/Fantasy"
                        },
                        new
                        {
                            Id = new Guid("476f2b86-37c2-4cd5-97f8-d1ef14eb23f2"),
                            Name = "Novel",
                            UrlHandle = "/Novel"
                        },
                        new
                        {
                            Id = new Guid("56db2a2c-cc51-4a4c-9db2-cadf0f1750bd"),
                            Name = "Science Fiction",
                            UrlHandle = "Science Fiction"
                        },
                        new
                        {
                            Id = new Guid("c199371a-fb18-4d4d-9646-b50b8a07f179"),
                            Name = "Others",
                            UrlHandle = "/Others"
                        });
                });

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1",
                            ConcurrencyStamp = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1",
                            Name = "Reader",
                            NormalizedName = "READER"
                        },
                        new
                        {
                            Id = "95cb1e1c-d8b6-45a2-b240-6d211c06fd00",
                            ConcurrencyStamp = "95cb1e1c-d8b6-45a2-b240-6d211c06fd00",
                            Name = "Writer",
                            NormalizedName = "WRITER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "9fc6cbc1-880c-4d3a-9b47-323caa694751",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "9fc6cbc1-880c-4d3a-9b47-323caa694751",
                            RoleId = "95cb1e1c-d8b6-45a2-b240-6d211c06fd00"
                        },
                        new
                        {
                            UserId = "bc63ba64-0945-4a63-8237-075242ca235d",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "fd94d74b-fae4-4813-b2e5-e218898e7813",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "5a4bb6b2-d83f-4235-bc2c-ddebd71685c6",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "3db2d1d3-d595-421d-9f62-5973aafcb2e7",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("BookManagementSystem.API.Models.Domain.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagementSystem.API.Models.Domain.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
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

                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}