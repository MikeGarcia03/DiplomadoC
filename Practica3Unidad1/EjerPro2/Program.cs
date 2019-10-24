using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro2
{
    class Program
    {
        private int[,] mat = new int[3,4];

        public void Carga()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese el valor para la posicion[{0},{1}]: ", f, c);
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void ImprimirPrimeraColumna()
        {
            Console.WriteLine("\nPrimera Columna\n");
            for (int c = 0; c < mat.GetLength(0); c++)
            {
                Console.Write(mat[c, 0] + "\n");
            }
            Console.WriteLine();
        }

        public void ImprimirPrimeraFila()
        {
            Console.WriteLine("Primera fila\n");
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[0, c] + " ");
            }
            Console.WriteLine();
        }

        public void ImprimirUltimaFila()
        {
            Console.WriteLine("\nUltima fila\n");
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[2, c] + " ");
            }
        }

        static void Main(string[] args)
        {
            Program matriz = new Program();
            matriz.Carga();
            matriz.ImprimirPrimeraColumna();
            matriz.ImprimirPrimeraFila();
            matriz.ImprimirUltimaFila();
            Console.ReadKey();
        }
    }
}
