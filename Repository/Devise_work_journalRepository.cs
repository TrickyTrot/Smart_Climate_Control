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
    public class Devise_work_journalRepository : Reposiory<Devises_work_journal>, IDev_W_JournalRepository
    {
        public Devise_work_journalRepository(DbContext dbContex) : base(dbContex)
        {
        }
    }
}
