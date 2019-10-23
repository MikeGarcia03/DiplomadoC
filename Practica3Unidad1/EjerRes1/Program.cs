using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat;

            public void Carga()
            {
                Console.Write("\nCuantas filas tiene la matriz: ");
                string linea;
                linea = Console.ReadLine();
                int filas = int.Parse(linea);
                Console.Write("Cuantas columnas tiene la matriz: ");
                linea = Console.ReadLine();
                int columnas = int.Parse(linea);
                mat = new int[filas, columnas];
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    for (int c = 0; c < mat.GetLength(1); c++)
                    {
                        Console.Write("Ingrese componente: ");
                        linea = Console.ReadLine();
                        mat[f, c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    Console.WriteLine();
                    for (int c = 0; c < mat.GetLength(1); c++)
                    {
                        Console.Write(mat[f, c] + " ");
                    }
                }
                Console.WriteLine("\n");
                Console.ReadKey();
            }

            public void ImprimirUltimaFila()
            {
                Console.WriteLine("Ultima fila\n");
                for (int c = 0; c < mat.GetLength(0); c++)
                {
                    Console.Write(mat[mat.GetLength(0) - 1, c] + " ");
                }
            }

            static void Main(string[] args)
            {
                Program matriz = new Program();
                matriz.Carga();
                matriz.Imprimir();
                matriz.ImprimirUltimaFila();
                Console.ReadKey();
            }
        }
    }
}
