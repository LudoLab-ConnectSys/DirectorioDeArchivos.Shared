using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Periodo
    {
        [Key]
        public int id_periodo { get; set; }
        public int id_ListaPeriodo { get; set; }
        public string? fecha_inicio_periodo { get; set; } = string.Empty;
        public string? fecha_fin_periodo { get; set; } = string.Empty;
        public int duracion_periodo_horas { get; set; }
        public int id_curso { get; set; }
        public bool activo { get; set; } = true; // Valor por defecto en el modelo C#
    }
}
