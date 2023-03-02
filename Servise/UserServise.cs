using LibraryOfDash;
using Repository.Interfaces;
using Servise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servise
{
    public class UserServise : EntityServise<User>, IUserServise
    {
        public UserServise(IUserRepository repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
