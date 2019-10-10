using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que solicita el nombre al usuario y lo saluda
namespace Ejercicio2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreUsuario = "";//Declaracion e inicializacion de variable

            Console.WriteLine("Programa que saluda");//Titulo del programa

            Console.Write("\nIngrese su nombre: ");//Mensaje para el usuario
            nombreUsuario = Console.ReadLine();//Captura del nombre del usuario

            Console.Write("Hola querid@ " + nombreUsuario);//Impresion del saludo

            Console.ReadKey();//Pausa durante la ejecucion del programa
        }
    }
}
