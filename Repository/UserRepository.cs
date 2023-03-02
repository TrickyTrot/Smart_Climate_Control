using LibraryOfDash;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : Reposiory<User> ,IUserRepository
    {
        public UserRepository(DbContext dbContex) : base(dbContex)
        {
        }
    }
}
