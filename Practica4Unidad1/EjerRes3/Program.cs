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
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.Inicializar();
            cuadrado1.ImprimirPerimetro();
            cuadrado1.ImprimirSuperficie();
            Console.ReadKey();
        }
    }
}
