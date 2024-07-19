using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Horario
    {
        [Key]
        public int id_horario { get; set; }
        public int id_grupo { get; set; }
        public string? dia_semana { get; set; } = string.Empty;
        public TimeSpan hora_inicio { get; set; }
        public TimeSpan hora_fin { get; set; }
    }
}
