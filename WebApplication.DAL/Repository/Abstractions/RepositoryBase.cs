using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WebApplication.DAL.Models;

namespace WebApplication.DAL.Repository.Abstractions
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext dataContext { get; set; }
 
        public RepositoryBase(DataContext repositoryContext)
        {
            this.dataContext = repositoryContext;
        }
 
        public IQueryable<T> FindAll()
        {
            return this.dataContext.Set<T>().AsNoTracking();
        }
 
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.dataContext.Set<T>().Where(expression).AsNoTracking();
        }
 
        public void Create(T entity)
        {
            this.dataContext.Set<T>().Add(entity);
        }
 
        public void Update(T entity)
        {
            this.dataContext.Set<T>().Update(entity);
        }
 
        public void Delete(T entity)
        {
            this.dataContext.Set<T>().Remove(entity);
        }
    }
}