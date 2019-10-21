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
            float sueldo;
            string linea;
            Console.Write("\nIngrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            if (sueldo > 3000)
            {
                Console.WriteLine("Esta persona debe abonar impuestos");
            }
            Console.ReadKey();
        }
    }
}
