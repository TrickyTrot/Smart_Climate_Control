using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext _dbContext;

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            GC.SuppressFinalize(this);
        }

        public void Dispose()
        {
            Dispose(true);
        }
        public void Dispose(bool dispousing)
        {
            if (dispousing)
            {
                if(_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }

        public int Save()
        {
          return _dbContext.SaveChanges();
        }
    }
}
