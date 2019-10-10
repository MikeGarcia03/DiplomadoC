using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programa que reibe el nombre de un producto, su precio por unidad y la cantidad a comprar,
 * calcula el subtotal, el monto de ITBIS (18%) y el total a pagar. 
 */
namespace Ejercicio2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables a utilizar en el programa
            string nombreProducto;
            double precioUnidadProducto, cantidadProducto, subTotal, itbis, total;

            Console.WriteLine(" *Calculadora de impuesto y pago de un producto*");//Titulo descriptivo del programa
            try //Manejo de excepciones en caso de errores
            {
                Console.Write("\nIngrese el nombre del producto: ");//Mensaje para el usuario
                nombreProducto = Console.ReadLine();//Captura de datos por teclado y conversion por parseo
                Console.Write("Especifique la cantidad del producto: ");
                cantidadProducto = double.Parse(Console.ReadLine());
                Console.Write("Diga el precio del produsto: ");
                precioUnidadProducto = double.Parse(Console.ReadLine());

                subTotal = cantidadProducto * precioUnidadProducto;//Calculo del subtotal
                itbis = subTotal * 0.18;//Calculo del impuesto
                total = subTotal + itbis;// Calculo del total a pagar

                Console.Clear();//Limpieza de la pantalla
                Console.WriteLine(" *Calculadora de impuesto y pago de un producto*");
                //Impresion de los detalles y los resultados
                Console.Write("\nProducto: " + nombreProducto);

            }
            catch (Exception error) //Captura de la excepcion en caso de errores
            {
                Console.WriteLine("\n" + error.Message);//Impresion por pantalla del mensaje de error
            }
            Console.ReadKey(); //Pausa durante la ejecucion del programa
        }
    }
}
