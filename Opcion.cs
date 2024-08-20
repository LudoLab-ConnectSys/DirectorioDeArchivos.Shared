using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Opcion
    {
        [Key]
        public int id_opcion { get; set; }
        public int id_pregunta { get; set; }
        public string texto_opcion { get; set; }
        public int valor_numero { get; set; }
    }
}
