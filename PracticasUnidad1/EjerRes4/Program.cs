using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            float precio, total;
            string linea;

            Console.Write("\nIngrese la cantidad de articulos a llevar: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);
            Console.Write("Ingrese el valor unitario del producto: ");
            linea = Console.ReadLine();
            precio = float.Parse(linea);

            total = precio * cantidad;

            Console.Write("\nEl total a pagar es: ");
            Console.Write(total);

            Console.ReadKey();
        }
    }
}
