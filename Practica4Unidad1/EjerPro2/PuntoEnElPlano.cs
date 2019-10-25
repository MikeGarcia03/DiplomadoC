using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro2
{
    class PuntoEnElPlano
    {
        private double x, y;

        public void Cargar()
        {
            Console.Write("\nIngrese el valor de x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de y: ");
            y = double.Parse(Console.ReadLine());
        }

        public void Cuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("\nEste punto se encuentran en el primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("\nEste punto se encuentran en el segundo cuadrante");
            }
        }
    }
}
