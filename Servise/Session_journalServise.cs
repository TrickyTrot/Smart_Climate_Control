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
    public class Session_journalServise : EntityServise<Session_journal>, ISession_journalServise
    {
        public Session_journalServise(IRepository<Session_journal> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
