using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que calcula el perimetro de un cuadrado.
namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoCuadrado; //Declaro la o las variables a utilizar

            Console.WriteLine(" Calculo del perimetro de un cuadrado."); //Imprimo en pantalla un mensaje descriptivo del programa

            Console.Write("\nIngrese el lado del cuadrado: "); //Imprimo un mensaje en pantalla para el usuario

            try //Aplico un control de excepciones en caso de errores
            {
                ladoCuadrado = Convert.ToDouble(Console.ReadLine()); //Capturo el valor ingresadro por teclado y lo convierto a double
                ladoCuadrado *= 4; //Calculo el perimetro del cuadrado
                
                Console.Write("El perimetro del cuadrado es: {0:N2}", ladoCuadrado); //Imprimo el resultado formateado
            }
            catch (FormatException error) //Capturo la excepcion en caso de errores
            {
                Console.WriteLine(error.Message); //Impreso el mensaje de error
            }
            Console.ReadKey(); //Hago una pausa durante la ejecucion del programa
        }
    }
}
