using AutoMapper;
using DesafioCDC.Entities;
using DesafioCDC.Repositories;
using DesafioCDC.Requests;
using DesafioCDC.Validations;
using Microsoft.AspNetCore.Mvc;

namespace DesafioCDC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorController(IAuthorRepository authorRepository, 
            IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AuthorRequest authorRequest)
        {
            var validator = new EmailValidaton();
            if (authorRequest == null && validator.IsValidEmail(authorRequest.Email))
            {
                return BadRequest();
            }

            var author = _mapper.Map<Author>(authorRequest);
            var addedAuthor = await _authorRepository.AddAsync(author);

            var response = new
            {
                Message = "Author criado com sucesso",
                Author = addedAuthor
            };
            return Ok(response);
        }
    }
}
