using LibraryOfDash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Servise.Interfaces
{ 
    public interface IEntityServise<T> : IServise where T : EntityBaza
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
        void Create(T entity);
        void CreateMultiple(IEnumerable<T> entities);
        void Delete(T entity);
        void Update(T entity);
    }
}
