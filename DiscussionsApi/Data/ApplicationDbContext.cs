using DiscussionsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace DiscussionsApi.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<DiscussionPost> Posts { get; set; }
        public DbSet<PostComment> Comments { get; set; }
        public DbSet<PostVoter> PostVoters { get; set; }
        public DbSet<UserNotification> Notifications { get; set; }

        // Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed discussions data
            modelBuilder.Entity<DiscussionPost>().HasData(
                new DiscussionPost()
                {
                    Id = 1,
                    Votes = 75,
                    Author = "Llorence",
                    Title = "My thoughts on Rainbow Six Siege",
                    Description = @"For decades Team Rainbow has been the shield against the worst global threats.Now they face the
                  greatest terror yet = a mutating alien parasite known as the Archæans.

                  It’s now time for you and your teammates to breach into the alien containment zone and face this
                  new
                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.

                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.
                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP
                  boosters
                  to
                  amp up your game as you play alone or with friends.

                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.

                  Rainbow Six Siege Players Benefit Even More

                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join
                  REACT
                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege
                  and
                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear
                  sets
                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20
                  Operators featured in Extraction for use in Rainbow Six Siege.",
                    DateCreated = DateTime.Now,
                    Comments = 4
                },
                new DiscussionPost()
                {
                    Id = 2,
                    Votes = 12,
                    Author = "Breezy",
                    Title = "My thoughts on Rainbow Six Siege",
                    Description = @"For decades Team Rainbow has been the shield against the worst global threats.Now they face the
                  greatest terror yet = a mutating alien parasite known as the Archæans.

                  It’s now time for you and your teammates to breach into the alien containment zone and face this
                  new
                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.

                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.
                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP
                  boosters
                  to
                  amp up your game as you play alone or with friends.

                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.

                  Rainbow Six Siege Players Benefit Even More

                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join
                  REACT
                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege
                  and
                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear
                  sets
                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20
                  Operators featured in Extraction for use in Rainbow Six Siege.",
                    DateCreated = DateTime.Now,
                    Comments = 4
                },
                new DiscussionPost()
                {
                    Id = 3,
                    Votes = 134,
                    Author = "Swiggity Swagger",
                    Title = "My thoughts on Rainbow Six Siege",
                    Description = @"For decades Team Rainbow has been the shield against the worst global threats.Now they face the
                  greatest terror yet = a mutating alien parasite known as the Archæans.

                  It’s now time for you and your teammates to breach into the alien containment zone and face this
                  new
                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.

                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.
                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP
                  boosters
                  to
                  amp up your game as you play alone or with friends.

                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.

                  Rainbow Six Siege Players Benefit Even More

                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join
                  REACT
                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege
                  and
                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear
                  sets
                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20
                  Operators featured in Extraction for use in Rainbow Six Siege.",
                    DateCreated = DateTime.Now,
                    Comments = 4
                },
                new DiscussionPost()
                {
                    Id = 4,
                    Votes = 37,
                    Author = "Mystic",
                    Title = "My thoughts on Rainbow Six Siege",
                    Description = @"For decades Team Rainbow has been the shield against the worst global threats.Now they face the
                  greatest terror yet = a mutating alien parasite known as the Archæans.

                  It’s now time for you and your teammates to breach into the alien containment zone and face this
                  new
                  threat head - on in Rainbow Six Extraction releasing ON SALE from today June 15th to June 23rd.

                  Rainbow Six Extraction Standard Edition includes the Base Game and the Buddy Pass.
                  The Deluxe Edition includes the Base Game the Buddy Pass as well as 3 Epic gear sets and XP
                  boosters
                  to
                  amp up your game as you play alone or with friends.

                  No matter which edition you pick up you’ll get extra benefits in Rainbow Six Extraction.

                  Rainbow Six Siege Players Benefit Even More

                  Rainbow Six Extraction stars 20 Operators recruited from the ranks of Rainbow Six Siege to join
                  REACT
                  the organization led by Mira Ash and Thermite to confront the Archæans.Players who own Siege
                  and
                  purchase Extraction will be granted the United Front bundle which contains four exclusive gear
                  sets
                  split between the two games.Furthermore the United Front bundle will immediately unlock all 20
                  Operators featured in Extraction for use in Rainbow Six Siege.",
                    DateCreated = DateTime.Now,
                    Comments = 4
                }
            );

            // Seed discussions data
            modelBuilder.Entity<PostComment>().HasData(
                new PostComment
                {
                    Id = 1,
                    DiscussionPostId = 1,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Swiggity Swagger",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 2,
                    DiscussionPostId = 1,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Breezy",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 3,
                    DiscussionPostId = 1,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Llorence",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 4,
                    DiscussionPostId = 1,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Mystic",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 5,
                    DiscussionPostId = 2,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Swiggity Swagger",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 6,
                    DiscussionPostId = 2,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Breezy",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 7,
                    DiscussionPostId = 2,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Llorence",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 8,
                    DiscussionPostId = 2,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Mystic",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 9,
                    DiscussionPostId = 3,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Swiggity Swagger",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 10,
                    DiscussionPostId = 3,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Breezy",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 11,
                    DiscussionPostId = 3,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Llorence",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 12,
                    DiscussionPostId = 3,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Mystic",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 13,
                    DiscussionPostId = 4,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Swiggity Swagger",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 14,
                    DiscussionPostId = 4,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Breezy",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 15,
                    DiscussionPostId = 4,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Llorence",
                    PostedDate = DateTime.Now
                },
                new PostComment
                {
                    Id = 16,
                    DiscussionPostId = 4,
                    Comment = "I am split between the two games. Furthermore the United Front bundle will immediately unlock all 20 Operators featured in Extraction for use in Rainbow Six Siege.",
                    Author = "Mystic",
                    PostedDate = DateTime.Now
                }
            );
        }
    }
}