﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFactura
{
    class Producto
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal precio { get; set; }
        public decimal existencia { get; set; }
    }
}
