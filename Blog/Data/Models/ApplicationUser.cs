using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey(nameof(Post))]
        public IEnumerable<UserPosts> UserPosts { get; set; } = new List<UserPosts>();
    }
}
