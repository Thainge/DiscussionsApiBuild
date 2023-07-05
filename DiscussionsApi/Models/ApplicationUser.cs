using System.ComponentModel.DataAnnotations;

namespace DiscussionsApi.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? ImageText { get; set; }
    }
}
