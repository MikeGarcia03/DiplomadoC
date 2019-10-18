using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que muestra los numeros enteros del 1 al 100
namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estableciendo los colores de las letras y el fondo de la consola
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            //Se limpia la pantalla antes de mostar los datos
            Console.Clear();

            Console.WriteLine(" Conteo del 1 al 100"); //Titulo descriptivo del prpgrama

            for (int i = 1; i <= 100; i++) //Utilizamos el for para hacer el conteo
            {
                Console.WriteLine(i); //Mostramos el resultado
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
