using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace PooPractico03
{
    public class Empresa
    {
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; } = new List<Empleado>();

        public List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public List<Proveedor> Proveedores { get; set; } = new List<Proveedor>();

        public decimal InformarSueldo(Empleado empleado)
        {
            if (empleado is Directivo)
            {
                return 100000;
            }
            return new Random(new Guid().GetHashCode()).Next(50000, 70000);
        }

        public int InformarAntigüedad(Empleado emp)
        {
            var antiguedad = DateTime.Today.Year - emp.FechaContratacion.Year;
            if (emp.FechaContratacion.AddYears(antiguedad) > DateTime.Today.Date)
            {
                antiguedad--;
            }

            return antiguedad;

        }
    }
}