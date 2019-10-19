using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            int producto, multiplicando = 1;
            const int multiplicador = 4;

            Console.WriteLine(" Tabla de multiplicar del numero 4\n"); //Titulo descriptivo del prpgrama

            while (multiplicando <= 12) //Utilizamos el for para hacer el conteo
            {
                producto = multiplicador * multiplicando; //Realizamos la multiplicacion
                Console.WriteLine("{0}x{1} = {2:N0}", multiplicador, multiplicando, producto); //Mostramos el resultado
                multiplicando += 1;
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
