using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que muestra la tabla de multiplicar del numero 4
namespace Ejercicio4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            int producto;
            const int mult = 4;

            Console.WriteLine(" Tabla de multiplicar del numero 4\n"); //Titulo descriptivo del prpgrama

            for (int i = 1; i <= 12; i++) //Utilizamos el for para general los multiplicandos
            {
                producto = mult * i; //Realizamos la multiplicacion
                Console.WriteLine("{0}x{1} = {2:N0}", mult, i, producto); //Mostramos el resultado
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
