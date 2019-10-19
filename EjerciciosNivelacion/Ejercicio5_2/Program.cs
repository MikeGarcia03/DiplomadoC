using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";

            do
            {
                Console.Clear();
                Console.WriteLine("+++++++++++++++ MENU DE OPCIONES +++++++++++++++");
                Console.WriteLine("TABLA DE MULTIPLICAR [T]");
                Console.WriteLine("CALCULO PROMEDIO [P]");
                Console.WriteLine("SALIR [S]");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Ingrese una opcion [?]: ");
                opcion = Console.ReadLine();

                switch (opcion) //Utilizamos switch para evaluar los diferentes valores de opcion
                {
                    case "t":
                    case "T":

                        int producto, mult;

                        Console.Clear();
                        Console.WriteLine(" Tabla de multiplicar"); //Titulo descriptivo del prpgrama
                        Console.Write("\nIngrese el numero de la tabla: ");
                        mult = int.Parse(Console.ReadLine());
                        Console.Write("\n");

                        for (int i = 1; i <= 12; i++) //Utilizamos el for para general los multiplicandos
                        {
                            producto = mult * i; //Realizamos la multiplicacion
                            Console.WriteLine("{0}x{1} = {2:N0}", mult, i, producto); //Mostramos el resultado
                        }
                        Console.Write("\nPurse una tecla para regresar al menu..."); Console.ReadKey();
                        break;

                    case "p":
                    case "P":

                        //Declaracion de variables a utilizar en el programa
                        double nota1, nota2, nota3, nota4, promedio;

                        Console.Clear();
                        Console.WriteLine("Calculo del promedio de cuatro notas"); //Titulo descriptivo del programa
                        Console.Write("\nIngresa la nota #1: "); //Mensaje para el usuario
                        nota1 = double.Parse(Console.ReadLine()); //Captura de datos por teclado convertidos por parseo
                        Console.Write("Ingresa la nota #2: ");
                        nota2 = double.Parse(Console.ReadLine());
                        Console.Write("Ingresa la nota #3: ");
                        nota3 = double.Parse(Console.ReadLine());
                        Console.Write("Ingresa la nota #4: ");
                        nota4 = double.Parse(Console.ReadLine());

                        promedio = (nota1 + nota2 + nota3 + nota4) / 4; //Calculo del promedio de las 4 notas

                        Console.Write("\nTu promedio es: {0:N1}", promedio); //Impresion de informaciones y resultados
                        Console.Write("\nPurse una tecla para regresar al menu..."); Console.ReadKey();
                        break;

                    default: //Se ejecutara este bloque cuando el valor de opcion este fuera de la lista
                        Console.Write("\nAdios...");
                        opcion = "s";
                        break;
                }
            } while (opcion != "s" && opcion != "S");
        }
    }
}
