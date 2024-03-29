﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bibliotheek.WPF.Database;

#nullable disable

namespace bibliotheek.WPF.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorModelItemModel", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("AuthorId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("AuthorModelItemModel");
                });

            modelBuilder.Entity("NameSpace.Models.AuthorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Img_idId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .HasColumnType("ntext");

                    b.HasKey("Id");

                    b.HasIndex("Img_idId");

                    b.ToTable("author");
                });

            modelBuilder.Entity("NameSpace.Models.ImgModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("img");
                });

            modelBuilder.Entity("NameSpace.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<int?>("Length")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleasedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("ntext");

                    b.Property<string>("Tags")
                        .HasColumnType("ntext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("item");
                });

            modelBuilder.Entity("NameSpace.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Img_idId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phonenumber")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Img_idId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Simonis",
                            LastName = "Simonis",
                            Phonenumber = 451867,
                            Role = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Klocko",
                            LastName = "Klocko",
                            Phonenumber = 553476,
                            Role = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Crooks",
                            LastName = "Crooks",
                            Phonenumber = 544159,
                            Role = 1
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Koepp",
                            LastName = "Koepp",
                            Phonenumber = 159408,
                            Role = 2
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Nienow",
                            LastName = "Nienow",
                            Phonenumber = 371969,
                            Role = 1
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Reinger",
                            LastName = "Reinger",
                            Phonenumber = 525252,
                            Role = 1
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Nitzsche",
                            LastName = "Nitzsche",
                            Phonenumber = 793941,
                            Role = 2
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Rogahn",
                            LastName = "Rogahn",
                            Phonenumber = 786408,
                            Role = 1
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Emmerich",
                            LastName = "Emmerich",
                            Phonenumber = 830713,
                            Role = 1
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Durgan",
                            LastName = "Durgan",
                            Phonenumber = 620668,
                            Role = 2
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Kshlerin",
                            LastName = "Kshlerin",
                            Phonenumber = 670246,
                            Role = 1
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Gerlach",
                            LastName = "Gerlach",
                            Phonenumber = 513533,
                            Role = 2
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "Harvey",
                            LastName = "Harvey",
                            Phonenumber = 588898,
                            Role = 2
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "Moen",
                            LastName = "Moen",
                            Phonenumber = 713356,
                            Role = 2
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "Lang",
                            LastName = "Lang",
                            Phonenumber = 520035,
                            Role = 1
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "Corwin",
                            LastName = "Corwin",
                            Phonenumber = 323327,
                            Role = 2
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "Hane",
                            LastName = "Hane",
                            Phonenumber = 724191,
                            Role = 1
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "VonRueden",
                            LastName = "VonRueden",
                            Phonenumber = 78236,
                            Role = 2
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "Prohaska",
                            LastName = "Prohaska",
                            Phonenumber = 137069,
                            Role = 2
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "Hudson",
                            LastName = "Hudson",
                            Phonenumber = 688228,
                            Role = 2
                        },
                        new
                        {
                            Id = 21,
                            FirstName = "Kub",
                            LastName = "Kub",
                            Phonenumber = 984349,
                            Role = 2
                        },
                        new
                        {
                            Id = 22,
                            FirstName = "Gutmann",
                            LastName = "Gutmann",
                            Phonenumber = 428004,
                            Role = 2
                        },
                        new
                        {
                            Id = 23,
                            FirstName = "Gaylord",
                            LastName = "Gaylord",
                            Phonenumber = 645756,
                            Role = 1
                        },
                        new
                        {
                            Id = 24,
                            FirstName = "Sipes",
                            LastName = "Sipes",
                            Phonenumber = 112874,
                            Role = 1
                        },
                        new
                        {
                            Id = 25,
                            FirstName = "Littel",
                            LastName = "Littel",
                            Phonenumber = 215318,
                            Role = 2
                        },
                        new
                        {
                            Id = 26,
                            FirstName = "Dicki",
                            LastName = "Dicki",
                            Phonenumber = 576699,
                            Role = 2
                        },
                        new
                        {
                            Id = 27,
                            FirstName = "Batz",
                            LastName = "Batz",
                            Phonenumber = 263040,
                            Role = 1
                        },
                        new
                        {
                            Id = 28,
                            FirstName = "Farrell",
                            LastName = "Farrell",
                            Phonenumber = 501813,
                            Role = 1
                        },
                        new
                        {
                            Id = 29,
                            FirstName = "Glover",
                            LastName = "Glover",
                            Phonenumber = 890564,
                            Role = 1
                        },
                        new
                        {
                            Id = 30,
                            FirstName = "Prohaska",
                            LastName = "Prohaska",
                            Phonenumber = 53924,
                            Role = 2
                        },
                        new
                        {
                            Id = 31,
                            FirstName = "Schultz",
                            LastName = "Schultz",
                            Phonenumber = 886217,
                            Role = 1
                        },
                        new
                        {
                            Id = 32,
                            FirstName = "Russel",
                            LastName = "Russel",
                            Phonenumber = 288398,
                            Role = 2
                        },
                        new
                        {
                            Id = 33,
                            FirstName = "Heller",
                            LastName = "Heller",
                            Phonenumber = 821967,
                            Role = 1
                        },
                        new
                        {
                            Id = 34,
                            FirstName = "Smitham",
                            LastName = "Smitham",
                            Phonenumber = 952901,
                            Role = 2
                        },
                        new
                        {
                            Id = 35,
                            FirstName = "Stehr",
                            LastName = "Stehr",
                            Phonenumber = 559622,
                            Role = 1
                        },
                        new
                        {
                            Id = 36,
                            FirstName = "Keebler",
                            LastName = "Keebler",
                            Phonenumber = 472973,
                            Role = 2
                        },
                        new
                        {
                            Id = 37,
                            FirstName = "Cummerata",
                            LastName = "Cummerata",
                            Phonenumber = 182453,
                            Role = 2
                        },
                        new
                        {
                            Id = 38,
                            FirstName = "Kirlin",
                            LastName = "Kirlin",
                            Phonenumber = 992672,
                            Role = 2
                        },
                        new
                        {
                            Id = 39,
                            FirstName = "Muller",
                            LastName = "Muller",
                            Phonenumber = 230397,
                            Role = 1
                        },
                        new
                        {
                            Id = 40,
                            FirstName = "Gibson",
                            LastName = "Gibson",
                            Phonenumber = 755249,
                            Role = 2
                        },
                        new
                        {
                            Id = 41,
                            FirstName = "Anderson",
                            LastName = "Anderson",
                            Phonenumber = 475580,
                            Role = 2
                        },
                        new
                        {
                            Id = 42,
                            FirstName = "Klocko",
                            LastName = "Klocko",
                            Phonenumber = 984010,
                            Role = 2
                        },
                        new
                        {
                            Id = 43,
                            FirstName = "Hills",
                            LastName = "Hills",
                            Phonenumber = 14064,
                            Role = 1
                        },
                        new
                        {
                            Id = 44,
                            FirstName = "Kutch",
                            LastName = "Kutch",
                            Phonenumber = 848768,
                            Role = 2
                        },
                        new
                        {
                            Id = 45,
                            FirstName = "Borer",
                            LastName = "Borer",
                            Phonenumber = 871566,
                            Role = 2
                        },
                        new
                        {
                            Id = 46,
                            FirstName = "Adams",
                            LastName = "Adams",
                            Phonenumber = 31929,
                            Role = 1
                        },
                        new
                        {
                            Id = 47,
                            FirstName = "Schmitt",
                            LastName = "Schmitt",
                            Phonenumber = 19110,
                            Role = 1
                        },
                        new
                        {
                            Id = 48,
                            FirstName = "Daniel",
                            LastName = "Daniel",
                            Phonenumber = 762410,
                            Role = 1
                        },
                        new
                        {
                            Id = 49,
                            FirstName = "Dibbert",
                            LastName = "Dibbert",
                            Phonenumber = 229704,
                            Role = 1
                        },
                        new
                        {
                            Id = 50,
                            FirstName = "Emmerich",
                            LastName = "Emmerich",
                            Phonenumber = 590582,
                            Role = 2
                        },
                        new
                        {
                            Id = 51,
                            FirstName = "Mertz",
                            LastName = "Mertz",
                            Phonenumber = 803386,
                            Role = 1
                        },
                        new
                        {
                            Id = 52,
                            FirstName = "Walter",
                            LastName = "Walter",
                            Phonenumber = 186461,
                            Role = 1
                        },
                        new
                        {
                            Id = 53,
                            FirstName = "Ziemann",
                            LastName = "Ziemann",
                            Phonenumber = 751390,
                            Role = 2
                        },
                        new
                        {
                            Id = 54,
                            FirstName = "Stark",
                            LastName = "Stark",
                            Phonenumber = 871984,
                            Role = 1
                        },
                        new
                        {
                            Id = 55,
                            FirstName = "Mertz",
                            LastName = "Mertz",
                            Phonenumber = 161409,
                            Role = 1
                        },
                        new
                        {
                            Id = 56,
                            FirstName = "Rau",
                            LastName = "Rau",
                            Phonenumber = 55749,
                            Role = 1
                        },
                        new
                        {
                            Id = 57,
                            FirstName = "Hackett",
                            LastName = "Hackett",
                            Phonenumber = 829006,
                            Role = 2
                        },
                        new
                        {
                            Id = 58,
                            FirstName = "Hickle",
                            LastName = "Hickle",
                            Phonenumber = 556540,
                            Role = 2
                        },
                        new
                        {
                            Id = 59,
                            FirstName = "Witting",
                            LastName = "Witting",
                            Phonenumber = 246308,
                            Role = 1
                        },
                        new
                        {
                            Id = 60,
                            FirstName = "Thompson",
                            LastName = "Thompson",
                            Phonenumber = 839983,
                            Role = 2
                        },
                        new
                        {
                            Id = 61,
                            FirstName = "Blanda",
                            LastName = "Blanda",
                            Phonenumber = 187295,
                            Role = 1
                        },
                        new
                        {
                            Id = 62,
                            FirstName = "Mante",
                            LastName = "Mante",
                            Phonenumber = 152826,
                            Role = 1
                        },
                        new
                        {
                            Id = 63,
                            FirstName = "Harber",
                            LastName = "Harber",
                            Phonenumber = 959554,
                            Role = 1
                        },
                        new
                        {
                            Id = 64,
                            FirstName = "Flatley",
                            LastName = "Flatley",
                            Phonenumber = 802095,
                            Role = 2
                        },
                        new
                        {
                            Id = 65,
                            FirstName = "Lockman",
                            LastName = "Lockman",
                            Phonenumber = 813755,
                            Role = 1
                        },
                        new
                        {
                            Id = 66,
                            FirstName = "Bergstrom",
                            LastName = "Bergstrom",
                            Phonenumber = 730401,
                            Role = 1
                        },
                        new
                        {
                            Id = 67,
                            FirstName = "Botsford",
                            LastName = "Botsford",
                            Phonenumber = 449724,
                            Role = 1
                        },
                        new
                        {
                            Id = 68,
                            FirstName = "Beatty",
                            LastName = "Beatty",
                            Phonenumber = 808368,
                            Role = 1
                        },
                        new
                        {
                            Id = 69,
                            FirstName = "Boyle",
                            LastName = "Boyle",
                            Phonenumber = 780146,
                            Role = 2
                        },
                        new
                        {
                            Id = 70,
                            FirstName = "Ruecker",
                            LastName = "Ruecker",
                            Phonenumber = 461486,
                            Role = 2
                        },
                        new
                        {
                            Id = 71,
                            FirstName = "Cormier",
                            LastName = "Cormier",
                            Phonenumber = 134351,
                            Role = 1
                        },
                        new
                        {
                            Id = 72,
                            FirstName = "Grimes",
                            LastName = "Grimes",
                            Phonenumber = 579524,
                            Role = 1
                        },
                        new
                        {
                            Id = 73,
                            FirstName = "Nikolaus",
                            LastName = "Nikolaus",
                            Phonenumber = 655786,
                            Role = 1
                        },
                        new
                        {
                            Id = 74,
                            FirstName = "Wilderman",
                            LastName = "Wilderman",
                            Phonenumber = 826793,
                            Role = 1
                        },
                        new
                        {
                            Id = 75,
                            FirstName = "Conroy",
                            LastName = "Conroy",
                            Phonenumber = 486604,
                            Role = 2
                        },
                        new
                        {
                            Id = 76,
                            FirstName = "Kovacek",
                            LastName = "Kovacek",
                            Phonenumber = 787440,
                            Role = 2
                        },
                        new
                        {
                            Id = 77,
                            FirstName = "Grady",
                            LastName = "Grady",
                            Phonenumber = 443132,
                            Role = 2
                        },
                        new
                        {
                            Id = 78,
                            FirstName = "Zboncak",
                            LastName = "Zboncak",
                            Phonenumber = 109120,
                            Role = 1
                        },
                        new
                        {
                            Id = 79,
                            FirstName = "Olson",
                            LastName = "Olson",
                            Phonenumber = 988641,
                            Role = 2
                        },
                        new
                        {
                            Id = 80,
                            FirstName = "Swift",
                            LastName = "Swift",
                            Phonenumber = 41280,
                            Role = 1
                        },
                        new
                        {
                            Id = 81,
                            FirstName = "Barton",
                            LastName = "Barton",
                            Phonenumber = 74965,
                            Role = 2
                        },
                        new
                        {
                            Id = 82,
                            FirstName = "Weber",
                            LastName = "Weber",
                            Phonenumber = 157925,
                            Role = 2
                        },
                        new
                        {
                            Id = 83,
                            FirstName = "Jerde",
                            LastName = "Jerde",
                            Phonenumber = 684555,
                            Role = 2
                        },
                        new
                        {
                            Id = 84,
                            FirstName = "Davis",
                            LastName = "Davis",
                            Phonenumber = 241239,
                            Role = 1
                        },
                        new
                        {
                            Id = 85,
                            FirstName = "Johns",
                            LastName = "Johns",
                            Phonenumber = 39989,
                            Role = 1
                        },
                        new
                        {
                            Id = 86,
                            FirstName = "Cruickshank",
                            LastName = "Cruickshank",
                            Phonenumber = 208699,
                            Role = 2
                        },
                        new
                        {
                            Id = 87,
                            FirstName = "Dickinson",
                            LastName = "Dickinson",
                            Phonenumber = 597747,
                            Role = 2
                        },
                        new
                        {
                            Id = 88,
                            FirstName = "Beahan",
                            LastName = "Beahan",
                            Phonenumber = 897952,
                            Role = 1
                        },
                        new
                        {
                            Id = 89,
                            FirstName = "Klein",
                            LastName = "Klein",
                            Phonenumber = 749815,
                            Role = 2
                        },
                        new
                        {
                            Id = 90,
                            FirstName = "Kling",
                            LastName = "Kling",
                            Phonenumber = 635715,
                            Role = 1
                        },
                        new
                        {
                            Id = 91,
                            FirstName = "Jakubowski",
                            LastName = "Jakubowski",
                            Phonenumber = 198415,
                            Role = 1
                        },
                        new
                        {
                            Id = 92,
                            FirstName = "Crist",
                            LastName = "Crist",
                            Phonenumber = 64645,
                            Role = 2
                        },
                        new
                        {
                            Id = 93,
                            FirstName = "Runte",
                            LastName = "Runte",
                            Phonenumber = 310401,
                            Role = 2
                        },
                        new
                        {
                            Id = 94,
                            FirstName = "Grimes",
                            LastName = "Grimes",
                            Phonenumber = 797745,
                            Role = 2
                        },
                        new
                        {
                            Id = 95,
                            FirstName = "Gutmann",
                            LastName = "Gutmann",
                            Phonenumber = 447972,
                            Role = 2
                        },
                        new
                        {
                            Id = 96,
                            FirstName = "Zieme",
                            LastName = "Zieme",
                            Phonenumber = 319310,
                            Role = 2
                        },
                        new
                        {
                            Id = 97,
                            FirstName = "Jakubowski",
                            LastName = "Jakubowski",
                            Phonenumber = 169789,
                            Role = 2
                        },
                        new
                        {
                            Id = 98,
                            FirstName = "Kunde",
                            LastName = "Kunde",
                            Phonenumber = 662804,
                            Role = 2
                        },
                        new
                        {
                            Id = 99,
                            FirstName = "Nikolaus",
                            LastName = "Nikolaus",
                            Phonenumber = 191785,
                            Role = 2
                        },
                        new
                        {
                            Id = 100,
                            FirstName = "Dickens",
                            LastName = "Dickens",
                            Phonenumber = 737610,
                            Role = 1
                        });
                });

            modelBuilder.Entity("AuthorModelItemModel", b =>
                {
                    b.HasOne("NameSpace.Models.AuthorModel", null)
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NameSpace.Models.ItemModel", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NameSpace.Models.AuthorModel", b =>
                {
                    b.HasOne("NameSpace.Models.ImgModel", "Img_id")
                        .WithMany()
                        .HasForeignKey("Img_idId");

                    b.Navigation("Img_id");
                });

            modelBuilder.Entity("NameSpace.Models.UserModel", b =>
                {
                    b.HasOne("NameSpace.Models.ImgModel", "Img_id")
                        .WithMany()
                        .HasForeignKey("Img_idId");

                    b.Navigation("Img_id");
                });
#pragma warning restore 612, 618
        }
    }
}
