using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class InstructoresPaginadosDto
    {
        public List<InstructorDto> Instructores { get; set; }
        public int TotalCount { get; set; }
    }
}
