using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class InstructorUpdateModel
    {
        public int id_instructor { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string cedula_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string celular_usuario { get; set; }
        public string telefono_usuario { get; set; }
        public int edad_usuario { get; set; }
    }
}
