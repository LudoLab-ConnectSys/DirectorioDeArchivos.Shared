using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Rol  // Clase Rol
    {
        public int RolId { get; set; }  // Primary key
        public string NombreRol { get; set; }
        public bool estadoActivo { get; set; }
    }
}
