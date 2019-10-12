using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes3
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora, sueldo;
            string linea;

            Console.Write("\nIngrese las horas trabajadas por el Soporte Tecnico: ");
            horasTrabajadas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el pago por hora: ");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);

            sueldo = horasTrabajadas * costoHora;

            Console.Write("\nEl sueldo del Soporte Tecnico es: ");
            Console.Write(sueldo);

            Console.ReadKey();
        }
    }
}
