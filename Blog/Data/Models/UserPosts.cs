using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Data.Models
{
    public class UserPosts
    {
        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }

        [NotMapped]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }

        [NotMapped]
        public virtual Post Post { get; set; }
    }
}
