﻿// <auto-generated />
using System;
using DiscussionsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiscussionsApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiscussionsApi.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DiscussionsApi.Models.DiscussionPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Comments")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Votes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Llorence",
                            Comments = 4,
                            DateCreated = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(91),
                            Description = "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.",
                            Title = "My thoughts on Rainbow Six Siege",
                            Votes = 75
                        },
                        new
                        {
                            Id = 2,
                            Author = "Breezy",
                            Comments = 4,
                            DateCreated = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(133),
                            Description = "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.",
                            Title = "My thoughts on Rainbow Six Siege",
                            Votes = 12
                        },
                        new
                        {
                            Id = 3,
                            Author = "Swiggity Swagger",
                            Comments = 4,
                            DateCreated = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(136),
                            Description = "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.",
                            Title = "My thoughts on Rainbow Six Siege",
                            Votes = 134
                        },
                        new
                        {
                            Id = 4,
                            Author = "Mystic",
                            Comments = 4,
                            DateCreated = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(138),
                            Description = "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.",
                            Title = "My thoughts on Rainbow Six Siege",
                            Votes = 37
                        });
                });

            modelBuilder.Entity("DiscussionsApi.Models.PostComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DiscussionPostId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PostedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Swiggity Swagger",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 1,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(259)
                        },
                        new
                        {
                            Id = 2,
                            Author = "Breezy",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 1,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(263)
                        },
                        new
                        {
                            Id = 3,
                            Author = "Llorence",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 1,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(265)
                        },
                        new
                        {
                            Id = 4,
                            Author = "Mystic",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 1,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(267)
                        },
                        new
                        {
                            Id = 5,
                            Author = "Swiggity Swagger",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 2,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(269)
                        },
                        new
                        {
                            Id = 6,
                            Author = "Breezy",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 2,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(271)
                        },
                        new
                        {
                            Id = 7,
                            Author = "Llorence",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 2,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(273)
                        },
                        new
                        {
                            Id = 8,
                            Author = "Mystic",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 2,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(275)
                        },
                        new
                        {
                            Id = 9,
                            Author = "Swiggity Swagger",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 3,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(277)
                        },
                        new
                        {
                            Id = 10,
                            Author = "Breezy",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 3,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(279)
                        },
                        new
                        {
                            Id = 11,
                            Author = "Llorence",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 3,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(281)
                        },
                        new
                        {
                            Id = 12,
                            Author = "Mystic",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 3,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(283)
                        },
                        new
                        {
                            Id = 13,
                            Author = "Swiggity Swagger",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 4,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(284)
                        },
                        new
                        {
                            Id = 14,
                            Author = "Breezy",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 4,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(286)
                        },
                        new
                        {
                            Id = 15,
                            Author = "Llorence",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 4,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(288)
                        },
                        new
                        {
                            Id = 16,
                            Author = "Mystic",
                            Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                            DiscussionPostId = 4,
                            PostedDate = new DateTime(2023, 7, 5, 10, 40, 21, 824, DateTimeKind.Local).AddTicks(290)
                        });
                });

            modelBuilder.Entity("DiscussionsApi.Models.PostVoter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DiscussionPostId")
                        .HasColumnType("int");

                    b.Property<bool?>("Downvoted")
                        .HasColumnType("bit");

                    b.Property<bool?>("Upvoted")
                        .HasColumnType("bit");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PostVoters");
                });

            modelBuilder.Entity("DiscussionsApi.Models.UserNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DiscussionPostId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
