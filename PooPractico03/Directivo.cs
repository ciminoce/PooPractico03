using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PooPractico03
{
    public class Directivo : Empleado
    {
        public Categoria Categoria { get; set; }

        public List<Empleado> EmpleadosACargo { get; set; } = new List<Empleado>();
    }
}