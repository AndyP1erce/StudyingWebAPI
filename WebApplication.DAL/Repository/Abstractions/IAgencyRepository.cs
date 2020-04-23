using System.Linq;
using WebApplication.DAL.Models;

namespace WebApplication.DAL.Repository.Abstractions
{
    public interface IAgencyRepository : IRepositoryBase<Agency>
    {
        public IQueryable<Agency> Exp();
    }
}