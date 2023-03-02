using LibraryOfDash;
using Servise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;

namespace Servise
{
    public class DeviseServise : EntityServise<Devise>, IDeviseServise
    {
        public DeviseServise(IRepository<Devise> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
