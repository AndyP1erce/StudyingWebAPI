using System.Linq;
using WebApplication.DAL.Models;

namespace WebApplication.DAL.Repository.Abstractions
{
    public interface IAuthorRepository : IRepositoryBase<Author>
    {
        public IQueryable<Author> Exp();
    }
}