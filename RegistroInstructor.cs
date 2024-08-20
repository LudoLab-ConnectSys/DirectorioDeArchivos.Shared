using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class RegistroInstructor
    {
        [Key]
        public int id_registro_instructor { get; set; }
        public int id_instructor { get; set; }
        public int id_curso { get; set; }
        public int id_periodo { get; set; }
        public int? id_grupo { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
