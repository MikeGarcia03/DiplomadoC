using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion del arreglo
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];
            int[,] matrizC = new int[2, 2];
            //Asignacion de valores a cada indice de la tabla1
            matrizA[0, 0] = 70;
            matrizA[0, 1] = 60;
            matrizA[1, 0] = 80;
            matrizA[1, 1] = 70;
            //Asignacion de valores a cada indice de la tabla2
            matrizB[0, 0] = 68;
            matrizB[0, 1] = 90;
            matrizB[1, 0] = 80;
            matrizB[1, 1] = 70;

            //Desplegar todo el contenido del arreglo
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 2; c++)
                {
                    matrizC[f,c] = matrizA[f, c] + matrizB[f, c];
                }
            }
            Console.Write("\nLa suma de las matrices A y B es igual:\n");
            for (int f = 0; f < 2; f++)
            {
                Console.Write("\n");
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(matrizC[f, c] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
