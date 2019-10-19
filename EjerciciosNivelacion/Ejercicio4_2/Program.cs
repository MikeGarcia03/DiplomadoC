using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que muestra los numeros del 3 al 20 y sus potencias elevadas al cubo
namespace Ejercicio4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            double potencia;
            const int cubo = 3;
            
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
