using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que convierte de centimenos a purgada
namespace Ejercicio2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            double r, cm, PUL=2.54;

            Console.WriteLine(" Conversor de centimentros a pulgadas");//Titulo descriptivo del programa
            try //Manejo de excepciones en caso de errores
            {
                Console.Write("\nIngrese los centimetros: ");//Mensaje para el usuario
                cm = double.Parse(Console.ReadLine());//Captura de datos por teclado convertidos por parseo

                r = cm / PUL;//Conversion de centimetros a pulgadas

                Console.Write("\n{0:N2} cm. es igual a {1:N2} pulg.", cm, r);//Impresion del resultado
            }
            catch (Exception error) //Captura de la excepcion en caso de error
            {
                Console.WriteLine(error.Message);//Impresion del mensaje de error
            }

            Console.ReadKey();//Pausa durate la ejecucion del programa
        }
    }
}
