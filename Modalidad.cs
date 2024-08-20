using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Modalidad
    {
        [Key]
        public int id_modalidad { get; set; }

        public string nombre_modalidad { get; set; }

        public string observaciones { get; set; }
    }
}
