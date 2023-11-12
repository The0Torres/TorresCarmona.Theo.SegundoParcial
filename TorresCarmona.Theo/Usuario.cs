﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laburos
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int legajo { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string perfil { get; set; }


        public override string ToString()
        {
            return $"Correo: {this.correo} - Nombre: {this.nombre} {this.apellido} - Perfil: {this.perfil} - Legajo: {legajo}";
        }
    }
}
