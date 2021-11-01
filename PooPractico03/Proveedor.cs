using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PooPractico03
{
    public class Proveedor
    {
        public string NombreFantasia { get; set; }

        public List<Telefono> Telefonos { get; set; } = new List<Telefono>();

        public Persona Persona { get; set; }
    }
}