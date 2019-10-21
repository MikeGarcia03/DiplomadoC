using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3;
            string linea;
            Console.Write("\nIngrese la primera nota: ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);
            Console.Write("Ingrese la segunda nota: ");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);
            Console.Write("Ingrese la tercera nota: ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);
            int promedio = (nota1 + nota2 + nota3) / 3;
            if (promedio > 10)
            {
                Console.Write("\nAPROBADO");
            }
            else
            {
                if (promedio >= 7 && promedio <= 10)
                {
                    Console.Write("\nDESAPROBADO");
                }
                else
                {
                    Console.Write("\nREPROBADO");
                }
            }
            Console.ReadKey();
        }
    }
}
