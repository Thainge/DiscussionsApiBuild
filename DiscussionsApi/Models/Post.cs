using DiscussionsApi.Models;
using static DiscussionsApi.Models.DiscussionPost;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiscussionsApi.Models
{
    public class DiscussionPost
    {
        [Key]
        public int Id { get; set; }
        public int? Votes { get; set; }
        public string? Author { get; set; }
        public string? AuthorImage { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? Comments { get; set; }
    }

    public class PostComment
    {
        [Key]
        public int Id { get; set; }
        public string? Comment { get; set; }
        public string? Author { get; set; }
        public string? AuthorImage { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? DiscussionPostId { get; set; }
    }

    public class PostVoter
    {
        [Key]
        public int Id { get; set; }
        public int? DiscussionPostId { get; set; }
        public string? User { get; set; }
        public bool? Upvoted { get; set; }
        public bool? Downvoted { get; set; }
    }

    public class UserNotification
    {
        [Key]
        public int Id { get; set; }
        public string? User { get; set; }
        public string? UserImage { get; set; }
        public string? Message { get; set; }
        public DateTime? DatePosted { get; set; }
        public int? DiscussionPostId { get; set; }
    }
}