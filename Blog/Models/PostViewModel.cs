using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class PostViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
