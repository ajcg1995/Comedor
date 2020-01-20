using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Alias("TipoPersona")]
    public class TipoPersona
    {
        public int IdTipoPersona { get; set; }

        public string Descripcion { get; set; }
    }
}
