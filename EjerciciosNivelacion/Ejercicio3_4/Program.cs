using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que muestra el nombre del dia de la semana segun el numero
namespace Ejercicio3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            int numeroDia;
            string[] nombreDia = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            Console.WriteLine(" Visor de dias de la semana segun su numero"); //Titulo descriptivo del programa

            Console.Write("\nDigite un numero entre 1 y 7: "); //Mensaje para el usuario

            try //Manejo de excepciones en caso de errores
            {
                numeroDia = int.Parse(Console.ReadLine()); //Captura de datos por teclado convertidos por parseo

                switch (numeroDia) //Utilizamos switch para evaluar los diferentes valores de numeroDia
                {
                    case 1: //Se ejecutara este bloque cuando el valor de numeroDia es 1
                        Console.Write("\nNumero del dia: {0}" +
                        "\nNombre del dia: {1}", numeroDia, nombreDia[0]); //Impresion de informaciones y resultados
                        break; //Sentencia que finaliza la ejecucion de este bloque
                    case 2: //Se ejecutara este bloque cuando el valor de numeroDia es 2
                        Console.Write("\nNumero del dia: {0}" +
                        "\nNombre del dia: {1}", numeroDia, nombreDia[1]);
                        break;
                    case 3: //Se ejecutara este bloque cuando el valor de numeroDia es 3
                        Console.Write("\nNumero del dia: {0}" +
                        "\nNombre del dia: {1}", numeroDia, nombreDia[2]);
                        break;
                    case 4: //Se ejecutara este bloque cuando el valor de numeroDia es 4
                        Console.Write("\nNumero del dia: {0}" +
                        "\nNombre del dia: {1}", numeroDia, nombreDia[3]);
                        break;
                    case 5: //Se ejecutara este bloque cuando el valor de numeroDia es 5
                        Console.Write("\nNumero del dia: {0}" +
                        "\nNombre del dia: {1}", numeroDia, nombreDia[4]);
                        break;
                    case 6: //Se ejecutara este bloque cuando el valor de numeroDia es 6
                        Console.Write("\nNumero del dia: {0}" +
                        "\nNombre del dia: {1}", numeroDia, nombreDia[5]);
                        break;
                    case 7: //Se ejecutara este bloque cuando el valor de numeroDia es 7
                        Console.Write("\nNumero del dia: {0}" +
                        "\nNombre del dia: {1}", numeroDia, nombreDia[6]);
                        break;
                    default: //Se ejecutara este bloque cuando el valor de numeroDia este fuera de la lista
                        Console.Write("\nError: Numero fuera de la lista");
                        break;
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
