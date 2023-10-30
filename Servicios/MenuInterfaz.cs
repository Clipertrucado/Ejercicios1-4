using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra los diferentes opciones que tiene nuestro menu y que se escoja uno
        /// 251023 - sav
        /// </summary>
        /// <returns></returns>
        public int Menu();

        public int Datos();

        public double DatosDecimal();

        public string continuar();
    }
}
