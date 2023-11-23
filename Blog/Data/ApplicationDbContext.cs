using Blog.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Blog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<UserPosts> UserPosts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserPosts>()
                   .HasKey(x => new { x.ApplicationUserId, x.PostId });

            builder.Entity<Post>()
                   .HasData(new Post
                   {
                       Id = 1,
                       Title = "Summer is the worst",
                       Author = "Matey Minev",
                       PublishDate = DateTime.Now,
                       Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",


                   });

            base.OnModelCreating(builder);
        }
    }
}