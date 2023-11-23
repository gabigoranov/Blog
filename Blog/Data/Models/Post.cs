using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Data.Models
{
    public class Post
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public string Content { get; set; }

        public IEnumerable<UserPosts> UserPosts { get; set; } = new List<UserPosts>();
    }
}
