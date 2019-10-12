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
            double monto, interes, totalPrestamo, totalInteres, interesPromedio, cuota;

            Console.WriteLine(" Calculadora de prestamos simple");//Titulo descriptivo del programa
            try //Manejo de excepciones en caso de errores
            {
                Console.Write("\nIngrese la cantidad del prestamo ($): ");//Mensaje para el usuario
                monto = double.Parse(Console.ReadLine());//Captura de datos por teclado convertidos por parseo
                Console.Write("Diga el tiempo del prestamo (mese): ");
                tiempo = int.Parse(Console.ReadLine());
                Console.Write("Especifique la tasa de interes (%): ");
                interes = double.Parse(Console.ReadLine());

                interes /= 100;//LLevando la tasa de interes a decimal
                cuota = ((monto * interes) / tiempo) + (monto / tiempo);//Calculo de la cuota
                totalPrestamo = cuota * tiempo;//Prestamo a pagar
                totalInteres = totalPrestamo - monto;
                interesPromedio = totalInteres / tiempo;//Calculo del interes promedio

                Console.Clear();//Limpieza de la consola
                Console.WriteLine(" Calculadora de prestamos simple");
                //Impresion de informaciones y resultados
                Console.Write("\nMonto del prestamo: {0:C2}", monto);
                if (tiempo <= 1)//Validando si es menor o igual a un mes
                {
                    Console.Write("\nTiempo del prestamo: {0} mes", tiempo);//Mensaje cuando es un mes o menos
                }
                else
                {
                    Console.Write("\nTiempo del prestamo: {0} meses", tiempo);//Mensaje cuando es mas de un mes
                }
                Console.Write("\nTasa de interes anual: {0:N2}%", interes * 100);
                Console.Write("\nMonto a pagar: {0:C2}", totalPrestamo);
                Console.Write("\nInteres a pagar: {0:C2}", totalInteres);
                Console.Write("\nInteres promedio mensual: {0:C2}", interesPromedio);
                Console.Write("\nCuotas mensuales: {0:C2}", cuota);
                Console.Write("\nCuotas quincenales: {0:C2}", cuota / 2);
            }
            catch (Exception error)//Captura de excepcion en caso de error
            {
                Console.WriteLine(error.Message); //Impresion del mensaje de error
            }
            Console.ReadKey();//Pausa durante la ejecucion del programa
        }
    }
}
