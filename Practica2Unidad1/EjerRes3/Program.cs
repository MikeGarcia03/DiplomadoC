using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, valor, pares, impares;
            string linea;
            x = 1;
            pares = 0;
            impares = 0;
            Console.Write("\nCuantos el valor de n: ");
            linea = Console.ReadLine();
            Console.Write("\n");
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.Write("Ingresa el valor " + x + ": ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor % 2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }
                x = x + 1;
            }
            Console.Write("\nCantidad de pares: " + pares);
            Console.Write("\nCantidad de impares: " + impares);
            Console.ReadKey();
        }
    }
}
