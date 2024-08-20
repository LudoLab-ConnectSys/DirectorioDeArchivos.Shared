using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class HorasModel
    {
        public int id_instructor { get; set; }
        public int id_periodo { get; set; } // Si necesitas periodo también, sino puedes omitir
        public int horas_ganadas_instructor { get; set; }
    }
}
