using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class InstructorConDetalles
    {
        public int id_instructor { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string correo_usuario { get; set; }
        public List<int> id_cursos { get; set; }
        public List<int> id_periodos { get; set; }
        public List<string> cursos { get; set; }
        public List<string> periodos { get; set; }

        public List<HorarioPreferenteInstructor> horariosPreferentes { get; set; }
        public List<string>? grupos { get; set; }
    }
}
