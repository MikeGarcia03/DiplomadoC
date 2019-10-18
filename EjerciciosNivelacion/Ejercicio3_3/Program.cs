using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Programa que solicita la edad y devuelve la etapa segun esta
namespace Ejercicio3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            int edad;
            string[] calificacon = { "Bebe", "Niño", "Adolescente", "Joven", "Adulto", "Anciano", "Error" };

            Console.WriteLine(" Identifiacor de edad"); //Titulo descriptivo del programa

            Console.Write("\nIngresa la nota #1: "); //Mensaje para el usuario

            try //Manejo de excepciones en caso de errores
            {
                edad = int.Parse(Console.ReadLine()); //Captura de datos por teclado convertidos por parseo

                if (edad == 0 && edad < 65) //Validacion para promedio mayor o igual a 0 y menor a 65
                {
                    Console.Write("\nNota Promedio: {0:N1}" +
                        "\nCalificacion: {1}", promedio, calificacon[0]); //Impresion de informaciones y resultados
                }
                else if (promedio >= 65 && promedio < 75) //Validacion para promedio mayor o igual a 65 y menor a 75
                {
                    Console.Write("\nNota Promedio: {0:N1}" +
                        "\nCalificacion: {1}", promedio, calificacon[1]);
                }
                else if (promedio >= 75 && promedio < 85) //Validacion para promedio mayor o igual a 75 y menor a 85
                {
                    Console.Write("\nNota Promedio: {0:N1}" +
                        "\nCalificacion: {1}", promedio, calificacon[2]);
                }
                else if (promedio >= 85 && promedio < 90) //Validacion para promedio mayor o igual a 85 y menor a 90
                {
                    Console.Write("\nNota Promedio: {0:N1}" +
                        "\nCalificacion: {1}", promedio, calificacon[3]);
                }
                else if (promedio >= 90 && promedio < 100) //Validacion para promedio mayor o igual a 90 y menor a 100
                {
                    Console.Write("\nNota Promedio: {0:N1}" +
                        "\nCalificacion: {1}", promedio, calificacon[4]);
                }
                else ////Validacion para promedios fuera del rango
                {
                    Console.Write("\n\nNota fuera del rango establecido");
                }
            }
            catch (Exception error) //Captura de las excepciones en caso de errores
            {
                Console.WriteLine(error.Message); //Impresion del mensaje de error
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
