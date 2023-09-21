using ejercicioRepaso.Controladores;
using ejercicioRepaso.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se crea la lista y la interfaz
            int opcion = 0;
            List <Empleado> empleados = new List<Empleado>();
            interfazRegistro inter = new implementacionRegistro();
            do
            {
                //Se muestra el menu
                Util.Menu();
                //Se pìde la opcion
               opcion = Util.CapturaEntero("Introduzca una opcion ", 0, 3);
                //Limpia la pantalla
                Console.Clear();
                //Se comprueba para elegir la opcion
                switch (opcion)
                {
                    case 1:
                        inter.RegistroEmpleado(empleados);
                        break;
                    case 2:
                        inter.ModificarEmpleado(empleados);
                        break;
                    case 3:
                        inter.ExportarEmpleado(empleados);
                        break;
                }
                //Limpia la pantalla
                Console.Clear();
            } while(opcion!=0);
        }
    }
}
