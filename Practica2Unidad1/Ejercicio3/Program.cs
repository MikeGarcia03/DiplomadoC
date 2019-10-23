using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, valor, pares = 0, impares = 0, positivos = 0, negativos = 0;
            string linea;
            x = 1;
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
                if (valor % 2 != 0)
                {
                    impares = impares + 1;
                }
                if (valor > 0)
                {
                    positivos += 1;
                }
                if (valor < 0)
                {
                    negativos += 1;
                }
                x = x + 1;
            }
            Console.Write("\nCantidad de positivos: " + positivos);
            Console.Write("\nCantidad de negativos: " + negativos);
            Console.Write("\nCantidad de pares: " + pares);
            Console.Write("\nCantidad de impares: " + impares);
            Console.ReadKey();
        }
    }
}
