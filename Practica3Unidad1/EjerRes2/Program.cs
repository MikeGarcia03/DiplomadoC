using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes2
{
    class Program
    {
        private int[] sueldos;

        public void Carga()
        {
            sueldos = new int[5];
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese el sueldo del operario "+ f +": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f - 1] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            Console.Write("\nLos 5 sueldos de los operarios\n");
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("["+ sueldos[f - 1] +"]\n");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program pa = new Program();
            pa.Carga();
            pa.Imprimir();
        }
    }
}
