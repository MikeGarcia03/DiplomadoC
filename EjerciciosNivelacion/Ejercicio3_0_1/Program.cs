using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //2da forma de como puedes usar el if
            int a = 10, b = 10;

            if (a == b)
            {
                Console.WriteLine("A es igual a B");
            }
            else
            {
                Console.WriteLine("A NO es igual a B");
            }
            Console.ReadKey();
        }
    }
}
