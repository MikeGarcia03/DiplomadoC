using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro1
{
    class Program
    {
        private int[] sueldosM, sueldosT;

        public void Carga()
        {
            int x = 1;
            sueldosM = new int[4];
            sueldosT = new int[4];
            for (int f = 1; f <= 8; f++)
            {
                if (f <= 4)
                {
                    Console.Write("Ingrese el sueldo matutino # " + f + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldosM[f - 1] = int.Parse(linea);
                }
                else
                {
                    Console.Write("Ingrese el sueldo vespertino # " + x + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldosT[x - 1] = int.Parse(linea);
                    x++;
                }
            }
        }

        public void Imprimir()
        {
            int totalSueldos = 0;
            Console.Write("\nSueldos tanda matutina\n");
            for (int f = 1; f <= 4; f++)
            {
                Console.Write("[" + sueldosM[f - 1] + "]\n");
                totalSueldos += sueldosM[f - 1];
            }
            Console.Write("Total de gastos en sueldos tanda matutina: {0:C2}", totalSueldos);

            totalSueldos = 0;
            Console.WriteLine();

            Console.Write("\nSueldos tanda vespertina\n");
            for (int f = 1; f <= 4; f++)
            {
                Console.Write("[" + sueldosT[f - 1] + "]\n");
                totalSueldos += sueldosT[f - 1];
            }
            Console.Write("Total de gastos en sueldos tanda matutina: {0:C2}", totalSueldos);
        }

        static void Main(string[] args)
        {
            Program sueldos = new Program();
            sueldos.Carga();
            sueldos.Imprimir();
            Console.ReadKey();
        }
    }
}
