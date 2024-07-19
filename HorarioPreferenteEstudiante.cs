using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class HorarioPreferenteEstudiante
    {
        [Key]
        public int id_horario_preferente_estudiante { get; set; }
        public int id_estudiante { get; set; }
        public string dia_semana { get; set; }
        public TimeSpan hora_inicio { get; set; }
        public TimeSpan hora_fin { get; set; }
    }
}
