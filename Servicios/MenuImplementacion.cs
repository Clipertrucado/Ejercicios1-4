using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencial.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int Menu()
        {

            int opcionIntroducida;

            Console.WriteLine("#################################");
            Console.WriteLine("      0. Cerrar aplicación");
            Console.WriteLine("      1. Sumar una secuencia de numeros");
            Console.WriteLine("      2. Elevar un decimal al entero que ingresemos");
            Console.WriteLine("      3. Cadena de números sucesivos");
            Console.WriteLine("      4. Multiplicar una secuencia");
            Console.WriteLine("#################################");
            
            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }
        public int Datos()
        {
            int n1;

            Console.WriteLine("Ingresa un número entero");
            n1 = Convert.ToInt32(Console.ReadLine());

            return (n1);
        }

        public double DatosDecimal()
        {
            double n1;

            Console.WriteLine("Ingresa un decimal");
            n1 = double.Parse(Console.ReadLine());

            return (n1);
        }

        public string continuar()
        {

            Console.WriteLine("#################################");
            Console.WriteLine("      Si desea haciendo cadenas de multiplicacion puse "+"s");
            Console.WriteLine("      Si no lo desea puelse cualquier otra tecla");
            Console.WriteLine("#################################");

            
            string seleccion = Console.ReadLine();

            if (seleccion != null)
            {
                return seleccion;
                
            }
            else { 

                seleccion = "0";

            }

            return seleccion;
            
        }
    }
}
