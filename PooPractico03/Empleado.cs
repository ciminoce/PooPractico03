using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PooPractico03
{
    public class Empleado : Persona
    {

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaContratacion { get; set; }

        public decimal Sueldo { get; set; }

        public Sector Sector { get; set; }

        public int GetEdad()
        {
            //return (int)Math.Truncate(DateTime.Today.Subtract(FechaNacimiento).TotalDays/365.25);
            var edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.AddYears(edad)>DateTime.Today.Date)
            {
                edad--;
            }

            return edad;
        }

        public override string ToString()
        {
            return $"{Apellido}, {Nombres} - Edad:{this.GetEdad()}";
        }
    }
}