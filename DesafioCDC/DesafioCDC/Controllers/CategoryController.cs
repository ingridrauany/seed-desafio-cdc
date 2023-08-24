using AutoMapper;
using DesafioCDC.Domain.Entities;
using DesafioCDC.Domain.Repositories;
using DesafioCDC.Domain.Requests;
using Microsoft.AspNetCore.Mvc;

namespace DesafioCDC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CategoryRequest categoryRequest)
        {
            var category = _mapper.Map<Category>(categoryRequest);
            var addedCategory = await _categoryRepository.AddAsync(category);

            var response = new
            {
                Message = "Categoria criada com sucesso",
                Category = addedCategory
            };
            return Ok(response);
        }
    }
}
