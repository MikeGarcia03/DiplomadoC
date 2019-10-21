using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x <= 200)
            {
                if (x % 3 == 0)
                {
                    Console.Write("\n" + x);
                }
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
