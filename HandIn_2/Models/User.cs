using System.ComponentModel.DataAnnotations;

namespace HandIn_2.Models
{
    public class User
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}