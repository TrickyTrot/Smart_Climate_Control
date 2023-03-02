using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;
using LibraryOfDash;
using Servise.Interfaces;

namespace Servise
{
    public class Devise_work_journalServise : EntityServise<Devises_work_journal>, IDevise_work_journalServise
    {
        public Devise_work_journalServise(IRepository<Devises_work_journal> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
