using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_232410101085_utspbo.App.Model
{
    internal class M_Buku
    {
        [Key]
        public int id_buku { get; set; }
        [Required]
        public string judul_buku { get; set; }
        [Required]
        public string penerbit { get; set; }
        [Required]
        public int tahun_terbit { get; set; }
    }
}
