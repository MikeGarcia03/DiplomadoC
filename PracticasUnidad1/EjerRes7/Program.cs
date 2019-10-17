using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorLado, calsuperficie;
            string linea;

            Console.Write("\nIngrese el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            valorLado = int.Parse(linea);

            //calsuperficie = valorLado * (valorLado * valorLado); Incorrecto
            calsuperficie = valorLado * valorLado; //Correcto

            Console.Write("\nLa superficie del cuadrado es: ");
            Console.Write(calsuperficie);
            Console.ReadKey();
        }
    }
}
