using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class HorariosInstructor
    {
        public int CursoId { get; set; }
        public int PeriodoId { get; set; }
        public List<HorarioPreferenteInstructor> Horarios { get; set; } = new List<HorarioPreferenteInstructor>();
    }
}
