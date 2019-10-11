using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que calcula la cuota de un prestamo simple
namespace Ejercicio2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            int tiempo;
            double capital, interes, prestamo, cuota;

            Console.WriteLine(" Calculadora de prestamos simple");//Titulo descriptivo del programa
            try
            {
                Console.Write("\nIngrese la cantidad del prestamo: ");//Mensaje para el usuario
                capital = double.Parse(Console.ReadLine());//Captura de datos por teclado convertidos por parseo
                Console.Write("Diga el tiempo del prestamo(mese): ");
                tiempo = int.Parse(Console.ReadLine());
                Console.Write("Especifique la tasa de interes(porcentual): ");
                interes = double.Parse(Console.ReadLine());

                prestamo = capital + ((capital * interes)/100);
            }
            catch
            {
            }            
        }
    }
}
