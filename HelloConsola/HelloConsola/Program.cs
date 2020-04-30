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

            Console.WriteLine($"El usuario creado es {usuario.Nombre} {usuario.Apellidos}");
            Console.WriteLine("Pulse <Enter> para terminar...");
            Console.ReadLine();
        }
    }
}
