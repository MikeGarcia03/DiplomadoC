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
            string[] etapa = { "Bebe", "Niño", "Adolescente", "Joven", "Adulto", "Anciano" };

            Console.WriteLine(" Identifiacor de etapa de vida segun su edad"); //Titulo descriptivo del programa

            Console.Write("\nDiga su edad: "); //Mensaje para el usuario

            try //Manejo de excepciones en caso de errores
            {
                edad = int.Parse(Console.ReadLine()); //Captura de datos por teclado convertidos por parseo

                if (edad == 0 || edad == 1) //Validacion para edad igual a 0 o 1
                {
                    Console.Write("\nEdad: {0}" +
                        "\nUsted es: {1}", edad, etapa[0]); //Impresion de informaciones y resultados
                }
                else if (edad >= 2 && edad <= 12) //Validacion para edad mayor o igual a 2 y menor o igual a 12
                {
                    Console.Write("\nEdad: {0}" +
                        "\nUsted es: {1}", edad, etapa[1]);
                }
                else if (edad >= 13 && edad <= 17) //Validacion para edad mayor o igual a 13 y menor o igual a 17
                {
                    Console.Write("\nEdad: {0}" +
                        "\nUsted es: {1}", edad, etapa[2]);
                }
                else if (edad >= 18 && edad <= 30) //Validacion para edad mayor o igual a 18 y menor o igual a 30
                {
                    Console.Write("\nEdad: {0}" +
                        "\nUsted es: {1}", edad, etapa[3]);
                }
                else if (edad >= 31 && edad <= 64) //Validacion para edad mayor o igual a 31 y menor o igual a 64
                {
                    Console.Write("\nEdad: {0}" +
                        "\nUsted es: {1}", edad, etapa[4]);
                }
                else if (edad >= 65 && edad <= 120) //Validacion para edad mayor o igual a 65 y menor o igual a 120
                {
                    Console.Write("\nEdad: {0}" +
                        "\nUsted es: {1}", edad, etapa[5]);
                }
                else ////Validacion para edad menor que 0 y mayor que 120
                {
                    Console.Write("\nError: Edad incorrecta.");
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
