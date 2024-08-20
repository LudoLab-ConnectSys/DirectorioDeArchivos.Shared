using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class CrearGrupoManualParametros
    {
        public int CursoId { get; set; }
        public int PeriodoId { get; set; }
        public int InstructorId { get; set; }
        public List<int> EstudiantesSeleccionados { get; set; } = new List<int>();
        public List<HorarioGrupo> Horarios { get; set; } = new List<HorarioGrupo>();
    }
}
