using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication.DAL.Models;
using WebApplication.DAL.Repository.Abstractions;

namespace WebApplication.DAL.Repository
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IQueryable<Author> Exp()
        {
            return this.dataContext.Authors.Include(b => b.Books);
        }
    }
}