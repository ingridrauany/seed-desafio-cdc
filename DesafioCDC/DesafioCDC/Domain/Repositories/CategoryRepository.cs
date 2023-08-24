using DesafioCDC.DataAccess;
using DesafioCDC.Domain.Entities;

namespace DesafioCDC.Domain.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
    }

    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly DataContext _dbContext;

        public CategoryRepository(DataContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
