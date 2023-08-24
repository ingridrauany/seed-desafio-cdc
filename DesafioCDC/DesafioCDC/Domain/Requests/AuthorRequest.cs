using System.ComponentModel.DataAnnotations;

namespace DesafioCDC.Domain.Requests
{
    public class AuthorRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(400)]
        public string Description { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
