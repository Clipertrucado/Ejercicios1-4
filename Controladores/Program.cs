using Secuencial.Servicios;

namespace Secuencial.Controladores {


    class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicación
        /// 101023 - sav
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //creamos un objeto de la clase MenuImplementación
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            //creamos un tipo bool para poder cerrar el while
            bool cerrarMenu = false;

            // este int sera el encargado de guardar el valor seleccionado en el menu
            int opcionSeleccionada;

            //crearemos un while para que nos mantengamos en el menu siempre que no se diga lo contrario
            while (!cerrarMenu)
            {
                //llamamos al metodo menu 
                opcionSeleccionada = mi.Menu();


                Console.WriteLine(opcionSeleccionada);

                // este int contendra el resultado de la llamada
                int num1;
                double num2;
                
                     

                //compara la opcion seleccionada y entra en el casos correcto
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - se ejecuta caso uno 0");
                        cerrarMenu = true;
                        break;

                    case 1:

                        Console.WriteLine("Ingrese loso numeros mayores que 0");
                        num1 = mi.Datos();
                        
                        op.Secu(num1);
                       

                    break;

                    case 2:
                       
                        
                            num1 = mi.Datos();
                            num2 = mi.DatosDecimal();
                            Console.WriteLine(num1 +"   "+ num2);
                            op.Elevar(num1, num2);

                    break; 

                    case 3:

                        do {

                            Console.WriteLine("Ingresa solo numeros mayores que 0");
                            num1 = mi.Datos();                        

                        } while (num1 <= 0);

                        op.Cadena(num1);

                    break;

                    case 4:

                        string seleccion;
                        do
                        {
                            int n1 = mi.Datos();
                            op.secuenciaMulti(n1);
                            seleccion = mi.continuar();

                        } while (seleccion == "s");

                    break;

                    default:
                        
                    break;

                }

            }

        }

    }

}


    