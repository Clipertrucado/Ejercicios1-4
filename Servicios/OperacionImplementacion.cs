using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        
        public void Cadena(int numero)
        {
            int n1 = 1;
            string anterior ="";
            while (numero >= n1) {

                Console.WriteLine(anterior+n1);
                anterior = anterior + n1;
                n1++;
                
            }
        }

        public void Elevar(int entero, double deci)
        {
            for (int i = 0; i < entero - 1; i++)
            {
                deci = deci*deci;
            }

            Console.WriteLine(deci);
        }

        public void Secu(int veces) {

           
            int sumar;

            for (int i = 1; i < veces + 1 ; i++)
            {

                sumar = i + i - 1;

                Console.WriteLine(i + "     " + sumar);
                
        
            }
            
        }
        public void secuenciaMulti(int entero)
        {
            
            int resu = 1;
            for (int i = 1; i < entero + 1; i++)
            {
                Console.WriteLine(i+"       "+ (resu = resu * i));
                Console.WriteLine("*");
            }

            
        }


    }
}
