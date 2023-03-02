using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDash
{
    [Table("Users")]
    public class User : EntityBaza
    {
        public string User_name { get; set; }
        public string Password { get; set; }
    }
}
