using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class GrupoDto
    {
        [Key]
        public int IdGrupo { get; set; }
        public int IdPeriodo { get; set; }
        public string DiaSemana { get; set; }
        public List<Horario> Horarios { get; set; } // Lista de horarios
        public string NombreGrupo { get; set; }
    }
}
