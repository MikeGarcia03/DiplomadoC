using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que calcula la masa de aire
namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            double masa, presion, volumen, temperatura; //Declaro la o las variables a utilizar

            Console.WriteLine(" Calculo de la masa de aire."); //Imprimo en pantalla un mensaje descriptivo del programa

            try //Aplico un control de excepciones en caso de errores
            {
                Console.Write("\nIngrese la presion: "); //Imprimo mensajes en pantalla para el usuario
                presion = Convert.ToDouble(Console.ReadLine()); //Capturo el valor ingresadro por teclado y lo convierto a double
                Console.Write("Ingrese la volumen: ");
                volumen = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese la temperatura: ");
                temperatura = Convert.ToDouble(Console.ReadLine());

                masa = (presion * volumen) / (0.37 * (temperatura + 460)); //Calculo el valor de la masa de aire

                Console.Write("\nLa masa del aire es: {0:N2}", masa); //Imprimo el resultado formateado
            }
            catch (FormatException error) //Capturo la excepcion en caso de errores
            {
                Console.Write("\n" + error.Message); //Impreso el mensaje de error
            }

            Console.ReadKey(); //Hago una pausa durante la ejecucion del programa
        }
    }
}
