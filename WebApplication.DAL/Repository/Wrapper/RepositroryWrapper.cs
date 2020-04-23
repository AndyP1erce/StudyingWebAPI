using WebApplication.DAL.Models;
using WebApplication.DAL.Repository.Abstractions;

namespace WebApplication.DAL.Repository.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private DataContext _dataContext;
        private IBookRepository _book;
        private IAuthorRepository _author;
        private IAgencyRepository _agency;
 
        public IBookRepository Book 
        {
            get 
            {
                if (_book == null)
                {
                    _book = new BookRepository(_dataContext);
                }
 
                return _book;
            }
        }
 
        public IAuthorRepository Author 
        {
            get 
            {
                if (_author == null)
                {
                    _author = new AuthorRepository(_dataContext);
                }
 
                return _author;
            }
        }
        
        public IAgencyRepository Agency 
        {
            get 
            {
                if (_agency == null)
                {
                    _agency = new AgencyRepository(_dataContext);
                }
 
                return _agency;
            }
        }
 
        public RepositoryWrapper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
 
        public void Save()
        {
            _dataContext.SaveChanges();
        }
    }
}