using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class CursoConPeriodoActivo
    {
        public int id_curso { get; set; }
        public string nombre_curso { get; set; }
        public int id_periodo { get; set; }
        public string nombre_periodo { get; set; }
        public bool activo { get; set; } = true; // Valor por defecto en el modelo C#
    }
}
