using DesafioCDC.Domain.Entities;
using DesafioCDC.Validations;
using System.ComponentModel.DataAnnotations;

namespace DesafioCDC.Domain.Requests
{
    public class CategoryRequest
    {
        [Required]
        [CustomIsUniqueValidation("Name", typeof(Category))]
        public string Name { get; set; }
    }
}
