using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, sum, mult;
            string valor;

            Console.Write("\nIngrese el primer valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo valor: ");
            valor = Console.ReadLine();
            v2 = int.Parse(valor);

            sum = v1 + v2;
            mult = v1 * v2;

            Console.Write("\nLa suma de los dos numeros es igual a: ");
            Console.WriteLine(sum);
            Console.Write("\nLa multiplicacion de los dos numeros es igual a: ");
            Console.WriteLine(mult);

            Console.ReadKey();
        }
    }
}
