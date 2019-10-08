using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que calcula la equivalencia de pesos a dollar con una tasa de cambio dada.
namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {
            double monedaCambiar, tasaCambio, valorCambio; //Declaro la o las variables a utilizar

            Console.WriteLine(" Conversor de pesos a dollar"); //Imprimo en pantalla un mensaje descriptivo del programa
            try //Aplico un control de excepciones en caso de errores
            {
                Console.Write("\nIngrese la cantidad de pesos a cambiar: "); //Imprimo mensajes en pantalla para el usuario
                monedaCambiar = Convert.ToDouble(Console.ReadLine()); //Capturo el valor ingresadro por teclado y lo convierto a double
                Console.Write("Ingrese la tasa de cambio: ");
                tasaCambio = Convert.ToDouble(Console.ReadLine());

                if (tasaCambio != 0) //Valido que el valor de la tasa de cambio sea diferente de cero
                { 
                    valorCambio = monedaCambiar / tasaCambio; //Realizo la conversion de pesos a dollar
                    Console.WriteLine("\n{0:C2} pesos equivalan a {1:C2} dollar", monedaCambiar, valorCambio); //Imprimo el resultado formateado
                }
                else
                { 
                    Console.WriteLine("\nNo se pude dividir entre cero."); //Imprimo un mensaje en pantalla cuando la tasa de cambio es cero
                }
            }
            catch (FormatException error) //Capturo la excepcion en caso de errores
            {
                Console.WriteLine(error.Message); //Impreso el mensaje de error
            }
            Console.ReadKey(); //Hago una pausa durante la ejecucion del programa
        }
    }
}
