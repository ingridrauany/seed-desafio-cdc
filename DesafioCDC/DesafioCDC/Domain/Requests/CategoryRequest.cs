using System.ComponentModel.DataAnnotations;

namespace DesafioCDC.Domain.Requests
{
    public class CategoryRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
