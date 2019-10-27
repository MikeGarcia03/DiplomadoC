using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseFactura
{
    class Empleado:Persona
    {
        public decimal sueldo { get; set; }
        public DateTime horario { get; set; }
        public string puesto { get; set; }
        public string seguro { get; set; }
    }
}
