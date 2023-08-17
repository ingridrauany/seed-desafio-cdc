using DesafioCDC.DataAccess;
using DesafioCDC.Entities;

namespace DesafioCDC.Repositories
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
