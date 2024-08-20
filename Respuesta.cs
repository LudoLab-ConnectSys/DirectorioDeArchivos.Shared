using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Respuesta
    {
        [Key]
        public int id_respuesta { get; set; }
        public int id_estudiante { get; set; }
        public int id_pregunta { get; set; }
        public int id_opcion { get; set; }
    }
}
