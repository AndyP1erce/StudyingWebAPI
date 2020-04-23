using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication.DAL.Models;
using WebApplication.DAL.Repository.Abstractions;

namespace WebApplication.DAL.Repository
{
    public class AgencyRepository : RepositoryBase<Agency>, IAgencyRepository
    {
        public AgencyRepository(DataContext dataContext) : base(dataContext)
        {
        }
        
        public IQueryable<Agency> Exp()
        {
            return this.dataContext.Agencies.Include(a => a.Books);
        }
    }
}