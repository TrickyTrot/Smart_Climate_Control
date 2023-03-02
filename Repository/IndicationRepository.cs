using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryOfDash;

namespace Repository
{
    public class IndicationRepository : Reposiory<Indication>, IIndicationRepository
    {
        public IndicationRepository(DbContext dbContex) : base(dbContex)
        {
        }
    }
}
