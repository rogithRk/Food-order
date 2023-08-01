
using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class Field
    {
        [Required]
        [MaxLength(13)]
        public string Username  { get; set; }
        [Key]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
