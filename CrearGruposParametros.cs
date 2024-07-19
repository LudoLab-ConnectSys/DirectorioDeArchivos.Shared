using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class CrearGruposParametros
    {
        public int PeriodoId { get; set; }
        public int CursoId { get; set; }
        public int NumeroEstudiantesPorGrupo { get; set; }
        public int NumeroMaximoGruposPorInstructor { get; set; }
        public int HorasPorClase { get; set; }
    }
}
