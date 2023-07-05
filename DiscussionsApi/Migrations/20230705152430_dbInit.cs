using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiscussionsApi.Migrations
{
    /// <inheritdoc />
    public partial class dbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscussionPostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscussionPostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Votes = table.Column<int>(type: "int", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostVoters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscussionPostId = table.Column<int>(type: "int", nullable: true),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Upvoted = table.Column<bool>(type: "bit", nullable: true),
                    Downvoted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostVoters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Author", "AuthorImage", "Comment", "DiscussionPostId", "PostedDate" },
                values: new object[,]
                {
                    { 1, "Swiggity Swagger", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 1, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2125) },
                    { 2, "Breezy", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 1, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2128) },
                    { 3, "Llorence", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 1, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2131) },
                    { 4, "Mystic", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 1, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2132) },
                    { 5, "Swiggity Swagger", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 2, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2134) },
                    { 6, "Breezy", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 2, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2136) },
                    { 7, "Llorence", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 2, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2138) },
                    { 8, "Mystic", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 2, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2140) },
                    { 9, "Swiggity Swagger", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 3, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2142) },
                    { 10, "Breezy", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 3, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2144) },
                    { 11, "Llorence", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 3, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2146) },
                    { 12, "Mystic", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 3, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2148) },
                    { 13, "Swiggity Swagger", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2150) },
                    { 14, "Breezy", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2151) },
                    { 15, "Llorence", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2153) },
                    { 16, "Mystic", null, "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.", 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2155) }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "AuthorImage", "Comments", "DateCreated", "Description", "Title", "Votes" },
                values: new object[,]
                {
                    { 1, "Llorence", null, 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(1976), "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.", "My thoughts on Rainbow Six Siege", 75 },
                    { 2, "Breezy", null, 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2019), "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.", "My thoughts on Rainbow Six Siege", 12 },
                    { 3, "Swiggity Swagger", null, 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2022), "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.", "My thoughts on Rainbow Six Siege", 134 },
                    { 4, "Mystic", null, 4, new DateTime(2023, 7, 5, 11, 24, 30, 513, DateTimeKind.Local).AddTicks(2024), "For decades Team Rainbow has been the shield against the worst global threats.Now they face the\r\n                  greatest terror yet = a mutating alien parasite known as the Archæans.\r\n\r\n                  It’s now time for you and your teammates to breach into the alien containment zone and face this\r\n                  new\r\n                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.\r\n\r\n                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.\r\n                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP\r\n                  boosters\r\n                  to\r\n                  amp up your game as you play alone or with friends.\r\n\r\n                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.\r\n\r\n                  Rainbow Six Siege Players Benefit Even More\r\n\r\n                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join\r\n                  REACT\r\n                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege\r\n                  and\r\n                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear\r\n                  sets\r\n                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20\r\n                  Operators featured in Extraction for use in Rainbow Six Siege.", "My thoughts on Rainbow Six Siege", 37 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "PostVoters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
