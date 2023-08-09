using DesafioCDC.Entities;

namespace DesafioCDC.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> Add(Author author);
    }
}
