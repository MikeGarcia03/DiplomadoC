using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que calcula el valor del salario actual incrementado a un 40%
namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioActual, aumento, salarioNuevo; //Declaro la o las variables a utilizar

            Console.WriteLine(" Calculo del salario actual aumentado en un 40%"); //Imprimo en pantalla un mensaje descriptivo del programa

            Console.Write("\nDigite su salario actual: "); //Imprimo mensajes en pantalla para el usuario
            try //Aplico un control de excepciones en caso de errores
            {
                salarioActual = Convert.ToDouble(Console.ReadLine()); //Capturo el valor ingresadro por teclado y lo convierto a double

                aumento = (salarioActual * 40) / 100; //Calculo la cantidad a aumentar
                salarioNuevo = salarioActual + aumento; //Sumo la cantidad a aumentar al salario actual

                Console.WriteLine("Cantidad aumentada: {0:C2}", aumento); //Imprimo el resultado formateado
                Console.WriteLine("Su nuevo salario es: {0:C2}", salarioNuevo);
            }
            catch (FormatException error) //Capturo la excepcion en caso de errores
            {
                Console.WriteLine(error.Message); //Impreso el mensaje de error
            }
            Console.ReadKey(); //Hago una pausa durante la ejecucion del programa
        }
    }
}
