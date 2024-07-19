using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class RegistrarHorarioInstructor
    {
        public int id_instructor { get; set; }
        public int id_curso { get; set; }
        public int id_periodo { get; set; }
        public List<HorarioPreferenteInstructor> horarios { get; set; }
    }
}
