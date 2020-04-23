using WebApplication.DAL.Models;
using WebApplication.DAL.Repository.Abstractions;

namespace WebApplication.DAL.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository 
    {
        public BookRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}