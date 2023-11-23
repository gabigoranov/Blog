using Blog.Models;

namespace Blog.Services.Posts
{
    public interface IPostService
    {
        Task<IEnumerable<PostViewModel>> GetAllAsync();
    }
}
