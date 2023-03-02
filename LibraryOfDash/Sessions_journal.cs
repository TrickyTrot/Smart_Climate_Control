using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDash
{
    [Table("Sessions_journal")]
    public class Session_journal : EntityBaza
    {
        public string Session_time { get; set; }
        public int Id_User { get; set; }
    }
}
