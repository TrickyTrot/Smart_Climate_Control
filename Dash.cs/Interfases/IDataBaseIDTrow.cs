using LibraryOfDash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dash.cs.Interfases
{
    public interface IDataBaseIDTrow<T> where T: EntityBaza
    {
        int LastID();
        int FirstID();

    }
}
