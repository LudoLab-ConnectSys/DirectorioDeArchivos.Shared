using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Curso
    {
        [Key]
        public int id_curso { get; set; }
        public string? nombre_curso { get; set; } = string.Empty;
        public string? tipo_curso { get; set; } = string.Empty;
        public int horas { get; set; }
        public int? Conjunto_horas_id_conjunto_horas { get; set; }
        public int Modalidad_id_modalidad { get; set; }
    }
}
