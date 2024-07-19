using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class Horas_instructor
    {
        [Key]
        public int id_horas_instructor { get; set; }
        public int id_instructor { get; set; }
        public int id_periodo { get; set; }
        public int horas_ganadas_instructor { get; set; }
    }
}
