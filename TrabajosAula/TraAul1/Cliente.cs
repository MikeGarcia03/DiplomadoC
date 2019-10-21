using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraAul1
{
    class Cliente
    {
        #region Propiedades basicas
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Metodos

        public void MostrarInformacion() {

            Console.WriteLine("        INFORMACION DEL CLIENTE\n\n" +
                " NOMBRE: " + Nombre + "\n" +
                " APELLIDO: " + Apellido + "\n" +
                " DIRECCION: " + Direccion);
        }

        public decimal MostarBalance() {

            return 10000;
        }

        public Factura GetFactura(int idFactura) {
            var factura = new Factura();
            factura.monto = 200;
            factura.ITBIS = 100;
            return factura;
        }

        public decimal Calcular(decimal v1, decimal v2){
            return v1 + v2;
        }

        public decimal Calcular(decimal v1, decimal v2, decimal v3){
            return v1 + v2 + v3;
        }

        public static void Guardar(){
            Console.Write("Conectar a la base de datos...");
        }
        #endregion
    }

    public class Factura
    {
        public double monto { get; set; }
        public double ITBIS { get; set; }
    }
}
