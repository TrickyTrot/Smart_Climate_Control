using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDash
{   [Table("Devises")]
    public class Devise :  EntityBaza
    {
        public string Devise_name { get; set; }
        public string Purp { get; set; }
    }
}
