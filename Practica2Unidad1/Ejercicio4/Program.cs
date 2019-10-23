using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeroCuenta = new List<int>();
            List<double> saldoCuenta = new List<double>();
            int i = 0, x = 1, v = 0;
            double totalSaldo = 0;

            do
            {

                Console.Write("\n" + (x) + "- Ingrese el numero de cuenta: ");
                numeroCuenta.Add(int.Parse(Console.ReadLine()));
                v = numeroCuenta[i];
                if (numeroCuenta[i] < 0)
                {                    
                    numeroCuenta.RemoveAt(i);
                    break;
                }
                Console.Write((x) + "- Ingrese el saldo de la cuenta: ");
                saldoCuenta.Add(int.Parse(Console.ReadLine()));
                x += 1;
                i += 1;
            } while (v > 0);

            Console.Clear();

            for (int id = 0; id < saldoCuenta.Count; id++)
            {
                if (numeroCuenta[id] < 0)
                {
                    break;
                }
                else
                {
                    Console.Write("\nNumero de cuenta: " + numeroCuenta[id]);
                    if (saldoCuenta[id] > 0)
                    {
                        Console.Write("\nEstado de la cuenta: ACREEDOR");
                        totalSaldo += saldoCuenta[id];
                    }
                    else
                    {
                        if (saldoCuenta[id] < 0)
                        {
                            Console.Write("\nEstado de la cuenta: DEUDOR");
                        }
                        else
                        {
                            Console.Write("\nEstado de la cuenta: NULO");
                        }
                    }
                }
            }
            Console.Write("\n\nTotal saldo cuentas ACREEDOR: {0:C2}", totalSaldo);
            Console.ReadKey();
        }
    }
}
