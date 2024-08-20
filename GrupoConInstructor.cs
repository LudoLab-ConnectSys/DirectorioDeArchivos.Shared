using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class GrupoConInstructor
    {
        public int id_grupo { get; set; }
        public int id_periodo { get; set; }
        public int id_instructor { get; set; }
        public string nombre_instructor { get; set; }
    }
}
