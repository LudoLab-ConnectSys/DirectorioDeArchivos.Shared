using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class CursoInscritoEstudiante
    {
        public int id_curso { get; set; }
        public string nombre_curso { get; set; }
        public string nombre_periodo { get; set; }
        public string nombre_grupo { get; set; }
        public int id_periodo { get; set; }
    }
}
