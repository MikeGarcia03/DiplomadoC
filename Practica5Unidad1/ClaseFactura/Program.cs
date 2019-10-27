﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFactura
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresa = new Empresa() { nombre="TECHSHYRA", direccion="SALOME UREÑA #12", rnc="0018000124", telefono="829-773-8324"};
            var cliente = new Cliente() { codigo = "00014", nombre = "ROBERTO", apellido = "DE LEON MARTINEZ", direccion = "POR AHI" };
            var empleado = new Empleado() { codigo = "00001", nombre = "ROSA", apellido = "FERRERAS", direccion = "POR AHI...", puesto = "CAJERA" };

            var factura = new Factura(empresa, cliente, empleado);
            factura.Fecha = DateTime.Now;

            Console.WriteLine("++++++++++++++ FACTURA ++++++++++++++");
            Console.WriteLine("++++++++++++++ "+empresa.nombre+" ++++++++++++");

            while (true)
            {
                var producto = new Producto();
                var detalleFactura = new DetalleFactura();

                Console.Write("INGRESE CODIGO PRODUCTO: ");
                producto.codigo = Console.ReadLine();
                Console.Write("INGRESE NOMBRE PRODUCTO: ");
                producto.descripcion = Console.ReadLine();
                Console.Write("INGRESE PRECIO PRODUCTO: ");
                decimal precio;
                if (decimal.TryParse(Console.ReadLine(), out precio) == false)
                    break;
                Console.Write("INGRESE CANTIDAD: ");
                decimal cantidad;
                if (decimal.TryParse(Console.ReadLine(), out cantidad) == false)
                    break;

                producto.precio = precio;
                detalleFactura.addLinea(producto, cantidad);

                factura.AddLineaFactura(detalleFactura);

                Console.WriteLine("++++++++++ MENU ++++++++++");
                Console.WriteLine("[S] CANCELAR");
                Console.WriteLine("[C] CONTINUAR");
                Console.WriteLine("[I] IMPRIMIR FACTURA");

                string op = Console.ReadLine();
                if (op == "I" || op == "i")
                {
                    factura.Imprimir();
                    break;
                }
                else if (op == "S" || op == "s")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("++++++++++++++ FACTURA ++++++++++++++");
                    Console.WriteLine("++++++++++++++ " + empresa.nombre + " ++++++++++++");
                }

                Console.ReadKey();
            }
        }
    }
}
