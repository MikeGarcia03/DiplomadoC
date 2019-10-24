using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro1
{
    class Empleado
    {
        private int sueldo;
        private string nombre;

        public void Carga()
        {
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese sueldo: ");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.Write("Nomnbre: ");
            Console.WriteLine(nombre);
            Console.Write("Sueldo: {0:C2}", sueldo);
        }

        public void Impuesto()
        {
            if (sueldo > 30000)
            {
                Console.Write("\nDebe pagar impuesto");
            }
        }
    }
}
