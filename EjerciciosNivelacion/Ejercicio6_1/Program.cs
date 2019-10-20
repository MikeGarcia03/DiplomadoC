using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion del arreglo y variables
            int[] vector = new int[5];
            int valor;
            //Asignacion de valores a cada indice del vector
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresa el valor del indice[{i}]: ");
                valor = int.Parse(Console.ReadLine());
                vector[i] = valor;
            }
            Console.Write("\n");
            //Desplegar todo el contenido del arreglo
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
