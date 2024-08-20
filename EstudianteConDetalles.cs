﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioDeArchivos.Shared
{
    public class EstudianteConDetalles
    {
        public int id_estudiante { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string cedula_usuario { get; set; }
        public int edad_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string celular_usuario { get; set; }
        public string telefono_usuario { get; set; }
        public string nombre_grupo { get; set; }
        public string nombre_curso { get; set; }
        public string nombre_periodo { get; set; }
        public int id_curso { get; set; }
        public int id_lista_periodo { get; set; }
        public string tipo_estudiante { get; set; }

        public List<string> cursos { get; set; }
        public List<string> periodos { get; set; }
        public List<int> id_cursos { get; set; }
        public List<int> id_periodos { get; set; }

        public List<HorarioPreferenteEstudiante> horariosPreferentes { get; set; }
    }
}