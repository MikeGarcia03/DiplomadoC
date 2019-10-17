using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5, B = 3, C = -12;

            Console.WriteLine(A > 3); //a) Verdadero
            Console.WriteLine(A > C); //b) Verdadero
            Console.WriteLine(A < C); //c) Falso
            Console.WriteLine(B < C); //d) Falso
            Console.WriteLine(B != C); //e) Verdadero
            Console.WriteLine(A == 3); //f) Falso
            Console.WriteLine(A * B == 15); //g) Verdadero
            Console.WriteLine(A * B == 30); //h) Falso
            Console.WriteLine(C / B < A); //i) Verdadero
            Console.WriteLine(C / B == 10); //j) Falso
            Console.WriteLine(C / B == -4); //k) Verdadero
            Console.WriteLine(A + B + C == 5); //l) Falso
            Console.WriteLine((B == 8) && (B == 2)); //m) Falso
            Console.WriteLine((B == 8) || (B == 6)); //n) Falso
            Console.WriteLine(A > 3 && B > 3 && C < 3); //o) Falso
            Console.WriteLine(A > 3 && B >= 3 && C < -3); //p) Verdadero

            Console.ReadKey();
        }
    }
}
