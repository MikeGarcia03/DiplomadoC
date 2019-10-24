using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes1
{
    class Triangulo
    {
        private int lado1, lado2, lado3;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese lado 1: ");
            linea = Console.ReadLine();
            lado1 = int.Parse(linea);
            Console.Write("Ingrese lado 2: ");
            linea = Console.ReadLine();
            lado2 = int.Parse(linea);
            Console.Write("Ingrese lado 3: ");
            linea = Console.ReadLine();
            lado3 = int.Parse(linea);
        }

        public void LadoMayor()
        {
            Console.Write("\nLado mayor: ");
            if (lado1 > lado2 && lado1 > lado3)
            {
                Console.Write(lado1);
            }
            else
            {
                if (lado2 > lado3)
                {
                    Console.Write(lado2);
                }
                else
                {
                    Console.Write(lado3);
                }
            }
        }

        public void EsEquilatero()
        {
            Console.WriteLine();
            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.Write("Es un triangulo equilatero");
            }
            else
            {
                Console.Write("No es un triangulo equilatero");
            }
        }

        static void Main(string[] args)
        {
            Triangulo nuevoTriangulo = new Triangulo();
            nuevoTriangulo.Inicializar();
            nuevoTriangulo.LadoMayor();
            nuevoTriangulo.EsEquilatero();
            Console.ReadKey();


        }
    }
}
