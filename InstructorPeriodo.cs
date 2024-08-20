using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class InstructorPeriodo
    {
        [Key]
        public int IdUsuario { get; set; }
        public string CedulaUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidosUsuario { get; set; }
        public int EdadUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public int HorasGanadasInstructor { get; set; }
        public string NombreCertificado { get; set; }
        public string NombreCurso { get; set; }
        public string NombrePeriodo { get; set; }
    }
}
