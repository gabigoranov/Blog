using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(14)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
