using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraAul1
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Cliente();
            c1.Nombre = "MIGUEL ANGEL";
            c1.Apellido = "GARCIA DESENA";
            c1.Direccion = "EN ALGUN LUGAR DEL MUNDO...";

            Cliente.Guardar();
            c1.MostrarInformacion();
            decimal balance = c1.MostarBalance();
            Console.WriteLine(c1.Calcular(5,10));
            Console.WriteLine(c1.Calcular(5,10,15));
            Console.WriteLine(" BALANCE CLIENTE: " + balance.ToString("N2"));

            var fa = c1.GetFactura(1);
            Console.WriteLine(" MONTO FACTURA: " + fa.monto + "\n" +
                " MONTO ITBIS: " + fa.ITBIS);
            Console.ReadKey();
        }
    }
}
