using LibraryOfDash;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Reposiory<T> : IRepository<T> where T : EntityBaza
    {
        protected DbContext _dbContext;
        public Reposiory(DbContext dbContex)
        {
            _dbContext = dbContex;
        }

        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
           _dbContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).AsEnumerable();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State= EntityState.Modified;
        }
    }
}
