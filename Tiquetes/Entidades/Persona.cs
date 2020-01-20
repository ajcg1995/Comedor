﻿using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Alias("Persona")]

    public class Persona : Resultado
    {
        public string Nombre { get; set; }
        [PrimaryKey]
        public string Identificacion { get; set; }

        public Boolean Esbecado { get; set; }

        public int TipoPersona { get; set; }

    }
}
