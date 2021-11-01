using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PooPractico03
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa(){Nombre = "El Programón"};
            Random r = new Random();
            for(int i=1;i<=5;i++)
            {
                var empleado = new Empleado()
                {
                    Apellido = $"empleado {i}",
                    Nombres = $" nombres {i}",
                    FechaContratacion = DateTime.Today.AddYears(-10),
                    FechaNacimiento = DateTime.Today.AddYears((-1)*r.Next(18,40)),
                    Sector = Sector.Administracion
                    
                };
                empresa.Empleados.Add(empleado);
            }

            var directivo = new Directivo()
            {
                Apellido = "King",
                Nombres = "Joseph",
                FechaContratacion = new DateTime(2000, 10, 1),
                FechaNacimiento = new DateTime(1970, 12, 27),
                Sector = Sector.Administracion,
                Categoria = Categoria.Categoria19
            };
            empresa.Empleados.Add(directivo);
            foreach (var empleado in empresa.Empleados)
            {
                Console.WriteLine(empleado.ToString());
                Console.WriteLine(empresa.InformarAntigüedad(empleado));
                Console.WriteLine(empresa.InformarSueldo(empleado));
            }

            Console.ReadLine();
        }
    }
}
