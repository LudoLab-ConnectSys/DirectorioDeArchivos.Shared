using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Certificado
    {
        [Key]
        public int id_certificado { get; set; }
        public string? nombre_certificado { get; set; }=string.Empty;
        public string? tipo_certificado { get; set; } = string.Empty;
        public string? documento_plantilla { get; set; } = string.Empty;
        public string? descripcion { get; set; } = string.Empty;
        public int id_periodo { get; set; }
    }
}
