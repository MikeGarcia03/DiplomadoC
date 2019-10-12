using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, sum, mult, div;
            string valor;

            Console.Write("\nIngrese el primer numero: ");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);
            Console.Write("Ingrese el segundo numero: ");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);
            Console.Write("Ingrese el tercer numero: ");
            valor = Console.ReadLine();
            num3 = int.Parse(valor);
            Console.Write("Ingrese el cuarto numero: ");
            valor = Console.ReadLine();
            num4 = int.Parse(valor);

            sum = num1 + num2;
            mult = num3 * num4;
            div = num1 / num4;

            Console.Write("\nLa suma de los dos numeros es: ");
            Console.WriteLine(sum);
            Console.Write("\nLa multiplicacion del tercero y el cuarto es: ");
            Console.WriteLine(mult);
            Console.Write("\nLa divicion del primero y el cuarto es: ");
            Console.WriteLine(div);

            Console.ReadKey();
        }
    }
}
