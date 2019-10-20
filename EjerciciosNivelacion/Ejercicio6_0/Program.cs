using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //Declaracion del arreglo
            int[,] tabla = new int[2,3];
            //Asignacion de valores a cada indice de la tabla
            tabla[0,0] = 10;
            tabla[0,1] = 20;
            tabla[0,2] = 30;

            tabla[1,0] = 40;
            tabla[1,1] = 50;
            tabla[1,2] = 60;

            //Desplegar todo el contenido del arreglo
            for (int f = 0; f < 2; f++)
            {
                Console.Write("\n");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(tabla[f,c] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
