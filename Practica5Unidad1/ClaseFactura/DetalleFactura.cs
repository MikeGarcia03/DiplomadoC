using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFactura
{
    class DetalleFactura
    {
        private Producto producto;
        private decimal total;

        public Producto Producto
        {
            get { return producto; }
        }
        public decimal Cantidad { get; set; }
        
        public decimal Total
        {
            get { return total; }
        }

        public void addLinea(Producto producto, decimal cantidad)
        {
            this.producto = producto;
            if (this.Cantidad == 0)
            {
                this.Cantidad = cantidad;
            }
            this.total = this.Cantidad * this.producto.precio;
        }
    }
}
