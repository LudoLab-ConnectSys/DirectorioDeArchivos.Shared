using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class RegistrarHorarioEstudiante
    {
        public int id_estudiante { get; set; }
        public int id_curso { get; set; }
        public int id_periodo { get; set; }
        public List<HorarioPreferenteEstudiante> horarios { get; set; }
    }
}
