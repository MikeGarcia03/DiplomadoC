using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerRes4
{
    class Operaciones
    {
        private int valor1, valor2;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese primer numero: ");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);
            Console.Write("Ingrese segundo numero: ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }

        public void Sumar()
        {
            int suma;
            suma = valor1 + valor2;
            Console.WriteLine("La suma es: "+ suma);
        }

        public void Restar()
        {
            int resta;
            resta = valor1 - valor2;
            Console.WriteLine("La resta es: " + resta);
        }

        public void Multiplicar()
        {
            int multiplicacion;
            multiplicacion = valor1 * valor2;
            Console.WriteLine("La multiplicacon es: " + multiplicacion);
        }

        public void Dividir()
        {
            int division;
            division = valor1 / valor2;
            Console.WriteLine("La division es: " + division);
        }
    }
}
