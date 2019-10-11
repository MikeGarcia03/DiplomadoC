using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Porgrama que calcula el sueldo bruto, el sueldo neto y el descuento de las horas
 * trabajadas segun la tarifa por horas dada
*/
namespace Ejercicio2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            double sb, sn, dd, th, ht, td=0.10;

            Console.WriteLine(" Calculo de sueldos y descueto segun horas trabajadas y tarifa dada");//Titulo descriptivo del programa
            try//Manejo de excepciones en caso de errores
            {
                Console.Write("\nIngrese la cantidad de horas trabajadas: ");//Mensaje para el usuario
                ht = double.Parse(Console.ReadLine());//Captura de datos por teclado convertidos por parseo
                Console.Write("Diga la tarifa a pagar por hora: ");
                th = double.Parse(Console.ReadLine());

                sb = ht * th;//Calculo para obtener el sueldo bruto
                dd = sb * td;//Calculo para obtener el monto a descontar
                sn = sb - dd;//Calculo para obtener el sueldo neto

                Console.Clear();//Limpieza de pantalla                
                Console.WriteLine(" Calculo de sueldos y descueto segun horas trabajadas y tarifa dada");
                //Impresion de informaciones y resultados
                Console.Write("\nHoras trabajadas: {0}", ht);
                Console.Write("\nPago por hora: {0:C2}", th);
                Console.Write("\n\nSueldo bruto: {0:C2}", th);
                Console.Write("\nDescuento: {0:C2}", dd);
                Console.Write("\nSueldo neto: {0:C2}", sn);
            }
            catch (Exception error)//Captura de las excepciones en caso de errores
            {
                Console.WriteLine(error.Message);//Impresion del mensaje de error
            }

            Console.ReadKey();//Pausa durante la ejecucion del programa
        }
    }
}
