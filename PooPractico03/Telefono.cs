using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PooPractico03
{
    public class Telefono
    {
        public TipoTelefono TipoTelefono { get; set; }

        public ClaseTelefono ClaseTelefono { get; set; }
        public string CodArea { get; set; }
        public string Numero { get; set; }
    }
}