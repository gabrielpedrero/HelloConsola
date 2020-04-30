using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola desde la aplicación de prueba HelloConsola...");

            Usuario usuario = new Usuario { Nombre = "Gabriel", Apellidos = "Pedrero" };

            Console.WriteLine($"{Environment.NewLine}El usuario creado es {usuario.Nombre} {usuario.Apellidos}");

            Pais pais = new Pais { Clave = "MX", Nombre = "México" };

            Console.WriteLine($"{Environment.NewLine}El país creado es {pais.Nombre} ({pais.Clave})");
            Console.WriteLine($"{Environment.NewLine}Pulse <Enter> para terminar...");
            Console.ReadLine();
        }
    }
}
