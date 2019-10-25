using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro2
{
    class Program
    {
        static void Main(string[] args)
        {
            PuntoEnElPlano punto = new PuntoEnElPlano();
            punto.Cargar();
            punto.Cuadrante();
            Console.ReadKey();
        }
    }
}
