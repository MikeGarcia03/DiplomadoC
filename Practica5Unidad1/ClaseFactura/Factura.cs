using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFactura
{
    class Factura
    {
        private Empresa Empresa;
        private Cliente Cliente;
        private Empleado Empleado;
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Itbis { get; set; }
        public decimal Total { get; set; }
        public List<DetalleFactura> lineaFactura { get; set; }

        public Factura(Empresa empresa, Cliente cliente, Empleado empleado)
        {
            this.Empresa = empresa;
            this.Cliente = cliente;
            this.Empleado = empleado;
            lineaFactura = new List<DetalleFactura>();
        }

        public void AddLineaFactura(DetalleFactura lf)
        {
            lineaFactura.Add(lf);
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("Imprimiendo factura........");
            Console.WriteLine();
            Console.WriteLine(Empresa.nombre);
            Console.WriteLine(Empresa.direccion+" Telefono: "+Empresa.telefono);
            Console.WriteLine(Empresa.rnc);
            Console.WriteLine("Fecha: "+ this.Fecha.ToString("dd/MM/yyyy"));
            Console.WriteLine("++++++++++");
            Console.WriteLine("Cliente: "+Cliente.codigo+" "+Cliente.nombre);
            Console.WriteLine("++++++++++");
            Console.WriteLine("Cajero(a): "+Empleado.codigo+" "+Empleado.nombre);
            Console.WriteLine("++++++++++");
            Console.WriteLine("CODIGO      DESCRIPCION     CANTIDAD     PRECIO      TOTAL");
            foreach (var item in lineaFactura)
            {
                Console.WriteLine(item.Producto.codigo + "    " +
                    item.Producto.descripcion + "   " +
                    item.Cantidad + "   " +
                    item.Producto.precio + "    " +
                    item.Total);
                this.Total += this.Total;
            }
            Console.WriteLine("TOTAL: "+this.Total);
        }
    }
}
