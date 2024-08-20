using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class InstructorDto
    {
        [Key]
        public int IdInstructor { get; set; }
        public string CedulaUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidosUsuario { get; set; }
        public int EdadUsuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public string TelefonoUsuario { get; set; }
        public List<GrupoDto> Grupos { get; set; }
        public int TotalHorasGanadas { get; set; }
        public int IdPeriodo { get; set; } // Nueva propiedad
    }
}
