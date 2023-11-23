using Blog.Data.Models;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Blog.Data.Common;
using System.Linq;
namespace Blog.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly IRepository repo;

        public PostService(IRepository repo)
        {
            this.repo = repo;
        }
        public async Task<IEnumerable<PostViewModel>> GetAllAsync()
        {
            List<Post> posts = await repo.AllReadonly<Post>().ToListAsync();

            return posts.Select(p => new PostViewModel()
            {
                Id = p.Id,
                Title = p.Title,
                PublishDate = p.PublishDate,
                Author = p.Author,
                Content = p.Content,
            }).ToList();
        }
    }
}
