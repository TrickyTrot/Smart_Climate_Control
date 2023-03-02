using LibraryOfDash;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Repository
{
    public class DeviseRepository : Reposiory<Devise>, IDeviseRepository
    {
        public DeviseRepository(DbContext dbContex) : base(dbContex)
        {
        }
    }
}
