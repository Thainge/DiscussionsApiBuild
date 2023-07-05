using DiscussionsApi.Data;
using DiscussionsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace DiscussionsApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DiscussionsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public DiscussionsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<DiscussionPost> All(int? filterId, string? query)
        {
            List<DiscussionPost> posts = new List<DiscussionPost>();

            if (query != null)
            {
                posts = _db.Posts
                    .Where(post =>
                        post.Title!.Contains(query!) ||
                        post.Description!.Contains(query!) ||
                        post.Author!.Contains(query!))
                    .ToList();
            }
            else
            {
                posts = _db.Posts.ToList();
            }

            if (filterId == 1)
            {
                // Sort by top rated
                posts = posts.OrderByDescending(x => x.Votes).ToList();
            }
            else if (filterId == 2)
            {
                // Sort by hot
                posts = posts.OrderByDescending(x => x.Votes).ToList();
            }
            else if (filterId == 3)
            {
                // Sort by new
                posts = posts.OrderByDescending(x => x.DateCreated).ToList();
            }

            return posts;
        }

        [HttpGet]
        public DiscussionPost? Single(int Id)
        {
            DiscussionPost? post = _db.Posts.SingleOrDefault(x => x.Id == Id);
            return post;
        }

        [HttpGet]
        public List<PostComment> Comments(int Id)
        {
            List<PostComment> commentsList = _db.Comments
                .Where(x => x.DiscussionPostId == Id)
                .ToList();
            return commentsList;
        }

        [HttpPost]
        public IActionResult CreatePost(DiscussionPost data)
        {
            DiscussionPost newData = new DiscussionPost()
            {
                Title = data.Title,
                Author = data.Author,
                AuthorImage = data.AuthorImage,
                Description = data.Description,
                DateCreated = DateTime.Now,
                Comments = 0,
                Votes = 0,
            };
            _db.Posts.Add(newData);
            _db.SaveChanges();
            return Ok(newData);
        }

        [HttpPost]
        public IActionResult CreateComment(PostComment data)
        {
            DiscussionPost? post = _db.Posts.SingleOrDefault(x => x.Id == data.DiscussionPostId);
            if (post != null)
                post.Comments++;

            PostComment newData = new PostComment()
            {
                DiscussionPostId = data.DiscussionPostId,
                Comment = data.Comment,
                Author = data.Author,
                AuthorImage = data.AuthorImage,
                PostedDate = DateTime.Now,
            };

            // Notify owner of comment
            UserNotification newNotification = new UserNotification()
            {
                DiscussionPostId = data.DiscussionPostId,
                Message = data.Comment,
                User = data.Author,
                DatePosted = DateTime.Now,
                UserImage = data.AuthorImage,
            };

            _db.Comments.Add(newData);
            _db.Notifications.Add(newNotification);
            _db.SaveChanges();
            return Ok(newData);
        }

        [HttpGet]
        public IActionResult Upvote(int Id, string User)
        {
            PostVoter? postVoter = _db.PostVoters.SingleOrDefault((x) => x.User == User && x.DiscussionPostId == Id);
            if (postVoter == null)
            {
                var voteData = new PostVoter()
                {
                    DiscussionPostId = Id,
                    User = User,
                    Downvoted = false,
                    Upvoted = false
                };
                postVoter = voteData;
                _db.PostVoters.Add(voteData);
            }

            DiscussionPost? post = _db.Posts.SingleOrDefault(x => x.Id == Id);

            // Downvote is currently hit, up by 2
            if (postVoter.Upvoted == false && postVoter.Downvoted == true && post != null)
            {
                postVoter.Upvoted = true;
                postVoter.Downvoted = false;
                post.Votes = post.Votes + 2;
                _db.SaveChanges();
                return Ok();
            }

            // Upvote is currently hit, remove it
            if (postVoter.Upvoted == true && postVoter.Downvoted == false && post != null)
            {
                postVoter.Upvoted = false;
                postVoter.Downvoted = false;
                post.Votes = post.Votes - 1;
                _db.SaveChanges();
                return Ok();
            }

            // New vote
            if (postVoter.Upvoted == false && postVoter.Downvoted == false && post != null)
            {
                postVoter.Upvoted = true;
                postVoter.Downvoted = false;
                post.Votes++;
                _db.SaveChanges();
                return Ok();
            }
            return Ok();
        }

        [HttpGet]
        public IActionResult Downvote(int Id, string User)
        {
            PostVoter? postVoter = _db.PostVoters.SingleOrDefault((x) => x.User == User && x.DiscussionPostId == Id);
            if (postVoter == null)
            {
                var voteData = new PostVoter()
                {
                    DiscussionPostId = Id,
                    User = User,
                    Downvoted = false,
                    Upvoted = false
                };
                postVoter = voteData;
                _db.PostVoters.Add(voteData);
            }

            DiscussionPost? post = _db.Posts.SingleOrDefault(x => x.Id == Id);

            // Upvote is currently hit, up by 2
            if (postVoter.Upvoted == true && postVoter.Downvoted == false && post != null)
            {
                postVoter.Upvoted = false;
                postVoter.Downvoted = true;
                post.Votes = post.Votes - 2;
                _db.SaveChanges();
                return Ok();
            }

            // Downvote is currently hit, remove it
            if (postVoter.Upvoted == false && postVoter.Downvoted == true && post != null)
            {
                postVoter.Upvoted = false;
                postVoter.Downvoted = false;
                post.Votes = post.Votes + 1;
                _db.SaveChanges();
                return Ok();
            }

            // New vote
            if (postVoter.Upvoted == false && postVoter.Downvoted == false && post != null)
            {
                postVoter.Upvoted = false;
                postVoter.Downvoted = true;
                post.Votes--;
                _db.SaveChanges();
                return Ok();
            }
            return Ok();
        }

        [HttpGet]
        public List<UserNotification> Notifications(string User) { 
            List<UserNotification> userNotifications = _db.Notifications
                .Where(u => u.User == User)
                .ToList();
            return userNotifications;
        }

        [HttpDelete]
        public IActionResult ClearNotification(int Id)
        {
            var foundNotification = _db.Notifications
                .Where(u => u.Id == Id)
                .SingleOrDefault();
            if (foundNotification != null)
            {
                _db.Notifications.Remove(foundNotification);
                _db.SaveChanges();
            }
            return Ok();
        }
    }
}