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
    public class IndicationServise : EntityServise<Indication>, IIndicationServise
    {
        public IndicationServise(IRepository<Indication> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
