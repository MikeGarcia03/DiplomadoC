using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que suma dos numeros
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asignacion del color de las letras y el fundo de la consola
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            //Se limpia la pantalla antes de mostrar la informacion en la misma
            Console.Clear();
            //Area de declaracion de variables
            double v1, v2, r;

            Console.WriteLine("-------------<Suma de dos nuemros>-------------");//Titulo del programa
            try //Manejo de excepciones en caso de errores
            {
                Console.Write("\nIngrese el primer valor: ");//Mensaje para el usuario
                v1 = Convert.ToDouble(Console.ReadLine());//Captuda de datos por teclado y conversion por clase Convert
                Console.Write("Ingrese el segundo valor: ");//Mensaje para el usuario
                v2 = double.Parse(Console.ReadLine());//Captura de datos por teclado y conversion por Parseo

                r = v1 + v2;//Se suman los datos

                Console.Write("\nEl resultado es: {0}", r);//Se muestra el resultado formateado a un decimal
            }
            catch (FormatException error) //Captura de la excepcion en caso de errores
            {
                Console.WriteLine(error.Message);//Impresion en pantalla del mensaje de error
            }

            Console.ReadKey();//Pausa durante la ejecucion del programa
        }
    }
}
