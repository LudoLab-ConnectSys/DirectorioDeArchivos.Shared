using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class UsuarioRol
    {

        public int UsuarioId { get; set; }
        public int RolId { get; set; }
        public DateTime FechaAsignacion { get; set; } = DateTime.Now;
        public bool estadoActivo { get; set; } = true;
    }
}
