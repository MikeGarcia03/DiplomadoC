using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado();
            emp1.Carga();
            emp1.Imprimir();
            emp1.Impuesto();
            Console.ReadKey();
        }
    }
}
