using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class ListaPeriodo
    {
        [Key]
        public int id_lista_periodo { get; set; }
        public string? nombre_periodo { get; set; } = string.Empty;
    }
}
