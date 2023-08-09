using DesafioCDC.Entities;
using DesafioCDC.Repositories;
using DesafioCDC.Validations;
using Microsoft.AspNetCore.Mvc;

namespace DesafioCDC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Author author)
        {
            var validator = new EmailValidaton();
            if (author == null && validator.IsValidEmail(author.Email))
            {
                return BadRequest();
            }

            var addedAuthor = await _authorRepository.Add(author);

            var response = new
            {
                Message = "Author criado com sucesso",
                Author = addedAuthor
            };
            return Ok(response);
        }
    }
}
