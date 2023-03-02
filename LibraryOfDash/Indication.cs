using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDash
{
    [Table("Indications")]
    public class Indication : EntityBaza
    {
        public int Id_rec { get; set; }
        public int Id_devise { get; set; }
        public string Time_indic { get; set; }
        public int Value { get; set; }
    }
}
