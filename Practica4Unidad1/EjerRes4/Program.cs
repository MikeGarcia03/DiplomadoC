using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes4
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones1 = new Operaciones();
            operaciones1.Inicializar();
            operaciones1.Sumar();
            operaciones1.Restar();
            operaciones1.Multiplicar();
            operaciones1.Dividir();
            Console.ReadKey();
        }
    }
}
