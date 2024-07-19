using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Pregunta
    {
        [Key]
        public int id_pregunta { get; set; }
        public int id_encuesta { get; set; }
        public string texto_pregunta { get; set; }
    }
}
