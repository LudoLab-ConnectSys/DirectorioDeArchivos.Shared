using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class PeriodoConCursoInfo
    {
        public int id_periodo { get; set; }
        public string? nombre_periodo { get; set; }
        public string? fecha_inicio_periodo { get; set; }
        public string? fecha_fin_periodo { get; set; }
        public int duracion_periodo_horas { get; set; }
        public string? nombre_curso { get; set; }
        public string? nombre_certificado { get; set; }
        public int id_ListaPeriodo { get; set; }
        public int id_curso { get; set; }
    }
}
