﻿using DesafioCDC.DataAccess;
using DesafioCDC.Entities;

namespace DesafioCDC.Repositories
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {
    }

    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly DataContext _dbContext;

        public AuthorRepository(DataContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
