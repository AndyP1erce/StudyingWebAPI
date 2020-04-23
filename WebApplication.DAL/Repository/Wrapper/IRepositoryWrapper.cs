using WebApplication.DAL.Repository.Abstractions;

namespace WebApplication.DAL.Repository.Wrapper
{
    public interface IRepositoryWrapper
    {
        IBookRepository Book { get; }
        IAuthorRepository Author { get; }
        IAgencyRepository Agency { get; }
        
        void Save();
    }
}