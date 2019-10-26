using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPro3
{
    class Club
    {
        private Socio socio1, socio2, socio3;

        public void MasViejo(string nomb1, string nomb2, string nomb3, int an1, int an2, int an3)
        {

            socio1 = new Socio(nomb1,an1);
            socio2 = new Socio(nomb2,an2);
            socio3 = new Socio(nomb3,an3);

            if (socio1.RetornarAno() > socio2.RetornarAno() && socio1.RetornarAno() > socio3.RetornarAno())
            {
                Console.WriteLine("\n"+ socio1.RetornarNombre() +" es el socio mas antiguo");
                Console.WriteLine("# de años de membresia: "+ socio1.RetornarAno());
            }
            else if (socio2.RetornarAno() > socio3.RetornarAno())
            {
                Console.WriteLine("\n" + socio2.RetornarNombre() + " es el socio mas antiguo");
                Console.WriteLine("# de años de membresia: " + socio2.RetornarAno());
            }
            else
            {
                Console.WriteLine("\n" + socio3.RetornarNombre() + " es el socio mas antiguo");
                Console.WriteLine("# de años de membresia: " + socio3.RetornarAno());
            }
        }
    }
}
