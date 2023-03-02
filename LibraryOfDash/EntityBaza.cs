﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOfDash
{
   public class EntityBaza
    {
        [Key]
        [Index] 
        public int Id { get; set; }
        public string CreationDate { get; set; }
    }
}
