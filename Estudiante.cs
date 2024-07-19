using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Estudiante
    {
        [Key]
        public int id_estudiante { get; set; }
        public string? tipo_estudiante { get; set; } = string.Empty;
        public int id_usuario { get; set; }
        public int? id_grupo { get; set; }
        public int horas_asignadas_estudiante { get; set; }
    }
}
