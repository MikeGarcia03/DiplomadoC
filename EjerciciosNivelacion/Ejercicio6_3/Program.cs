using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion del arreglo y variables
            string nombre;
            string[,] tabla = new string[2, 3];
            //Asignacion de valores a cada indice del vector
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Ingrese el nombre para el indice [{0},{1}]: ", f, c);
                    nombre = Console.ReadLine();
                    tabla[f, c] = nombre;
                }
            }
            //Desplegar todo el contenido del arreglo
            for (int f = 0; f < 2; f++)
            {
                Console.Write("\n");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(tabla[f, c] + " | ");
                }
            }
            Console.ReadKey();
        }
    }
}
