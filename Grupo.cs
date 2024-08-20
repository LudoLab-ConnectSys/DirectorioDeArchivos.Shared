using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Grupo
    {
        [Key]
        public int id_grupo { get; set; }
        public int id_periodo { get; set; }
        public int id_instructor { get; set; }
        public string? nombre_grupo { get; set; } = string.Empty; // Este campo puede ser null
    }
}
