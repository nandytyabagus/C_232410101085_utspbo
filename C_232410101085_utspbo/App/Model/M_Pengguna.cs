﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_232410101085_utspbo.App.Model
{
    internal class M_Pengguna
    {
        [Key]
        public int id_pengguna {  get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }

    }
}
