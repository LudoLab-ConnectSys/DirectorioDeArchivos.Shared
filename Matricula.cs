using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Matricula
    {
        [Key]
        public int id_matricula { get; set; }
        public int id_estudiante { get; set; }
        public int id_curso { get; set; }
        public int id_periodo { get; set; }
        public int? id_grupo { get; set; }
        public DateTime fecha_inscripcion { get; set; }
    }
}
