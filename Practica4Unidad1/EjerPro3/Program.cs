using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro3
{
    class Program
    {
        static void Main(string[] args)
        {
            Club club = new Club();
            string nomb1, nomb2, nomb3;
            int an1, an2, an3;

            Console.Write("\nIngrese el nombre del socio #1: ");
            nomb1 = Console.ReadLine();
            Console.Write("Ingrese los años de membresia del socio #1: ");
            an1 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el nombre del socio #2: ");
            nomb2 = Console.ReadLine();
            Console.Write("Ingrese los años de membresia del socio #2: ");
            an2 = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el nombre del socio #3: ");
            nomb3 = Console.ReadLine();
            Console.Write("Ingrese los años de membresia del socio #3: ");
            an3 = int.Parse(Console.ReadLine());

            club.MasViejo(nomb1, nomb2, nomb3, an1, an2, an3);
            Console.ReadKey();
        }
    }
}
