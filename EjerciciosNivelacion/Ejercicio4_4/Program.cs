using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que muestra las tablas de multiplicar del 1 al 12
namespace Ejercicio4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            int producto;            

            Console.WriteLine(" Tabla de multiplicar del numero 4\n"); //Titulo descriptivo del prpgrama

            for (int multiplicador = 1; multiplicador <= 12; multiplicador++) //Utilizamos el for para general los multiplicadores
            {
                for (int multiplicando = 1; multiplicando <= 12; multiplicando++) //Utilizamos el for para general los multiplicandos
                {
                    producto = multiplicador * multiplicando; //Realizamos la multiplicacion
                    Console.WriteLine("{0}x{1} = {2:N0}", multiplicador, multiplicando, producto); //Mostramos el resultado
                    if (multiplicando == 12) //Validamos que multiplicando sea igual a 12 para...
                    {
                        Console.Write("\n"); //imprimir un salto de linea
                    }
                }                
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
