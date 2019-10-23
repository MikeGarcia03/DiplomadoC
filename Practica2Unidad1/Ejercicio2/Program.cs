using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sueldo, ano, aumento;
            const double aument1 = 0.20, aument2 = 0.05;
            string nombre;

            Console.Write("\nIngrese el nombre del operario: ");
            nombre = Console.ReadLine();
            Console.Write("Diga el tiempo en labor: ");
            ano = double.Parse(Console.ReadLine());
            Console.Write("Diga el sueldo actual: ");
            sueldo = double.Parse(Console.ReadLine());

            if (sueldo < 500 && ano >= 10)
            {
                aumento = sueldo * aument1;
                sueldo = sueldo + aumento;
            }
            else
            {
                if (sueldo < 500 && ano < 10)
                {
                    aumento = sueldo * aument2;
                    sueldo = sueldo + aumento;
                }
            }
            Console.Write("\nSueldo a pagar: {0:C2}", sueldo);
            Console.ReadKey();
        }
    }
}
