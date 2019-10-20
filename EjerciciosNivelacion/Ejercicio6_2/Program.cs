using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion del arreglo y variables
            int valor, dimension, suma = 0;

            Console.Write("\nEspecifique la dimension del array: ");
            dimension = int.Parse(Console.ReadLine());
            int[] vector = new int[dimension];

            Console.Write("\n");
            //Asignacion de valores a cada indice del vector
            for (int i = 0; i < dimension; i++)
            {
                Console.Write($"Ingresa el valor del indice[{i}]: ");
                valor = int.Parse(Console.ReadLine());
                vector[i] = valor;
            }            
            //Desplegar todo el contenido del arreglo
            for (int i = 0; i < dimension; i++)
            {
                suma += vector[i];
            }
            Console.Write($"\nLa sumatoria es: {suma}");
            Console.ReadKey();
        }
    }
}
