using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDash
{
    [Table("Devises_work_journal")]
    public class Devises_work_journal : EntityBaza
    {
        public string Start_time { get; set; }
        public string End_time { get; set; }
    }
}
