using LibraryOfDash;
using Repository.Interfaces;
using Servise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Servise
{
    public class EntityServise<T> : IEntityServise<T> where T : EntityBaza
    {
        IRepository<T> _repository;
        IUnitOfWork _unitOfWork;

        public EntityServise(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }


        public void Create(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            
            _repository.Create(entity);
            _unitOfWork.Save();
        }

        public void CreateMultiple(IEnumerable<T> entities)
        {
            if (entities == null) throw new ArgumentNullException("entities");
            if (!entities.Any()) throw new Exception("Последовательность не содержит элементов");
            foreach (T entity in entities)
            {
                _repository.Create(entity);
            }
            _unitOfWork.Save();
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
           return _repository.GetAll().ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetAll(predicate).ToList();
        }

        public T GetById(int id)
        {
           return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Save();
        }
    }
}
