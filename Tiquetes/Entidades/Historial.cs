﻿using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Alias("Historial")]
    public class Historial
    {
        public string Identificacion { get; set; }

        public string Fecha{ get; set; }

        public string Hora { get; set; }
    }
}
