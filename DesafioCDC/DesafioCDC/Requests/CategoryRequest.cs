using System.ComponentModel.DataAnnotations;

namespace DesafioCDC.Requests
{
    public class CategoryRequest
    {
        [Required]
        public string Name { get; set; }
    }
}
