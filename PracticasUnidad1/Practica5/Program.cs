using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Programa que calcula el porcentaje de hombre y mujeres en un curso
namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadHombres, cantidadMujeres, totalCantidad; //Declaro la o las variables a utilizar
            double porcentajeHombres, porcentajeMujeres;

            Console.WriteLine(" Calculo porcentual de hombre y mujeres en un curso"); //Imprimo en pantalla un mensaje descriptivo del programa
            try //Aplico un control de excepciones en caso de errores
            {
                Console.Write("\nIngrese la cantidad de hombres: "); //Imprimo mensajes en pantalla para el usuario
                cantidadHombres = Convert.ToInt32(Console.ReadLine()); //Capturo el valor ingresadro por teclado y lo convierto a double
                Console.Write("Ingrese la cantidad de mujeres: ");
                cantidadMujeres = Convert.ToInt32(Console.ReadLine());

                totalCantidad = cantidadHombres + cantidadMujeres; //Determino la cantidad total de personas en el curso
                porcentajeHombres = Convert.ToDouble((cantidadHombres * 100) / totalCantidad); //Obtengo el porcentaje de hombres en el curso
                porcentajeMujeres = Convert.ToDouble((cantidadMujeres * 100) / totalCantidad); //Obtengo el porcentaje de mujeres en el curso

                Console.WriteLine("\nPorcentaje de hombres en el curso: {0:N2}%", porcentajeHombres); //Imprimo el resultado formateado
                Console.Write("Porcentaje de mujeres en el curso: {0:N2}%", porcentajeMujeres);
            }
            catch (Exception error) //Capturo la excepcion en caso de errores
            {
                Console.WriteLine("\n" + error.Message); //Impreso el mensaje de error
            }
            Console.ReadKey(); //Hago una pausa durante la ejecucion del programa
        }
    }
}
