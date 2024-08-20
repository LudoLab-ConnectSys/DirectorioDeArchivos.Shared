using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string? cedula_usuario { get; set; } = string.Empty;
        public string? nombre_usuario { get; set; } = string.Empty;
        public string? apellidos_usuario { get; set; } = string.Empty;
        public int edad_usuario { get; set; }
        public string? correo_usuario { get; set; } = string.Empty;
        public string? celular_usuario { get; set; } = string.Empty;
        public string? telefono_usuario { get; set; } = string.Empty;
        public string? contrasena { get; set; } = string.Empty;
    }
}
