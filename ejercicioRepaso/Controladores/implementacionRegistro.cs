using ejercicioRepaso.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioRepaso.Controladores
{
    public class implementacionRegistro : interfazRegistro
    {
        void interfazRegistro.RegistroEmpleado(List<Empleado> empleados)
        {
            try
            {
                //Pide lo valores
                Console.WriteLine("Introduzca su nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Introduzca sus apellidos");
                string apellidos = Console.ReadLine();
                Console.WriteLine("Introduzca su DNI");
                string dni = Console.ReadLine();
                bool ok = true;
                //Creamos los valores del tipo fecha
                int dia, mes, anyo;
                do {
                    dia = Util.CapturaEntero("Introduzca el dia de su fecha de Nacimiento", 1, 31);
                    mes = Util.CapturaEntero("Introduzca el mes de su fecha de Nacimiento", 1, 12);
                    anyo = Util.CapturaEntero("Introduzca el año de su fecha de Nacimiento", 1, DateTime.Now.Year);
                    //Se comprueba la fecha que ha puesto y si coincide con el calendario
                    if (dia > Fecha.diasMaximosMes[mes]||(!DateTime.IsLeapYear(anyo)&&dia==29&&mes==2)) {
                        ok=false;
                    }
                    if(!ok)
                        Console.WriteLine("Puso Mal la fecha");
                } while (!ok);
                Fecha fe = new Fecha(dia,mes,anyo);
                Console.WriteLine("Introduzca su Titulacion mas alta");
                string titulacion = Console.ReadLine();
                int numSS = Util.CapturaEntero("Introduzca su numero de la seguridad social", 0, 99999999);
                int numCuenta = Util.CapturaEntero("Introduzca su numero de Cuenta Bancaria", 0, 99999999);
                //Se consigue el id del usuario
                int numeroRegistro = Util.DaNumero(empleados);
                Console.WriteLine("Su numero de Empleado es: "+numeroRegistro);
                Console.ReadKey();
                //Se crea el objeto dentro de la lista
                empleados.Add(new Empleado(nombre, apellidos, dni, fe, titulacion, numSS, numCuenta, numeroRegistro));
                //Excepciones
            }catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
        }

        void interfazRegistro.ModificarEmpleado(List<Empleado> empleados)
        {
            //Comprueba si la lista esta vacia
            if (empleados.Count == 0)
                Console.WriteLine("No hay ningun empleado registrado");
            else
            {
                //Se pide el id del empleado
                int numEmpleado = Util.CapturaEntero("Introduzca su numero de empleado", 0, 9999);
                //Se usa un boleano para sbaer si ha encontrado el usuario
                bool encontrado = false;
                //Se comprueba si existe
                for(int i = 0; i < empleados.Count; i++)
                {
                    //Si es igual se deja que modifique
                    if (numEmpleado == empleados[i].NumeroEmpleado)
                    {
                        try
                        {
                            Console.WriteLine("Introduzca su Nombre: ");
                            empleados[i].Nombre = Console.ReadLine();
                            Console.WriteLine("Introduzca su Apèllidos: ");
                            empleados[i].Apellidos = Console.ReadLine();
                            Console.WriteLine("Introduzca su Titulacion Mas Alta: ");
                            empleados[i].TitulacionMasAlta = Console.ReadLine();
                            //Excepciones
                        }catch(Exception e)
                        {
                            Console.WriteLine("Error: "+e.Message);
                        }
                        //Se pone a true al encontralo
                        encontrado=true;
                    }
                }
                //Si no lo encuntra entra y avisa
                if(!encontrado)
                    Console.WriteLine("no se ha encontrado su usuario");
            }
        }

        void interfazRegistro.ExportarEmpleado(List<Empleado> empleados)
        {
            // Se usa una variable boleana para saber si lo ha encontrado 
            bool encontrado = false;
            try
            {
                //Se comprueba si esta vacia la lista
                if (empleados.Count == 0)
                    Console.WriteLine("No hay ningun Empleado Registrado");
                else
                {
                    //Se piede el id al usuario
                    int numE = Util.CapturaEntero("Introduzca su numero de Empleado", 0, 9999);
                    interfazEscritura inter = new implementacionEscritura();
                    // Se crea el streamwriter para abrir el fichero
                    StreamWriter sw = inter.abrirFichero("C:\\Users\\Puesto3\\Desktop\\Ficheros\\empleadosCchar.txt", false);
                   //Se recorre el bucle para encontar al usuario
                    for (int i = 0; i < empleados.Count; i++)
                    {
                        if (empleados[i].NumeroEmpleado == numE)
                        {
                            //Se pregunta cuantos usuarios quiere exportar
                            int opcion = Util.CapturaEntero("Introduzca quienes exportar\n1-Su unico Empleado\n2-Todos los Empleados\n0-Salir", 0, 2);
                            switch (opcion)
                            {
                                case 1:
                                    //Se escribe los datos
                                    inter.escribir(sw, empleados[i].TextoArchivo);
                                    Console.WriteLine("Se pasaron los datos correctamente");
                                    break;
                                case 2:
                                    //Se hace un bucle para exportar todos los datos
                                    for (int j = 0; j < empleados.Count; j++)
                                    {
                                        inter.escribir(sw, empleados[j].TextoArchivo);
                                    }
                                    Console.WriteLine("Se pasaron los datos correctamente");
                                    break;
                            }
                            //Si en cuentra al suuario se pone a true
                            encontrado = true;
                        }
                        //Si no lo ha encontrado lo avisa
                        if (!encontrado)
                        {
                            Console.WriteLine("No tiene permiso para exportar archivos o no puso bien el numero de empleado");
                        }
                    }
                    //Se cierra el fichero
                    inter.cerrar(sw);
                }
                //Excepciones
            }catch(Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
            }
        }
    }
}
