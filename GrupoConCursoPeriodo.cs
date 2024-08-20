using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class GrupoConCursoPeriodo
    {
        public int id_grupo { get; set; }
        public string nombre_grupo { get; set; }
        public string nombre_periodo { get; set; }
        public string fecha_inicio_periodo { get; set; }
        public string fecha_fin_periodo { get; set; }
        public string nombre_curso { get; set; }
    }
}
