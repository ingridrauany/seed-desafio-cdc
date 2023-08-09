using DesafioCDC.DataAccess;
using DesafioCDC.Entities;

namespace DesafioCDC.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _dbContext;

        public AuthorRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Author> Add(Author author)
        {
            _dbContext.Authors.Add(author);
            await _dbContext.SaveChangesAsync();
            return author;
        }
    }
}
