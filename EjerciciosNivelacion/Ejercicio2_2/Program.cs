using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que calcula el promedio de cuatro notas.
namespace Ejercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            double notaEnero, notaFebrero, notaMarzo, notaAbril, promedio;

            Console.WriteLine(">>>>>>>>>CALCULO DEL PROMEDIO DE 4 NOTAS<<<<<<<<<");//Titulo descriptivo del programa
            try //Menejor de excepciones en caso de errores
            {
                Console.Write("\nIngrese la nota de Enero: ");//Mensaje para el usuario
                notaEnero = double.Parse(Console.ReadLine());//Captura de los datos por teclado y conversion por parseo
                Console.Write("Ingrese la nota de Febrero: ");
                notaFebrero = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la nota de Marzo: ");
                notaMarzo = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la nota de Abril: ");
                notaAbril = double.Parse(Console.ReadLine());

                promedio = (notaEnero + notaFebrero + notaMarzo + notaAbril) / 4;//Calculo del promedio de las 4 notas

                Console.Write("\nSu nota promedio es: {0:N2}", promedio);//Impresion del resultado formateado
            }
            catch (FormatException error) //Captura de la excepcion en caso de errores
            {
                Console.WriteLine(error.Message); //Impresion en pantalla del mensaje de error
            }

            Console.ReadKey();//Pausa durante la ejecucion del programa
        }
    }
}
