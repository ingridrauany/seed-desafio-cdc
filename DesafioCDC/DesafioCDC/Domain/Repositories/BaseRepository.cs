using DesafioCDC.DataAccess;
using DesafioCDC.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioCDC.Domain.Repositories
{
    public interface IBaseRepository<T>
    {
        Task<T> AddAsync(T entity);
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DataContext Context;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(DataContext dbContext)
        {
            Context = dbContext;
            DbSet = Context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }
    }
}
