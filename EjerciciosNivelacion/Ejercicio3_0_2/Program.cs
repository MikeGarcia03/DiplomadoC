using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_0_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            int a = 20;
            //3ra forma de como puedes usar el if (if anidado)
            if (a == 1)
            {
                Console.WriteLine("A es igual a 1");
            }
            else if (a == 2)
            {
                Console.WriteLine("A es igual a 2");
            }
            else if (a == 3)
            {
                Console.WriteLine("A es igual a 3");
            }
            else
            {
                Console.WriteLine("Valor no esta en la lista de if");
            }
            Console.ReadKey();
        }
    }
}
