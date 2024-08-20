using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class UsuarioPeriodo
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
        public int IdGrupo { get; set; }
        public int IdPeriodo { get; set; }
        public int IdInstructor { get; set; }
        public string NombreCertificado { get; set; }
        public int horas_asignadas_estudiante { get; set; }
        public string TipoEstudiante { get; set; }
    }
}
