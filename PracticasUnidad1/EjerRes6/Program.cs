using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes6
{
    class Program
    {
        static void Main(string[] args)
        {
            double cPeso, eqDolar;
            const int uCambio = 50;

            Console.Write("\nIngrese cantidad en pesos Dominicano: ");
            cPeso = Double.Parse(Console.ReadLine());

            eqDolar = cPeso / uCambio; //Multiplicamos la cantidad de pesos Dominicanos por la unidad de cambio

            Console.Write("{0:C2} pasos equivale a {1:C2} dolare", cPeso, eqDolar);
            Console.ReadKey();
        }
    }
}
