using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double potencia;
            const int cubo = 3;
            //Estableciendo los colores de las letras y el fondo de la consola
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            //Se limpia la pantalla antes de mostar los datos
            Console.Clear();

            Console.WriteLine(" Potencia de los numeros del 3 al 20, al cubo\n"); //Titulo descriptivo del prpgrama

            for (int i = 3; i <= 20; i++) //Utilizamos el for para hacer el conteo
            {
                potencia = Math.Pow(cubo, i); //Elevamos a la potencia los numeros utilizando la funcion Pow de la clase Math
                Console.WriteLine("{0}^{1} = {2:N0}", i, cubo, potencia); //Mostramos el resultado
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
