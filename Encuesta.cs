using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public  class Encuesta
    {
        [Key]
        public int id_encuesta { get; set; }
        public string titulo { get; set; }
        public DateTime fecha_creacion { get; set; }
    }
}
