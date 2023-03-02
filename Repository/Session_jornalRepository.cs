using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;
using LibraryOfDash;
using System.Data.Entity;

namespace Repository
{
    public class Session_jornalRepository : Reposiory<Session_journal>, ISession_journalRepository
    {
        public Session_jornalRepository(DbContext dbContex) : base(dbContex)
        {
        }
    }
}
