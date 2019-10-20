using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //Declaracion del arreglo
            int[] vector = new int[5];
            //Asignacion de valores a cada indice del vector
            vector[0] = 10;
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 40;
            vector[4] = 50;

            //Desplegar todo el contenido del arreglo
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.ReadKey();
        }
    }
}
