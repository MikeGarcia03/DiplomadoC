using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que muestra los numeros enteros del 1 al 105
namespace Ejercicio4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Conteo del 1 al 105"); //Titulo descriptivo del prpgrama

            for (int i = 1; i <= 105; i++) //Utilizamos el for para hacer el conteo
            {
                Console.WriteLine(i); //Mostramos el resultado
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
