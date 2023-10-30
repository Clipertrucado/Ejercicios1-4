using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial.Servicios
{
    internal interface OperacionInterfaz
    {
        public void Secu(int veces);

        public void Elevar(int entero, double deci);

        public void Cadena(int numero);

        public void secuenciaMulti(int entero);


    }
}
