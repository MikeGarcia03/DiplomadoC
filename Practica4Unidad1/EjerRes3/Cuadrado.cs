using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes3
{
    class Cuadrado
    {
        private int lado;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese valor del lado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }

        public void ImprimirPerimetro()
        {
            int perimetro;
            perimetro = lado * 4;
            Console.WriteLine("El perimetro es: "+ perimetro);
        }

        public void ImprimirSuperficie()
        {
            int superficie;
            superficie = lado * lado;
            Console.WriteLine("La superficie es: "+ superficie);
        }
    }
}
