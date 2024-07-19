using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Instructor
    {
        [Key]
        public int id_instructor { get; set; }
        public int id_usuario { get; set; }
    }
}
