using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, ciudad;

            Console.Write("\nDigite su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el nombre de una ciudad: ");
            ciudad = Console.ReadLine();

            Console.Write("\nHola " + nombre + " bienvenido a " + ciudad);

            Console.ReadKey();
        }
    }
}
